using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Windows_Speech_SemanticMeaning : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.SemanticMeaning o;
			o=new UnityEngine.Windows.Speech.SemanticMeaning();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_key(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.SemanticMeaning self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.key);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_key(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.SemanticMeaning self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.key=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_values(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.SemanticMeaning self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.values);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_values(IntPtr l) {
		try {
			UnityEngine.Windows.Speech.SemanticMeaning self;
			checkValueType(l,1,out self);
			System.String[] v;
			checkArray(l,2,out v);
			self.values=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Windows.Speech.SemanticMeaning");
		addMember(l,"key",get_key,set_key,true);
		addMember(l,"values",get_values,set_values,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Windows.Speech.SemanticMeaning),typeof(System.ValueType));
	}
}
