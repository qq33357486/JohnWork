using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GList : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GList o;
			o=new FairyGUI.GList();
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
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetFromPool(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetFromPool(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddItemFromPool(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
				var ret=self.AddItemFromPool();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.AddItemFromPool(a1);
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
	static public int AddChildAt(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.AddChildAt(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveChildAt(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			var ret=self.RemoveChildAt(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveChildToPoolAt(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.RemoveChildToPoolAt(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveChildToPool(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			self.RemoveChildToPool(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveChildrenToPool(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
				self.RemoveChildrenToPool();
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.RemoveChildrenToPool(a1,a2);
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
	static public int GetSelection(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			var ret=self.GetSelection();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddSelection(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.AddSelection(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveSelection(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.RemoveSelection(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearSelection(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			self.ClearSelection();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SelectAll(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			self.SelectAll();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SelectNone(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			self.SelectNone();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SelectReverse(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			self.SelectReverse();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HandleArrowKey(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.HandleArrowKey(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResizeToFit(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.ResizeToFit(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.ResizeToFit(a1,a2);
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
	static public int AdjustItemsSize(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			self.AdjustItemsSize();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScrollToView(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.ScrollToView(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.ScrollToView(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				self.ScrollToView(a1,a2,a3);
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
	static public int GetFirstChildInView(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			var ret=self.GetFirstChildInView();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetVirtual(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			self.SetVirtual();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetVirtualAndLoop(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			self.SetVirtualAndLoop();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RefreshVirtualList(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			self.RefreshVirtualList();
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
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
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
	static public int get_defaultItem(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultItem);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultItem(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.defaultItem=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoResizeItem(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoResizeItem);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoResizeItem(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.autoResizeItem=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectionMode(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.selectionMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectionMode(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			FairyGUI.ListSelectionMode v;
			checkEnum(l,2,out v);
			self.selectionMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_itemRenderer(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			FairyGUI.ListItemRenderer v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.itemRenderer=v;
			else if(op==1) self.itemRenderer+=v;
			else if(op==2) self.itemRenderer-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_itemProvider(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			FairyGUI.ListItemProvider v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.itemProvider=v;
			else if(op==1) self.itemProvider+=v;
			else if(op==2) self.itemProvider-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollItemToViewOnClick(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scrollItemToViewOnClick);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollItemToViewOnClick(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.scrollItemToViewOnClick=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onClickItem(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onClickItem);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layout(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.layout);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layout(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			FairyGUI.ListLayoutType v;
			checkEnum(l,2,out v);
			self.layout=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineItemCount(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lineItemCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineItemCount(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.lineItemCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineGap(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lineGap);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineGap(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.lineGap=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_columnGap(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.columnGap);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_columnGap(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.columnGap=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_itemPool(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.itemPool);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectedIndex(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
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
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
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
	static public int get_isVirtual(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isVirtual);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_numItems(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.numItems);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_numItems(IntPtr l) {
		try {
			FairyGUI.GList self=(FairyGUI.GList)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.numItems=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GList");
		addMember(l,Dispose);
		addMember(l,GetFromPool);
		addMember(l,AddItemFromPool);
		addMember(l,AddChildAt);
		addMember(l,RemoveChildAt);
		addMember(l,RemoveChildToPoolAt);
		addMember(l,RemoveChildToPool);
		addMember(l,RemoveChildrenToPool);
		addMember(l,GetSelection);
		addMember(l,AddSelection);
		addMember(l,RemoveSelection);
		addMember(l,ClearSelection);
		addMember(l,SelectAll);
		addMember(l,SelectNone);
		addMember(l,SelectReverse);
		addMember(l,HandleArrowKey);
		addMember(l,ResizeToFit);
		addMember(l,AdjustItemsSize);
		addMember(l,ScrollToView);
		addMember(l,GetFirstChildInView);
		addMember(l,SetVirtual);
		addMember(l,SetVirtualAndLoop);
		addMember(l,RefreshVirtualList);
		addMember(l,Setup_BeforeAdd);
		addMember(l,"defaultItem",get_defaultItem,set_defaultItem,true);
		addMember(l,"autoResizeItem",get_autoResizeItem,set_autoResizeItem,true);
		addMember(l,"selectionMode",get_selectionMode,set_selectionMode,true);
		addMember(l,"itemRenderer",null,set_itemRenderer,true);
		addMember(l,"itemProvider",null,set_itemProvider,true);
		addMember(l,"scrollItemToViewOnClick",get_scrollItemToViewOnClick,set_scrollItemToViewOnClick,true);
		addMember(l,"onClickItem",get_onClickItem,null,true);
		addMember(l,"layout",get_layout,set_layout,true);
		addMember(l,"lineItemCount",get_lineItemCount,set_lineItemCount,true);
		addMember(l,"lineGap",get_lineGap,set_lineGap,true);
		addMember(l,"columnGap",get_columnGap,set_columnGap,true);
		addMember(l,"itemPool",get_itemPool,null,true);
		addMember(l,"selectedIndex",get_selectedIndex,set_selectedIndex,true);
		addMember(l,"isVirtual",get_isVirtual,null,true);
		addMember(l,"numItems",get_numItems,set_numItems,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GList),typeof(FairyGUI.GComponent));
	}
}
