using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GScrollBar : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GScrollBar o;
			o=new FairyGUI.GScrollBar();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetScrollPane(IntPtr l) {
		try {
			FairyGUI.GScrollBar self=(FairyGUI.GScrollBar)checkSelf(l);
			FairyGUI.ScrollPane a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetScrollPane(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConstructFromXML(IntPtr l) {
		try {
			FairyGUI.GScrollBar self=(FairyGUI.GScrollBar)checkSelf(l);
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
	static public int set_displayPerc(IntPtr l) {
		try {
			FairyGUI.GScrollBar self=(FairyGUI.GScrollBar)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.displayPerc=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollPerc(IntPtr l) {
		try {
			FairyGUI.GScrollBar self=(FairyGUI.GScrollBar)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.scrollPerc=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minSize(IntPtr l) {
		try {
			FairyGUI.GScrollBar self=(FairyGUI.GScrollBar)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.minSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GScrollBar");
		addMember(l,SetScrollPane);
		addMember(l,ConstructFromXML);
		addMember(l,"displayPerc",null,set_displayPerc,true);
		addMember(l,"scrollPerc",null,set_scrollPerc,true);
		addMember(l,"minSize",get_minSize,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GScrollBar),typeof(FairyGUI.GComponent));
	}
}
