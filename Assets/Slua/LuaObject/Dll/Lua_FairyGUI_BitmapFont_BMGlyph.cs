using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_BitmapFont_BMGlyph : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.BitmapFont.BMGlyph o;
			o=new FairyGUI.BitmapFont.BMGlyph();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetX(IntPtr l) {
		try {
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
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
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
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
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
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
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
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
	static public int get_width(IntPtr l) {
		try {
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
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
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
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
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
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
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
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
	static public int get_advance(IntPtr l) {
		try {
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.advance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_advance(IntPtr l) {
		try {
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.advance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineHeight(IntPtr l) {
		try {
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lineHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineHeight(IntPtr l) {
		try {
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.lineHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvRect(IntPtr l) {
		try {
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uvRect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvRect(IntPtr l) {
		try {
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
			UnityEngine.Rect v;
			checkValueType(l,2,out v);
			self.uvRect=v;
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
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
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
			FairyGUI.BitmapFont.BMGlyph self=(FairyGUI.BitmapFont.BMGlyph)checkSelf(l);
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
		getTypeTable(l,"FairyGUI.BitmapFont.BMGlyph");
		addMember(l,"offsetX",get_offsetX,set_offsetX,true);
		addMember(l,"offsetY",get_offsetY,set_offsetY,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"advance",get_advance,set_advance,true);
		addMember(l,"lineHeight",get_lineHeight,set_lineHeight,true);
		addMember(l,"uvRect",get_uvRect,set_uvRect,true);
		addMember(l,"channel",get_channel,set_channel,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.BitmapFont.BMGlyph));
	}
}
