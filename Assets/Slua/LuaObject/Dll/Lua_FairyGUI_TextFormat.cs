using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_TextFormat : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.TextFormat o;
			o=new FairyGUI.TextFormat();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetColor(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			System.UInt32 a1;
			checkType(l,2,out a1);
			self.SetColor(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EqualStyle(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			FairyGUI.TextFormat a1;
			checkType(l,2,out a1);
			var ret=self.EqualStyle(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CopyFrom(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			FairyGUI.TextFormat a1;
			checkType(l,2,out a1);
			self.CopyFrom(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
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
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
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
	static public int get_font(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.font);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_font(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.font=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.color);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.color=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineSpacing(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lineSpacing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineSpacing(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.lineSpacing=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_letterSpacing(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.letterSpacing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_letterSpacing(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.letterSpacing=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bold(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bold);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bold(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.bold=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_underline(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.underline);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_underline(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.underline=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_italic(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.italic);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_italic(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.italic=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gradientColor(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gradientColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gradientColor(IntPtr l) {
		try {
			FairyGUI.TextFormat self=(FairyGUI.TextFormat)checkSelf(l);
			UnityEngine.Color32[] v;
			checkArray(l,2,out v);
			self.gradientColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.TextFormat");
		addMember(l,SetColor);
		addMember(l,EqualStyle);
		addMember(l,CopyFrom);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"font",get_font,set_font,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"lineSpacing",get_lineSpacing,set_lineSpacing,true);
		addMember(l,"letterSpacing",get_letterSpacing,set_letterSpacing,true);
		addMember(l,"bold",get_bold,set_bold,true);
		addMember(l,"underline",get_underline,set_underline,true);
		addMember(l,"italic",get_italic,set_italic,true);
		addMember(l,"gradientColor",get_gradientColor,set_gradientColor,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.TextFormat));
	}
}
