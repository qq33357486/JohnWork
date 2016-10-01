using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GlyphInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GlyphInfo o;
			o=new FairyGUI.GlyphInfo();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vert(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vert);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_vert(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			UnityEngine.Rect v;
			checkValueType(l,2,out v);
			self.vert=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvBottomLeft(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uvBottomLeft);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvBottomLeft(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.uvBottomLeft=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvBottomRight(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uvBottomRight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvBottomRight(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.uvBottomRight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvTopLeft(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uvTopLeft);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvTopLeft(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.uvTopLeft=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvTopRight(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uvTopRight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvTopRight(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.uvTopRight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.width=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.height=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_channel(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.channel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_channel(IntPtr l) {
		try {
			FairyGUI.GlyphInfo self=(FairyGUI.GlyphInfo)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.channel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GlyphInfo");
		addMember(l,"vert",get_vert,set_vert,true);
		addMember(l,"uvBottomLeft",get_uvBottomLeft,set_uvBottomLeft,true);
		addMember(l,"uvBottomRight",get_uvBottomRight,set_uvBottomRight,true);
		addMember(l,"uvTopLeft",get_uvTopLeft,set_uvTopLeft,true);
		addMember(l,"uvTopRight",get_uvTopRight,set_uvTopRight,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"channel",get_channel,set_channel,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GlyphInfo));
	}
}
