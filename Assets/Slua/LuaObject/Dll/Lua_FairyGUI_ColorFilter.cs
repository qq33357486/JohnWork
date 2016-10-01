using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_ColorFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.ColorFilter o;
			o=new FairyGUI.ColorFilter();
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
			FairyGUI.ColorFilter self=(FairyGUI.ColorFilter)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Update(IntPtr l) {
		try {
			FairyGUI.ColorFilter self=(FairyGUI.ColorFilter)checkSelf(l);
			self.Update();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Invert(IntPtr l) {
		try {
			FairyGUI.ColorFilter self=(FairyGUI.ColorFilter)checkSelf(l);
			self.Invert();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AdjustSaturation(IntPtr l) {
		try {
			FairyGUI.ColorFilter self=(FairyGUI.ColorFilter)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.AdjustSaturation(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AdjustContrast(IntPtr l) {
		try {
			FairyGUI.ColorFilter self=(FairyGUI.ColorFilter)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.AdjustContrast(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AdjustBrightness(IntPtr l) {
		try {
			FairyGUI.ColorFilter self=(FairyGUI.ColorFilter)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.AdjustBrightness(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AdjustHue(IntPtr l) {
		try {
			FairyGUI.ColorFilter self=(FairyGUI.ColorFilter)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.AdjustHue(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Tint(IntPtr l) {
		try {
			FairyGUI.ColorFilter self=(FairyGUI.ColorFilter)checkSelf(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.Tint(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Reset(IntPtr l) {
		try {
			FairyGUI.ColorFilter self=(FairyGUI.ColorFilter)checkSelf(l);
			self.Reset();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConcatValues(IntPtr l) {
		try {
			FairyGUI.ColorFilter self=(FairyGUI.ColorFilter)checkSelf(l);
			System.Single[] a1;
			checkParams(l,2,out a1);
			self.ConcatValues(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		try {
			FairyGUI.ColorFilter self=(FairyGUI.ColorFilter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.target);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		try {
			FairyGUI.ColorFilter self=(FairyGUI.ColorFilter)checkSelf(l);
			FairyGUI.DisplayObject v;
			checkType(l,2,out v);
			self.target=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.ColorFilter");
		addMember(l,Dispose);
		addMember(l,Update);
		addMember(l,Invert);
		addMember(l,AdjustSaturation);
		addMember(l,AdjustContrast);
		addMember(l,AdjustBrightness);
		addMember(l,AdjustHue);
		addMember(l,Tint);
		addMember(l,Reset);
		addMember(l,ConcatValues);
		addMember(l,"target",get_target,set_target,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.ColorFilter));
	}
}
