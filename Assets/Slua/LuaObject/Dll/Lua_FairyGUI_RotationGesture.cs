using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_RotationGesture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.RotationGesture o;
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			o=new FairyGUI.RotationGesture(a1);
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
			FairyGUI.RotationGesture self=(FairyGUI.RotationGesture)checkSelf(l);
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
			FairyGUI.RotationGesture self=(FairyGUI.RotationGesture)checkSelf(l);
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
	static public int get_rotation(IntPtr l) {
		try {
			FairyGUI.RotationGesture self=(FairyGUI.RotationGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotation(IntPtr l) {
		try {
			FairyGUI.RotationGesture self=(FairyGUI.RotationGesture)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.rotation=v;
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
			FairyGUI.RotationGesture self=(FairyGUI.RotationGesture)checkSelf(l);
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
			FairyGUI.RotationGesture self=(FairyGUI.RotationGesture)checkSelf(l);
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
	static public int get_snapping(IntPtr l) {
		try {
			FairyGUI.RotationGesture self=(FairyGUI.RotationGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.snapping);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_snapping(IntPtr l) {
		try {
			FairyGUI.RotationGesture self=(FairyGUI.RotationGesture)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.snapping=v;
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
			FairyGUI.RotationGesture self=(FairyGUI.RotationGesture)checkSelf(l);
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
			FairyGUI.RotationGesture self=(FairyGUI.RotationGesture)checkSelf(l);
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
			FairyGUI.RotationGesture self=(FairyGUI.RotationGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onAction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.RotationGesture");
		addMember(l,Dispose);
		addMember(l,Enable);
		addMember(l,"rotation",get_rotation,set_rotation,true);
		addMember(l,"delta",get_delta,set_delta,true);
		addMember(l,"snapping",get_snapping,set_snapping,true);
		addMember(l,"onBegin",get_onBegin,null,true);
		addMember(l,"onEnd",get_onEnd,null,true);
		addMember(l,"onAction",get_onAction,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.RotationGesture),typeof(FairyGUI.EventDispatcher));
	}
}
