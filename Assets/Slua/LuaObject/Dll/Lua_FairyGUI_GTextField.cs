using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GTextField : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GTextField o;
			o=new FairyGUI.GTextField();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HandleControllerChanged(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			FairyGUI.Controller a1;
			checkType(l,2,out a1);
			self.HandleControllerChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Setup_BeforeAdd(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.Setup_BeforeAdd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Setup_AfterAdd(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.Setup_AfterAdd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onFocusIn(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onFocusIn);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onFocusOut(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onFocusOut);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onChanged(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onChanged);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gearColor(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gearColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.text);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.text=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_displayAsPassword(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.displayAsPassword);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_displayAsPassword(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.displayAsPassword=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textFormat(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textFormat);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textFormat(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			FairyGUI.TextFormat v;
			checkType(l,2,out v);
			self.textFormat=v;
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
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
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
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
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
	static public int get_align(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.align);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_align(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			FairyGUI.AlignType v;
			checkEnum(l,2,out v);
			self.align=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalAlign(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.verticalAlign);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalAlign(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			FairyGUI.VertAlignType v;
			checkEnum(l,2,out v);
			self.verticalAlign=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_singleLine(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.singleLine);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_singleLine(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.singleLine=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stroke(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stroke);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stroke(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.stroke=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_strokeColor(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.strokeColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_strokeColor(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.strokeColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowOffset(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shadowOffset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowOffset(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.shadowOffset=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_UBBEnabled(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.UBBEnabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_UBBEnabled(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.UBBEnabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoSize(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.autoSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoSize(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			FairyGUI.AutoSizeType v;
			checkEnum(l,2,out v);
			self.autoSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textWidth(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textHeight(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_emojies(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.emojies);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_emojies(IntPtr l) {
		try {
			FairyGUI.GTextField self=(FairyGUI.GTextField)checkSelf(l);
			Dictionary<System.UInt32,FairyGUI.Emoji> v;
			checkType(l,2,out v);
			self.emojies=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GTextField");
		addMember(l,HandleControllerChanged);
		addMember(l,Setup_BeforeAdd);
		addMember(l,Setup_AfterAdd);
		addMember(l,"onFocusIn",get_onFocusIn,null,true);
		addMember(l,"onFocusOut",get_onFocusOut,null,true);
		addMember(l,"onChanged",get_onChanged,null,true);
		addMember(l,"gearColor",get_gearColor,null,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"displayAsPassword",get_displayAsPassword,set_displayAsPassword,true);
		addMember(l,"textFormat",get_textFormat,set_textFormat,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"align",get_align,set_align,true);
		addMember(l,"verticalAlign",get_verticalAlign,set_verticalAlign,true);
		addMember(l,"singleLine",get_singleLine,set_singleLine,true);
		addMember(l,"stroke",get_stroke,set_stroke,true);
		addMember(l,"strokeColor",get_strokeColor,set_strokeColor,true);
		addMember(l,"shadowOffset",get_shadowOffset,set_shadowOffset,true);
		addMember(l,"UBBEnabled",get_UBBEnabled,set_UBBEnabled,true);
		addMember(l,"autoSize",get_autoSize,set_autoSize,true);
		addMember(l,"textWidth",get_textWidth,null,true);
		addMember(l,"textHeight",get_textHeight,null,true);
		addMember(l,"emojies",get_emojies,set_emojies,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GTextField),typeof(FairyGUI.GObject));
	}
}
