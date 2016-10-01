using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Windows_Speech_DictationRecognizer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Windows.Speech.DictationRecognizer o;
			if(argc==1){
				o=new UnityEngine.Windows.Speech.DictationRecognizer();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Windows.Speech.ConfidenceLevel))){
				UnityEngine.Windows.Speech.ConfidenceLevel a1;
				checkEnum(l,2,out a1);
				o=new UnityEngine.Windows.Speech.DictationRecognizer(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Windows.Speech.DictationTopicConstraint))){
				UnityEngine.Windows.Speech.DictationTopicConstraint a1;
				checkEnum(l,2,out a1);
				o=new UnityEngine.Windows.Speech.DictationRecognizer(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Windows.Speech.ConfidenceLevel a1;
				checkEnum(l,2,out a1);
				UnityEngine.Windows.Speech.DictationTopicConstraint a2;
				checkEnum(l,3,out a2);
				o=new UnityEngine.Windows.Speech.DictationRecognizer(a1,a2);
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
	static public int Start(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.DictationRecognizer self=(UnityEngine.Windows.Speech.DictationRecognizer)checkSelf(l);
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
			UnityEngine.Windows.Speech.DictationRecognizer self=(UnityEngine.Windows.Speech.DictationRecognizer)checkSelf(l);
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
			UnityEngine.Windows.Speech.DictationRecognizer self=(UnityEngine.Windows.Speech.DictationRecognizer)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Status(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.DictationRecognizer self=(UnityEngine.Windows.Speech.DictationRecognizer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.Status);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_AutoSilenceTimeoutSeconds(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.DictationRecognizer self=(UnityEngine.Windows.Speech.DictationRecognizer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.AutoSilenceTimeoutSeconds);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_AutoSilenceTimeoutSeconds(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.DictationRecognizer self=(UnityEngine.Windows.Speech.DictationRecognizer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.AutoSilenceTimeoutSeconds=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_InitialSilenceTimeoutSeconds(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.DictationRecognizer self=(UnityEngine.Windows.Speech.DictationRecognizer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.InitialSilenceTimeoutSeconds);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_InitialSilenceTimeoutSeconds(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.DictationRecognizer self=(UnityEngine.Windows.Speech.DictationRecognizer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.InitialSilenceTimeoutSeconds=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Windows.Speech.DictationRecognizer");
		addMember(l,Start);
		addMember(l,Stop);
		addMember(l,Dispose);
		addMember(l,"Status",get_Status,null,true);
		addMember(l,"AutoSilenceTimeoutSeconds",get_AutoSilenceTimeoutSeconds,set_AutoSilenceTimeoutSeconds,true);
		addMember(l,"InitialSilenceTimeoutSeconds",get_InitialSilenceTimeoutSeconds,set_InitialSilenceTimeoutSeconds,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Windows.Speech.DictationRecognizer));
	}
}
