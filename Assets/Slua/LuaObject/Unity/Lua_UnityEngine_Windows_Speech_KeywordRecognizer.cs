using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Windows_Speech_KeywordRecognizer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Windows.Speech.KeywordRecognizer o;
			if(argc==2){
				System.String[] a1;
				checkArray(l,2,out a1);
				o=new UnityEngine.Windows.Speech.KeywordRecognizer(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==3){
				System.String[] a1;
				checkArray(l,2,out a1);
				UnityEngine.Windows.Speech.ConfidenceLevel a2;
				checkEnum(l,3,out a2);
				o=new UnityEngine.Windows.Speech.KeywordRecognizer(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Keywords(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.KeywordRecognizer self=(UnityEngine.Windows.Speech.KeywordRecognizer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Keywords);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Windows.Speech.KeywordRecognizer");
		addMember(l,"Keywords",get_Keywords,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Windows.Speech.KeywordRecognizer),typeof(UnityEngine.Windows.Speech.PhraseRecognizer));
	}
}
