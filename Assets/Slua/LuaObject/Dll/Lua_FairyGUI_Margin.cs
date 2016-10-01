using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Margin : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Margin o;
			o=new FairyGUI.Margin();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Parse(IntPtr l) {
		try {
			FairyGUI.Margin self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			self.Parse(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_left(IntPtr l) {
		try {
			FairyGUI.Margin self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.left);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_left(IntPtr l) {
		try {
			FairyGUI.Margin self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.left=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_right(IntPtr l) {
		try {
			FairyGUI.Margin self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.right);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_right(IntPtr l) {
		try {
			FairyGUI.Margin self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.right=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_top(IntPtr l) {
		try {
			FairyGUI.Margin self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.top);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_top(IntPtr l) {
		try {
			FairyGUI.Margin self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.top=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bottom(IntPtr l) {
		try {
			FairyGUI.Margin self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.bottom);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bottom(IntPtr l) {
		try {
			FairyGUI.Margin self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.bottom=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Margin");
		addMember(l,Parse);
		addMember(l,"left",get_left,set_left,true);
		addMember(l,"right",get_right,set_right,true);
		addMember(l,"top",get_top,set_top,true);
		addMember(l,"bottom",get_bottom,set_bottom,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Margin),typeof(System.ValueType));
	}
}
