using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Windows_Speech_PhraseRecognitionSystem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Restart_s(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.PhraseRecognitionSystem.Restart();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Shutdown_s(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.PhraseRecognitionSystem.Shutdown();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isSupported(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Windows.Speech.PhraseRecognitionSystem.isSupported);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Status(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.Windows.Speech.PhraseRecognitionSystem.Status);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Windows.Speech.PhraseRecognitionSystem");
		addMember(l,Restart_s);
		addMember(l,Shutdown_s);
		addMember(l,"isSupported",get_isSupported,null,false);
		addMember(l,"Status",get_Status,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Windows.Speech.PhraseRecognitionSystem));
	}
}
