using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Window : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Window o;
			o=new FairyGUI.Window();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddUISource(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			FairyGUI.IUISource a1;
			checkType(l,2,out a1);
			self.AddUISource(a1);
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
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			self.Show();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ShowOn(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			FairyGUI.GRoot a1;
			checkType(l,2,out a1);
			self.ShowOn(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Hide(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			self.Hide();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HideImmediately(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			self.HideImmediately();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CenterOn(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			FairyGUI.GRoot a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.CenterOn(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ToggleStatus(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			self.ToggleStatus();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BringToFront(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			self.BringToFront();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ShowModalWait(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
				self.ShowModalWait();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.ShowModalWait(a1);
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
	static public int CloseModalWait(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
				var ret=self.CloseModalWait();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.CloseModalWait(a1);
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
	static public int Init(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			self.Init();
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
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bringToFontOnClick(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bringToFontOnClick);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bringToFontOnClick(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.bringToFontOnClick=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contentPane(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.contentPane);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_contentPane(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			FairyGUI.GComponent v;
			checkType(l,2,out v);
			self.contentPane=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frame(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frame);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_closeButton(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.closeButton);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_closeButton(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			FairyGUI.GObject v;
			checkType(l,2,out v);
			self.closeButton=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragArea(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dragArea);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dragArea(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			FairyGUI.GObject v;
			checkType(l,2,out v);
			self.dragArea=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contentArea(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.contentArea);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_contentArea(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			FairyGUI.GObject v;
			checkType(l,2,out v);
			self.contentArea=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modalWaitingPane(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.modalWaitingPane);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isShowing(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isShowing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isTop(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isTop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modal(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.modal);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_modal(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.modal=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modalWaiting(IntPtr l) {
		try {
			FairyGUI.Window self=(FairyGUI.Window)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.modalWaiting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Window");
		addMember(l,AddUISource);
		addMember(l,Show);
		addMember(l,ShowOn);
		addMember(l,Hide);
		addMember(l,HideImmediately);
		addMember(l,CenterOn);
		addMember(l,ToggleStatus);
		addMember(l,BringToFront);
		addMember(l,ShowModalWait);
		addMember(l,CloseModalWait);
		addMember(l,Init);
		addMember(l,Dispose);
		addMember(l,"bringToFontOnClick",get_bringToFontOnClick,set_bringToFontOnClick,true);
		addMember(l,"contentPane",get_contentPane,set_contentPane,true);
		addMember(l,"frame",get_frame,null,true);
		addMember(l,"closeButton",get_closeButton,set_closeButton,true);
		addMember(l,"dragArea",get_dragArea,set_dragArea,true);
		addMember(l,"contentArea",get_contentArea,set_contentArea,true);
		addMember(l,"modalWaitingPane",get_modalWaitingPane,null,true);
		addMember(l,"isShowing",get_isShowing,null,true);
		addMember(l,"isTop",get_isTop,null,true);
		addMember(l,"modal",get_modal,set_modal,true);
		addMember(l,"modalWaiting",get_modalWaiting,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Window),typeof(FairyGUI.GComponent));
	}
}
