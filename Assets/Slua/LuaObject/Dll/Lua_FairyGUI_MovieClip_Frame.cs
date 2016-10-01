using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_MovieClip_Frame : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.MovieClip.Frame o;
			o=new FairyGUI.MovieClip.Frame();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rect(IntPtr l) {
		try {
			FairyGUI.MovieClip.Frame self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.rect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rect(IntPtr l) {
		try {
			FairyGUI.MovieClip.Frame self;
			checkValueType(l,1,out self);
			UnityEngine.Rect v;
			checkValueType(l,2,out v);
			self.rect=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_addDelay(IntPtr l) {
		try {
			FairyGUI.MovieClip.Frame self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.addDelay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_addDelay(IntPtr l) {
		try {
			FairyGUI.MovieClip.Frame self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.addDelay=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvRect(IntPtr l) {
		try {
			FairyGUI.MovieClip.Frame self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.uvRect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvRect(IntPtr l) {
		try {
			FairyGUI.MovieClip.Frame self;
			checkValueType(l,1,out self);
			UnityEngine.Rect v;
			checkValueType(l,2,out v);
			self.uvRect=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.MovieClip.Frame");
		addMember(l,"rect",get_rect,set_rect,true);
		addMember(l,"addDelay",get_addDelay,set_addDelay,true);
		addMember(l,"uvRect",get_uvRect,set_uvRect,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.MovieClip.Frame),typeof(System.ValueType));
	}
}
