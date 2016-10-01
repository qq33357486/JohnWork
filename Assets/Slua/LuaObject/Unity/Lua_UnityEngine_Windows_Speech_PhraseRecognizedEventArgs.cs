using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Windows_Speech_PhraseRecognizedEventArgs : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.PhraseRecognizedEventArgs o;
			o=new UnityEngine.Windows.Speech.PhraseRecognizedEventArgs();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_confidence(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.PhraseRecognizedEventArgs self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.confidence);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_semanticMeanings(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.PhraseRecognizedEventArgs self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.semanticMeanings);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.PhraseRecognizedEventArgs self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.text);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_phraseStartTime(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.PhraseRecognizedEventArgs self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.phraseStartTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_phraseDuration(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.PhraseRecognizedEventArgs self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.phraseDuration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Windows.Speech.PhraseRecognizedEventArgs");
		addMember(l,"confidence",get_confidence,null,true);
		addMember(l,"semanticMeanings",get_semanticMeanings,null,true);
		addMember(l,"text",get_text,null,true);
		addMember(l,"phraseStartTime",get_phraseStartTime,null,true);
		addMember(l,"phraseDuration",get_phraseDuration,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Windows.Speech.PhraseRecognizedEventArgs),typeof(System.ValueType));
	}
}
