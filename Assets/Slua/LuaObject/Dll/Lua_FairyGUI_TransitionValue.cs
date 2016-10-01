using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_TransitionValue : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.TransitionValue o;
			o=new FairyGUI.TransitionValue();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Copy(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
			FairyGUI.TransitionValue a1;
			checkType(l,2,out a1);
			self.Copy(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_f1(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.f1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_f1(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.f1=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_f2(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.f2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_f2(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.f2=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_f3(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.f3);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_f3(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.f3=v;
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
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
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
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
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
	static public int get_c(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
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
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_b(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
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
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
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
	static public int get_s(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
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
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
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
	static public int get_b1(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.b1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_b1(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.b1=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_b2(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.b2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_b2(IntPtr l) {
		try {
			FairyGUI.TransitionValue self=(FairyGUI.TransitionValue)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.b2=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.TransitionValue");
		addMember(l,Copy);
		addMember(l,"f1",get_f1,set_f1,true);
		addMember(l,"f2",get_f2,set_f2,true);
		addMember(l,"f3",get_f3,set_f3,true);
		addMember(l,"i",get_i,set_i,true);
		addMember(l,"c",get_c,set_c,true);
		addMember(l,"b",get_b,set_b,true);
		addMember(l,"s",get_s,set_s,true);
		addMember(l,"b1",get_b1,set_b1,true);
		addMember(l,"b2",get_b2,set_b2,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.TransitionValue));
	}
}
