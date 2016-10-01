using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Windows_Speech_PhraseRecognizer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Start(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.PhraseRecognizer self=(UnityEngine.Windows.Speech.PhraseRecognizer)checkSelf(l);
			self.Start();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Stop(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.PhraseRecognizer self=(UnityEngine.Windows.Speech.PhraseRecognizer)checkSelf(l);
			self.Stop();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispose(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.PhraseRecognizer self=(UnityEngine.Windows.Speech.PhraseRecognizer)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_IsRunning(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.PhraseRecognizer self=(UnityEngine.Windows.Speech.PhraseRecognizer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsRunning);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Windows.Speech.PhraseRecognizer");
		addMember(l,Start);
		addMember(l,Stop);
		addMember(l,Dispose);
		addMember(l,"IsRunning",get_IsRunning,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Windows.Speech.PhraseRecognizer));
	}
}
