using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Controller : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Controller o;
			o=new FairyGUI.Controller();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetSelectedIndex(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.SetSelectedIndex(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetSelectedPage(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.SetSelectedPage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPageName(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPageName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPageIdByName(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetPageIdByName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddPage(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.AddPage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddPageAt(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.AddPageAt(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemovePage(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.RemovePage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemovePageAt(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.RemovePageAt(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearPages(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			self.ClearPages();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HasPage(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasPage(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Setup(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.Setup(a1);
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
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.name=v;
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
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onChanged);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectedIndex(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
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
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
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
	static public int get_selectedPage(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.selectedPage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectedPage(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.selectedPage=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_previsousIndex(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.previsousIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_previousPage(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.previousPage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pageCount(IntPtr l) {
		try {
			FairyGUI.Controller self=(FairyGUI.Controller)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pageCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Controller");
		addMember(l,SetSelectedIndex);
		addMember(l,SetSelectedPage);
		addMember(l,GetPageName);
		addMember(l,GetPageIdByName);
		addMember(l,AddPage);
		addMember(l,AddPageAt);
		addMember(l,RemovePage);
		addMember(l,RemovePageAt);
		addMember(l,ClearPages);
		addMember(l,HasPage);
		addMember(l,Setup);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"onChanged",get_onChanged,null,true);
		addMember(l,"selectedIndex",get_selectedIndex,set_selectedIndex,true);
		addMember(l,"selectedPage",get_selectedPage,set_selectedPage,true);
		addMember(l,"previsousIndex",get_previsousIndex,null,true);
		addMember(l,"previousPage",get_previousPage,null,true);
		addMember(l,"pageCount",get_pageCount,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Controller),typeof(FairyGUI.EventDispatcher));
	}
}
