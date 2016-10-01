using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Windows_Speech_GrammarRecognizer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Windows.Speech.GrammarRecognizer o;
			if(argc==2){
				System.String a1;
				checkType(l,2,out a1);
				o=new UnityEngine.Windows.Speech.GrammarRecognizer(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==3){
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Windows.Speech.ConfidenceLevel a2;
				checkEnum(l,3,out a2);
				o=new UnityEngine.Windows.Speech.GrammarRecognizer(a1,a2);
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
	static public int get_GrammarFilePath(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.GrammarRecognizer self=(UnityEngine.Windows.Speech.GrammarRecognizer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.GrammarFilePath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Windows.Speech.GrammarRecognizer");
		addMember(l,"GrammarFilePath",get_GrammarFilePath,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Windows.Speech.GrammarRecognizer),typeof(UnityEngine.Windows.Speech.PhraseRecognizer));
	}
}
