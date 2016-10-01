using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_DynamicFont : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.DynamicFont o;
			System.String a1;
			checkType(l,2,out a1);
			o=new FairyGUI.DynamicFont(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetFormat(IntPtr l) {
		try {
			FairyGUI.DynamicFont self=(FairyGUI.DynamicFont)checkSelf(l);
			FairyGUI.TextFormat a1;
			checkType(l,2,out a1);
			self.SetFormat(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PrepareCharacters(IntPtr l) {
		try {
			FairyGUI.DynamicFont self=(FairyGUI.DynamicFont)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.PrepareCharacters(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGlyphSize(IntPtr l) {
		try {
			FairyGUI.DynamicFont self=(FairyGUI.DynamicFont)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			System.Int32 a3;
			var ret=self.GetGlyphSize(a1,out a2,out a3);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			return 4;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGlyph(IntPtr l) {
		try {
			FairyGUI.DynamicFont self=(FairyGUI.DynamicFont)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			var ret=self.GetGlyph(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.DynamicFont");
		addMember(l,SetFormat);
		addMember(l,PrepareCharacters);
		addMember(l,GetGlyphSize);
		addMember(l,GetGlyph);
		createTypeMetatable(l,constructor, typeof(FairyGUI.DynamicFont),typeof(FairyGUI.BaseFont));
	}
}
