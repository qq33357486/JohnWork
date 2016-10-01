using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_PixelHitTest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.PixelHitTest o;
			FairyGUI.PixelHitTestData a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			o=new FairyGUI.PixelHitTest(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetEnabled(IntPtr l) {
		try {
			FairyGUI.PixelHitTest self=(FairyGUI.PixelHitTest)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.SetEnabled(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HitTest(IntPtr l) {
		try {
			FairyGUI.PixelHitTest self=(FairyGUI.PixelHitTest)checkSelf(l);
			FairyGUI.Container a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,3,out a2);
			var ret=self.HitTest(a1,ref a2);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetX(IntPtr l) {
		try {
			FairyGUI.PixelHitTest self=(FairyGUI.PixelHitTest)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.offsetX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_offsetX(IntPtr l) {
		try {
			FairyGUI.PixelHitTest self=(FairyGUI.PixelHitTest)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.offsetX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetY(IntPtr l) {
		try {
			FairyGUI.PixelHitTest self=(FairyGUI.PixelHitTest)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.offsetY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_offsetY(IntPtr l) {
		try {
			FairyGUI.PixelHitTest self=(FairyGUI.PixelHitTest)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.offsetY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scaleX(IntPtr l) {
		try {
			FairyGUI.PixelHitTest self=(FairyGUI.PixelHitTest)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scaleX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scaleX(IntPtr l) {
		try {
			FairyGUI.PixelHitTest self=(FairyGUI.PixelHitTest)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.scaleX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scaleY(IntPtr l) {
		try {
			FairyGUI.PixelHitTest self=(FairyGUI.PixelHitTest)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scaleY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scaleY(IntPtr l) {
		try {
			FairyGUI.PixelHitTest self=(FairyGUI.PixelHitTest)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.scaleY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.PixelHitTest");
		addMember(l,SetEnabled);
		addMember(l,HitTest);
		addMember(l,"offsetX",get_offsetX,set_offsetX,true);
		addMember(l,"offsetY",get_offsetY,set_offsetY,true);
		addMember(l,"scaleX",get_scaleX,set_scaleX,true);
		addMember(l,"scaleY",get_scaleY,set_scaleY,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.PixelHitTest));
	}
}
