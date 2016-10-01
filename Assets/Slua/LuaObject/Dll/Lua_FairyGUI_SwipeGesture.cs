using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_SwipeGesture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.SwipeGesture o;
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			o=new FairyGUI.SwipeGesture(a1);
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
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
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
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
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
	static public int get_velocity(IntPtr l) {
		try {
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.velocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		try {
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.velocity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		try {
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		try {
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.position=v;
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
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
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
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
			UnityEngine.Vector2 v;
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
	static public int get_actionDistance(IntPtr l) {
		try {
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.actionDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_actionDistance(IntPtr l) {
		try {
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.actionDistance=v;
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
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
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
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
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
	static public int get_ACTION_DISTANCE(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.SwipeGesture.ACTION_DISTANCE);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ACTION_DISTANCE(IntPtr l) {
		try {
			System.Int32 v;
			checkType(l,2,out v);
			FairyGUI.SwipeGesture.ACTION_DISTANCE=v;
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
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
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
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onMove(IntPtr l) {
		try {
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onMove);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onAction(IntPtr l) {
		try {
			FairyGUI.SwipeGesture self=(FairyGUI.SwipeGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onAction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.SwipeGesture");
		addMember(l,Dispose);
		addMember(l,Enable);
		addMember(l,"velocity",get_velocity,set_velocity,true);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"delta",get_delta,set_delta,true);
		addMember(l,"actionDistance",get_actionDistance,set_actionDistance,true);
		addMember(l,"snapping",get_snapping,set_snapping,true);
		addMember(l,"ACTION_DISTANCE",get_ACTION_DISTANCE,set_ACTION_DISTANCE,false);
		addMember(l,"onBegin",get_onBegin,null,true);
		addMember(l,"onEnd",get_onEnd,null,true);
		addMember(l,"onMove",get_onMove,null,true);
		addMember(l,"onAction",get_onAction,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.SwipeGesture),typeof(FairyGUI.EventDispatcher));
	}
}
