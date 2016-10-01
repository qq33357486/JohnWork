using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_PinchGesture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.PinchGesture o;
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			o=new FairyGUI.PinchGesture(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispose(IntPtr l) {
		try {
			FairyGUI.PinchGesture self=(FairyGUI.PinchGesture)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Enable(IntPtr l) {
		try {
			FairyGUI.PinchGesture self=(FairyGUI.PinchGesture)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Enable(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scale(IntPtr l) {
		try {
			FairyGUI.PinchGesture self=(FairyGUI.PinchGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scale(IntPtr l) {
		try {
			FairyGUI.PinchGesture self=(FairyGUI.PinchGesture)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.scale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delta(IntPtr l) {
		try {
			FairyGUI.PinchGesture self=(FairyGUI.PinchGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.delta);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delta(IntPtr l) {
		try {
			FairyGUI.PinchGesture self=(FairyGUI.PinchGesture)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.delta=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onBegin(IntPtr l) {
		try {
			FairyGUI.PinchGesture self=(FairyGUI.PinchGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onBegin);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onEnd(IntPtr l) {
		try {
			FairyGUI.PinchGesture self=(FairyGUI.PinchGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onAction(IntPtr l) {
		try {
			FairyGUI.PinchGesture self=(FairyGUI.PinchGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onAction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.PinchGesture");
		addMember(l,Dispose);
		addMember(l,Enable);
		addMember(l,"scale",get_scale,set_scale,true);
		addMember(l,"delta",get_delta,set_delta,true);
		addMember(l,"onBegin",get_onBegin,null,true);
		addMember(l,"onEnd",get_onEnd,null,true);
		addMember(l,"onAction",get_onAction,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.PinchGesture),typeof(FairyGUI.EventDispatcher));
	}
}
