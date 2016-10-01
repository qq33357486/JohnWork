using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GLabel : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GLabel o;
			o=new FairyGUI.GLabel();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConstructFromXML(IntPtr l) {
		try {
			FairyGUI.GLabel self=(FairyGUI.GLabel)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.ConstructFromXML(a1);
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
			FairyGUI.GLabel self=(FairyGUI.GLabel)checkSelf(l);
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
	static public int get_icon(IntPtr l) {
		try {
			FairyGUI.GLabel self=(FairyGUI.GLabel)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.icon);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_icon(IntPtr l) {
		try {
			FairyGUI.GLabel self=(FairyGUI.GLabel)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.icon=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_title(IntPtr l) {
		try {
			FairyGUI.GLabel self=(FairyGUI.GLabel)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.title);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_title(IntPtr l) {
		try {
			FairyGUI.GLabel self=(FairyGUI.GLabel)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.title=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		try {
			FairyGUI.GLabel self=(FairyGUI.GLabel)checkSelf(l);
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
			FairyGUI.GLabel self=(FairyGUI.GLabel)checkSelf(l);
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
	static public int get_editable(IntPtr l) {
		try {
			FairyGUI.GLabel self=(FairyGUI.GLabel)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.editable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_editable(IntPtr l) {
		try {
			FairyGUI.GLabel self=(FairyGUI.GLabel)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.editable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_titleColor(IntPtr l) {
		try {
			FairyGUI.GLabel self=(FairyGUI.GLabel)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.titleColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_titleColor(IntPtr l) {
		try {
			FairyGUI.GLabel self=(FairyGUI.GLabel)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.titleColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GLabel");
		addMember(l,ConstructFromXML);
		addMember(l,Setup_AfterAdd);
		addMember(l,"icon",get_icon,set_icon,true);
		addMember(l,"title",get_title,set_title,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"editable",get_editable,set_editable,true);
		addMember(l,"titleColor",get_titleColor,set_titleColor,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GLabel),typeof(FairyGUI.GComponent));
	}
}
