using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_UpdateContext_ClipInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.UpdateContext.ClipInfo o;
			o=new FairyGUI.UpdateContext.ClipInfo();
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
			FairyGUI.UpdateContext.ClipInfo self;
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
			FairyGUI.UpdateContext.ClipInfo self;
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
	static public int get_clipBox(IntPtr l) {
		try {
			FairyGUI.UpdateContext.ClipInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.clipBox);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipBox(IntPtr l) {
		try {
			FairyGUI.UpdateContext.ClipInfo self;
			checkValueType(l,1,out self);
			UnityEngine.Vector4 v;
			checkType(l,2,out v);
			self.clipBox=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_soft(IntPtr l) {
		try {
			FairyGUI.UpdateContext.ClipInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.soft);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_soft(IntPtr l) {
		try {
			FairyGUI.UpdateContext.ClipInfo self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.soft=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_softness(IntPtr l) {
		try {
			FairyGUI.UpdateContext.ClipInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.softness);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_softness(IntPtr l) {
		try {
			FairyGUI.UpdateContext.ClipInfo self;
			checkValueType(l,1,out self);
			UnityEngine.Vector4 v;
			checkType(l,2,out v);
			self.softness=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipId(IntPtr l) {
		try {
			FairyGUI.UpdateContext.ClipInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.clipId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipId(IntPtr l) {
		try {
			FairyGUI.UpdateContext.ClipInfo self;
			checkValueType(l,1,out self);
			System.UInt32 v;
			checkType(l,2,out v);
			self.clipId=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stencil(IntPtr l) {
		try {
			FairyGUI.UpdateContext.ClipInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.stencil);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stencil(IntPtr l) {
		try {
			FairyGUI.UpdateContext.ClipInfo self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.stencil=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.UpdateContext.ClipInfo");
		addMember(l,"rect",get_rect,set_rect,true);
		addMember(l,"clipBox",get_clipBox,set_clipBox,true);
		addMember(l,"soft",get_soft,set_soft,true);
		addMember(l,"softness",get_softness,set_softness,true);
		addMember(l,"clipId",get_clipId,set_clipId,true);
		addMember(l,"stencil",get_stencil,set_stencil,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.UpdateContext.ClipInfo),typeof(System.ValueType));
	}
}
