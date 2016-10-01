using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_PixelHitTestData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.PixelHitTestData o;
			o=new FairyGUI.PixelHitTestData();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Load(IntPtr l) {
		try {
			FairyGUI.PixelHitTestData self=(FairyGUI.PixelHitTestData)checkSelf(l);
			FairyGUI.Utils.ByteBuffer a1;
			checkType(l,2,out a1);
			self.Load(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelWidth(IntPtr l) {
		try {
			FairyGUI.PixelHitTestData self=(FairyGUI.PixelHitTestData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pixelWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelWidth(IntPtr l) {
		try {
			FairyGUI.PixelHitTestData self=(FairyGUI.PixelHitTestData)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.pixelWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scale(IntPtr l) {
		try {
			FairyGUI.PixelHitTestData self=(FairyGUI.PixelHitTestData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scale(IntPtr l) {
		try {
			FairyGUI.PixelHitTestData self=(FairyGUI.PixelHitTestData)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.scale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixels(IntPtr l) {
		try {
			FairyGUI.PixelHitTestData self=(FairyGUI.PixelHitTestData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pixels);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixels(IntPtr l) {
		try {
			FairyGUI.PixelHitTestData self=(FairyGUI.PixelHitTestData)checkSelf(l);
			System.Byte[] v;
			checkArray(l,2,out v);
			self.pixels=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.PixelHitTestData");
		addMember(l,Load);
		addMember(l,"pixelWidth",get_pixelWidth,set_pixelWidth,true);
		addMember(l,"scale",get_scale,set_scale,true);
		addMember(l,"pixels",get_pixels,set_pixels,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.PixelHitTestData));
	}
}
