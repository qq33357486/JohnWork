using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GoWrapper : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GoWrapper o;
			UnityEngine.GameObject a1;
			checkType(l,2,out a1);
			o=new FairyGUI.GoWrapper(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CacheRenderers(IntPtr l) {
		try {
			FairyGUI.GoWrapper self=(FairyGUI.GoWrapper)checkSelf(l);
			self.CacheRenderers();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispose(IntPtr l) {
		try {
			FairyGUI.GoWrapper self=(FairyGUI.GoWrapper)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderingOrder(IntPtr l) {
		try {
			FairyGUI.GoWrapper self=(FairyGUI.GoWrapper)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.renderingOrder);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderingOrder(IntPtr l) {
		try {
			FairyGUI.GoWrapper self=(FairyGUI.GoWrapper)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.renderingOrder=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layer(IntPtr l) {
		try {
			FairyGUI.GoWrapper self=(FairyGUI.GoWrapper)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.layer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layer(IntPtr l) {
		try {
			FairyGUI.GoWrapper self=(FairyGUI.GoWrapper)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.layer=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GoWrapper");
		addMember(l,CacheRenderers);
		addMember(l,Dispose);
		addMember(l,"renderingOrder",get_renderingOrder,set_renderingOrder,true);
		addMember(l,"layer",get_layer,set_layer,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GoWrapper),typeof(FairyGUI.DisplayObject));
	}
}
