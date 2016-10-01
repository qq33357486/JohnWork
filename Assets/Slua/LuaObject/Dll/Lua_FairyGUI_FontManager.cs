using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_FontManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.FontManager o;
			o=new FairyGUI.FontManager();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterFont_s(IntPtr l) {
		try {
			FairyGUI.BaseFont a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			FairyGUI.FontManager.RegisterFont(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnregisterFont_s(IntPtr l) {
		try {
			FairyGUI.BaseFont a1;
			checkType(l,1,out a1);
			FairyGUI.FontManager.UnregisterFont(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetFont_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.FontManager.GetFont(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear_s(IntPtr l) {
		try {
			FairyGUI.FontManager.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.FontManager");
		addMember(l,RegisterFont_s);
		addMember(l,UnregisterFont_s);
		addMember(l,GetFont_s);
		addMember(l,Clear_s);
		createTypeMetatable(l,constructor, typeof(FairyGUI.FontManager));
	}
}
