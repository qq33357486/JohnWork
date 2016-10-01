using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_BitmapFont : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.BitmapFont o;
			FairyGUI.PackageItem a1;
			checkType(l,2,out a1);
			o=new FairyGUI.BitmapFont(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddChar(IntPtr l) {
		try {
			FairyGUI.BitmapFont self=(FairyGUI.BitmapFont)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			FairyGUI.BitmapFont.BMGlyph a2;
			checkType(l,3,out a2);
			self.AddChar(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetFormat(IntPtr l) {
		try {
			FairyGUI.BitmapFont self=(FairyGUI.BitmapFont)checkSelf(l);
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
	static public int GetGlyphSize(IntPtr l) {
		try {
			FairyGUI.BitmapFont self=(FairyGUI.BitmapFont)checkSelf(l);
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
			FairyGUI.BitmapFont self=(FairyGUI.BitmapFont)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		try {
			FairyGUI.BitmapFont self=(FairyGUI.BitmapFont)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.size);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		try {
			FairyGUI.BitmapFont self=(FairyGUI.BitmapFont)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.size=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizable(IntPtr l) {
		try {
			FairyGUI.BitmapFont self=(FairyGUI.BitmapFont)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.resizable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizable(IntPtr l) {
		try {
			FairyGUI.BitmapFont self=(FairyGUI.BitmapFont)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.resizable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.BitmapFont");
		addMember(l,AddChar);
		addMember(l,SetFormat);
		addMember(l,GetGlyphSize);
		addMember(l,GetGlyph);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"resizable",get_resizable,set_resizable,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.BitmapFont),typeof(FairyGUI.BaseFont));
	}
}
