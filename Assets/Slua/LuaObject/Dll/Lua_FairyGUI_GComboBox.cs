using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GComboBox : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GComboBox o;
			o=new FairyGUI.GComboBox();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispose(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			self.Dispose();
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
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
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
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
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
	static public int get_visibleItemCount(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.visibleItemCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_visibleItemCount(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.visibleItemCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dropdown(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dropdown);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dropdown(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			FairyGUI.GComponent v;
			checkType(l,2,out v);
			self.dropdown=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onChanged(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onChanged);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
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
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
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
	static public int get_titleColor(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
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
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_items(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.items);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_items(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.items=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_values(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.values);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_values(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.values=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectedIndex(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.selectedIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectedIndex(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.selectedIndex=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.value);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.value=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_popupDirection(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.popupDirection);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_popupDirection(IntPtr l) {
		try {
			FairyGUI.GComboBox self=(FairyGUI.GComboBox)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.popupDirection=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GComboBox");
		addMember(l,Dispose);
		addMember(l,ConstructFromXML);
		addMember(l,Setup_AfterAdd);
		addMember(l,"visibleItemCount",get_visibleItemCount,set_visibleItemCount,true);
		addMember(l,"dropdown",get_dropdown,set_dropdown,true);
		addMember(l,"onChanged",get_onChanged,null,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"titleColor",get_titleColor,set_titleColor,true);
		addMember(l,"items",get_items,set_items,true);
		addMember(l,"values",get_values,set_values,true);
		addMember(l,"selectedIndex",get_selectedIndex,set_selectedIndex,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"popupDirection",get_popupDirection,set_popupDirection,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GComboBox),typeof(FairyGUI.GComponent));
	}
}
