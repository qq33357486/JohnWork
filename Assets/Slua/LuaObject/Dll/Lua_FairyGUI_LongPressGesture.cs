using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_LongPressGesture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.LongPressGesture o;
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			o=new FairyGUI.LongPressGesture(a1);
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
			FairyGUI.LongPressGesture self=(FairyGUI.LongPressGesture)checkSelf(l);
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
			FairyGUI.LongPressGesture self=(FairyGUI.LongPressGesture)checkSelf(l);
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
	static public int Cancel(IntPtr l) {
		try {
			FairyGUI.LongPressGesture self=(FairyGUI.LongPressGesture)checkSelf(l);
			self.Cancel();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_trigger(IntPtr l) {
		try {
			FairyGUI.LongPressGesture self=(FairyGUI.LongPressGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.trigger);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_trigger(IntPtr l) {
		try {
			FairyGUI.LongPressGesture self=(FairyGUI.LongPressGesture)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.trigger=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_interval(IntPtr l) {
		try {
			FairyGUI.LongPressGesture self=(FairyGUI.LongPressGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.interval);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_interval(IntPtr l) {
		try {
			FairyGUI.LongPressGesture self=(FairyGUI.LongPressGesture)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.interval=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_once(IntPtr l) {
		try {
			FairyGUI.LongPressGesture self=(FairyGUI.LongPressGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.once);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_once(IntPtr l) {
		try {
			FairyGUI.LongPressGesture self=(FairyGUI.LongPressGesture)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.once=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_TRIGGER(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.LongPressGesture.TRIGGER);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_TRIGGER(IntPtr l) {
		try {
			System.Single v;
			checkType(l,2,out v);
			FairyGUI.LongPressGesture.TRIGGER=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_INTERVAL(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.LongPressGesture.INTERVAL);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_INTERVAL(IntPtr l) {
		try {
			System.Single v;
			checkType(l,2,out v);
			FairyGUI.LongPressGesture.INTERVAL=v;
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
			FairyGUI.LongPressGesture self=(FairyGUI.LongPressGesture)checkSelf(l);
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
			FairyGUI.LongPressGesture self=(FairyGUI.LongPressGesture)checkSelf(l);
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
			FairyGUI.LongPressGesture self=(FairyGUI.LongPressGesture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onAction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.LongPressGesture");
		addMember(l,Dispose);
		addMember(l,Enable);
		addMember(l,Cancel);
		addMember(l,"trigger",get_trigger,set_trigger,true);
		addMember(l,"interval",get_interval,set_interval,true);
		addMember(l,"once",get_once,set_once,true);
		addMember(l,"TRIGGER",get_TRIGGER,set_TRIGGER,false);
		addMember(l,"INTERVAL",get_INTERVAL,set_INTERVAL,false);
		addMember(l,"onBegin",get_onBegin,null,true);
		addMember(l,"onEnd",get_onEnd,null,true);
		addMember(l,"onAction",get_onAction,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.LongPressGesture),typeof(FairyGUI.EventDispatcher));
	}
}
