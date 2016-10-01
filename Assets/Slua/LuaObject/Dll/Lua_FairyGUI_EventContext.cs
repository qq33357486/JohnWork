using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_EventContext : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.EventContext o;
			o=new FairyGUI.EventContext();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StopPropagation(IntPtr l) {
		try {
			FairyGUI.EventContext self=(FairyGUI.EventContext)checkSelf(l);
			self.StopPropagation();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PreventDefault(IntPtr l) {
		try {
			FairyGUI.EventContext self=(FairyGUI.EventContext)checkSelf(l);
			self.PreventDefault();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CaptureTouch(IntPtr l) {
		try {
			FairyGUI.EventContext self=(FairyGUI.EventContext)checkSelf(l);
			self.CaptureTouch();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		try {
			FairyGUI.EventContext self=(FairyGUI.EventContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		try {
			FairyGUI.EventContext self=(FairyGUI.EventContext)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.type=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_data(IntPtr l) {
		try {
			FairyGUI.EventContext self=(FairyGUI.EventContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.data);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_data(IntPtr l) {
		try {
			FairyGUI.EventContext self=(FairyGUI.EventContext)checkSelf(l);
			System.Object v;
			checkType(l,2,out v);
			self.data=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sender(IntPtr l) {
		try {
			FairyGUI.EventContext self=(FairyGUI.EventContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sender);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_initiator(IntPtr l) {
		try {
			FairyGUI.EventContext self=(FairyGUI.EventContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.initiator);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDefaultPrevented(IntPtr l) {
		try {
			FairyGUI.EventContext self=(FairyGUI.EventContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isDefaultPrevented);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputEvent(IntPtr l) {
		try {
			FairyGUI.EventContext self=(FairyGUI.EventContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.inputEvent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.EventContext");
		addMember(l,StopPropagation);
		addMember(l,PreventDefault);
		addMember(l,CaptureTouch);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"data",get_data,set_data,true);
		addMember(l,"sender",get_sender,null,true);
		addMember(l,"initiator",get_initiator,null,true);
		addMember(l,"isDefaultPrevented",get_isDefaultPrevented,null,true);
		addMember(l,"inputEvent",get_inputEvent,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.EventContext));
	}
}
