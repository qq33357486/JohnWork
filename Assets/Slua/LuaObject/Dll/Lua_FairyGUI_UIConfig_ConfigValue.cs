using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_UIConfig_ConfigValue : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue o;
			o=new FairyGUI.UIConfig.ConfigValue();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Reset(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue self=(FairyGUI.UIConfig.ConfigValue)checkSelf(l);
			self.Reset();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_valid(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue self=(FairyGUI.UIConfig.ConfigValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.valid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_valid(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue self=(FairyGUI.UIConfig.ConfigValue)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.valid=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_s(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue self=(FairyGUI.UIConfig.ConfigValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.s);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_s(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue self=(FairyGUI.UIConfig.ConfigValue)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.s=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_i(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue self=(FairyGUI.UIConfig.ConfigValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.i);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_i(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue self=(FairyGUI.UIConfig.ConfigValue)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.i=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_f(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue self=(FairyGUI.UIConfig.ConfigValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.f);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_f(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue self=(FairyGUI.UIConfig.ConfigValue)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.f=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_b(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue self=(FairyGUI.UIConfig.ConfigValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.b);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_b(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue self=(FairyGUI.UIConfig.ConfigValue)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.b=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_c(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue self=(FairyGUI.UIConfig.ConfigValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.c);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_c(IntPtr l) {
		try {
			FairyGUI.UIConfig.ConfigValue self=(FairyGUI.UIConfig.ConfigValue)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.c=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.UIConfig.ConfigValue");
		addMember(l,Reset);
		addMember(l,"valid",get_valid,set_valid,true);
		addMember(l,"s",get_s,set_s,true);
		addMember(l,"i",get_i,set_i,true);
		addMember(l,"f",get_f,set_f,true);
		addMember(l,"b",get_b,set_b,true);
		addMember(l,"c",get_c,set_c,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.UIConfig.ConfigValue));
	}
}
