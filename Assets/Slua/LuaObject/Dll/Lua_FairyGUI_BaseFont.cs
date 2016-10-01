using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_BaseFont : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.BaseFont o;
			o=new FairyGUI.BaseFont();
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
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
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
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
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
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
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
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
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
	static public int get_mainTexture(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mainTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mainTexture(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			FairyGUI.NTexture v;
			checkType(l,2,out v);
			self.mainTexture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_canTint(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.canTint);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_canTint(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.canTint=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_canLight(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.canLight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_canLight(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.canLight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_canOutline(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.canOutline);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_canOutline(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.canOutline=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasChannel(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasChannel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hasChannel(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.hasChannel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_customBold(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.customBold);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_customBold(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.customBold=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_customBoldAndItalic(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.customBoldAndItalic);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_customBoldAndItalic(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.customBoldAndItalic=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shader(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shader(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.shader=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packageItem(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.packageItem);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_packageItem(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			FairyGUI.PackageItem v;
			checkType(l,2,out v);
			self.packageItem=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		try {
			FairyGUI.BaseFont self=(FairyGUI.BaseFont)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.BaseFont");
		addMember(l,SetFormat);
		addMember(l,PrepareCharacters);
		addMember(l,GetGlyphSize);
		addMember(l,GetGlyph);
		addMember(l,"mainTexture",get_mainTexture,set_mainTexture,true);
		addMember(l,"canTint",get_canTint,set_canTint,true);
		addMember(l,"canLight",get_canLight,set_canLight,true);
		addMember(l,"canOutline",get_canOutline,set_canOutline,true);
		addMember(l,"hasChannel",get_hasChannel,set_hasChannel,true);
		addMember(l,"customBold",get_customBold,set_customBold,true);
		addMember(l,"customBoldAndItalic",get_customBoldAndItalic,set_customBoldAndItalic,true);
		addMember(l,"shader",get_shader,set_shader,true);
		addMember(l,"packageItem",get_packageItem,set_packageItem,true);
		addMember(l,"name",get_name,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.BaseFont));
	}
}
