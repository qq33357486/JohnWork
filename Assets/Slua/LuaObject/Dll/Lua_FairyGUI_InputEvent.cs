using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_InputEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.InputEvent o;
			o=new FairyGUI.InputEvent();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_x(IntPtr l) {
		try {
			FairyGUI.InputEvent self=(FairyGUI.InputEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.x);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		try {
			FairyGUI.InputEvent self=(FairyGUI.InputEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.y);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyCode(IntPtr l) {
		try {
			FairyGUI.InputEvent self=(FairyGUI.InputEvent)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.keyCode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modifiers(IntPtr l) {
		try {
			FairyGUI.InputEvent self=(FairyGUI.InputEvent)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.modifiers);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mouseWheelDelta(IntPtr l) {
		try {
			FairyGUI.InputEvent self=(FairyGUI.InputEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mouseWheelDelta);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchId(IntPtr l) {
		try {
			FairyGUI.InputEvent self=(FairyGUI.InputEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.touchId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		try {
			FairyGUI.InputEvent self=(FairyGUI.InputEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDoubleClick(IntPtr l) {
		try {
			FairyGUI.InputEvent self=(FairyGUI.InputEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isDoubleClick);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ctrl(IntPtr l) {
		try {
			FairyGUI.InputEvent self=(FairyGUI.InputEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ctrl);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shift(IntPtr l) {
		try {
			FairyGUI.InputEvent self=(FairyGUI.InputEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shift);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alt(IntPtr l) {
		try {
			FairyGUI.InputEvent self=(FairyGUI.InputEvent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.alt);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.InputEvent");
		addMember(l,"x",get_x,null,true);
		addMember(l,"y",get_y,null,true);
		addMember(l,"keyCode",get_keyCode,null,true);
		addMember(l,"modifiers",get_modifiers,null,true);
		addMember(l,"mouseWheelDelta",get_mouseWheelDelta,null,true);
		addMember(l,"touchId",get_touchId,null,true);
		addMember(l,"position",get_position,null,true);
		addMember(l,"isDoubleClick",get_isDoubleClick,null,true);
		addMember(l,"ctrl",get_ctrl,null,true);
		addMember(l,"shift",get_shift,null,true);
		addMember(l,"alt",get_alt,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.InputEvent));
	}
}
