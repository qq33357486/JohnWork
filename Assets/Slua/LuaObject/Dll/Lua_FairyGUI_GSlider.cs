using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GSlider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GSlider o;
			o=new FairyGUI.GSlider();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConstructFromXML(IntPtr l) {
		try {
			FairyGUI.GSlider self=(FairyGUI.GSlider)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.ConstructFromXML(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Setup_AfterAdd(IntPtr l) {
		try {
			FairyGUI.GSlider self=(FairyGUI.GSlider)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.Setup_AfterAdd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onChanged(IntPtr l) {
		try {
			FairyGUI.GSlider self=(FairyGUI.GSlider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onChanged);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onGripTouchEnd(IntPtr l) {
		try {
			FairyGUI.GSlider self=(FairyGUI.GSlider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onGripTouchEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_titleType(IntPtr l) {
		try {
			FairyGUI.GSlider self=(FairyGUI.GSlider)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.titleType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_titleType(IntPtr l) {
		try {
			FairyGUI.GSlider self=(FairyGUI.GSlider)checkSelf(l);
			FairyGUI.ProgressTitleType v;
			checkEnum(l,2,out v);
			self.titleType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_max(IntPtr l) {
		try {
			FairyGUI.GSlider self=(FairyGUI.GSlider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.max);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_max(IntPtr l) {
		try {
			FairyGUI.GSlider self=(FairyGUI.GSlider)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.max=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		try {
			FairyGUI.GSlider self=(FairyGUI.GSlider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.value);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		try {
			FairyGUI.GSlider self=(FairyGUI.GSlider)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.value=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GSlider");
		addMember(l,ConstructFromXML);
		addMember(l,Setup_AfterAdd);
		addMember(l,"onChanged",get_onChanged,null,true);
		addMember(l,"onGripTouchEnd",get_onGripTouchEnd,null,true);
		addMember(l,"titleType",get_titleType,set_titleType,true);
		addMember(l,"max",get_max,set_max,true);
		addMember(l,"value",get_value,set_value,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GSlider),typeof(FairyGUI.GComponent));
	}
}
