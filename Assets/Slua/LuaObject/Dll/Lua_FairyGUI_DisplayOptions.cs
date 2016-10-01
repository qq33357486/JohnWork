using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_DisplayOptions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.DisplayOptions o;
			o=new FairyGUI.DisplayOptions();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetEditModeHideFlags_s(IntPtr l) {
		try {
			FairyGUI.DisplayOptions.SetEditModeHideFlags();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultRoot(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.DisplayOptions.defaultRoot);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultRoot(IntPtr l) {
		try {
			UnityEngine.Transform[] v;
			checkArray(l,2,out v);
			FairyGUI.DisplayOptions.defaultRoot=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hideFlags(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)FairyGUI.DisplayOptions.hideFlags);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hideFlags(IntPtr l) {
		try {
			UnityEngine.HideFlags v;
			checkEnum(l,2,out v);
			FairyGUI.DisplayOptions.hideFlags=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.DisplayOptions");
		addMember(l,SetEditModeHideFlags_s);
		addMember(l,"defaultRoot",get_defaultRoot,set_defaultRoot,false);
		addMember(l,"hideFlags",get_hideFlags,set_hideFlags,false);
		createTypeMetatable(l,constructor, typeof(FairyGUI.DisplayOptions));
	}
}
