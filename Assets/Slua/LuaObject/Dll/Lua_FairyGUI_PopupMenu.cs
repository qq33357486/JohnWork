using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_PopupMenu : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			FairyGUI.PopupMenu o;
			if(argc==1){
				o=new FairyGUI.PopupMenu();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,2,out a1);
				o=new FairyGUI.PopupMenu(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddItem(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string),typeof(FairyGUI.EventCallback1))){
				FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				FairyGUI.EventCallback1 a2;
				LuaDelegation.checkDelegate(l,3,out a2);
				var ret=self.AddItem(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(FairyGUI.EventCallback0))){
				FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				FairyGUI.EventCallback0 a2;
				LuaDelegation.checkDelegate(l,3,out a2);
				var ret=self.AddItem(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddItemAt(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string),typeof(int),typeof(FairyGUI.EventCallback1))){
				FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				FairyGUI.EventCallback1 a3;
				LuaDelegation.checkDelegate(l,4,out a3);
				var ret=self.AddItemAt(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(int),typeof(FairyGUI.EventCallback0))){
				FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				FairyGUI.EventCallback0 a3;
				LuaDelegation.checkDelegate(l,4,out a3);
				var ret=self.AddItemAt(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddSeperator(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			self.AddSeperator();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetItemName(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetItemName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetItemText(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.SetItemText(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetItemVisible(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetItemVisible(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetItemGrayed(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetItemGrayed(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetItemCheckable(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetItemCheckable(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetItemChecked(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetItemChecked(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int isItemChecked(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.isItemChecked(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveItem(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.RemoveItem(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearItems(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			self.ClearItems();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispose(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Show(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
				self.Show();
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.Show(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_itemCount(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.itemCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contentPane(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.contentPane);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_list(IntPtr l) {
		try {
			FairyGUI.PopupMenu self=(FairyGUI.PopupMenu)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.list);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.PopupMenu");
		addMember(l,AddItem);
		addMember(l,AddItemAt);
		addMember(l,AddSeperator);
		addMember(l,GetItemName);
		addMember(l,SetItemText);
		addMember(l,SetItemVisible);
		addMember(l,SetItemGrayed);
		addMember(l,SetItemCheckable);
		addMember(l,SetItemChecked);
		addMember(l,isItemChecked);
		addMember(l,RemoveItem);
		addMember(l,ClearItems);
		addMember(l,Dispose);
		addMember(l,Show);
		addMember(l,"itemCount",get_itemCount,null,true);
		addMember(l,"contentPane",get_contentPane,null,true);
		addMember(l,"list",get_list,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.PopupMenu));
	}
}
