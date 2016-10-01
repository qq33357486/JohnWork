using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GRoot : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GRoot o;
			o=new FairyGUI.GRoot();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetContentScaleFactor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetContentScaleFactor(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				FairyGUI.UIContentScaler.ScreenMatchMode a3;
				checkEnum(l,4,out a3);
				self.SetContentScaleFactor(a1,a2,a3);
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
	static public int ApplyContentScaleFactor(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			self.ApplyContentScaleFactor();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ShowWindow(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			FairyGUI.Window a1;
			checkType(l,2,out a1);
			self.ShowWindow(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HideWindow(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			FairyGUI.Window a1;
			checkType(l,2,out a1);
			self.HideWindow(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HideWindowImmediately(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				FairyGUI.Window a1;
				checkType(l,2,out a1);
				self.HideWindowImmediately(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				FairyGUI.Window a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.HideWindowImmediately(a1,a2);
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
	static public int BringToFront(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			FairyGUI.Window a1;
			checkType(l,2,out a1);
			self.BringToFront(a1);
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
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			self.ShowModalWait();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CloseModalWait(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			self.CloseModalWait();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CloseAllExceptModals(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			self.CloseAllExceptModals();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CloseAllWindows(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			self.CloseAllWindows();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTopWindow(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			var ret=self.GetTopWindow();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DisplayObjectToGObject(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			FairyGUI.DisplayObject a1;
			checkType(l,2,out a1);
			var ret=self.DisplayObjectToGObject(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ShowPopup(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				self.ShowPopup(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				FairyGUI.GObject a2;
				checkType(l,3,out a2);
				self.ShowPopup(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				FairyGUI.GObject a2;
				checkType(l,3,out a2);
				System.Object a3;
				checkType(l,4,out a3);
				self.ShowPopup(a1,a2,a3);
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
	static public int GetPoupPosition(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			FairyGUI.GObject a2;
			checkType(l,3,out a2);
			System.Object a3;
			checkType(l,4,out a3);
			var ret=self.GetPoupPosition(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TogglePopup(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				self.TogglePopup(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				FairyGUI.GObject a2;
				checkType(l,3,out a2);
				self.TogglePopup(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				FairyGUI.GObject a2;
				checkType(l,3,out a2);
				System.Object a3;
				checkType(l,4,out a3);
				self.TogglePopup(a1,a2,a3);
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
	static public int HidePopup(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				self.HidePopup();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				self.HidePopup(a1);
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
	static public int ShowTooltips(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.ShowTooltips(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ShowTooltipsWin(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			self.ShowTooltipsWin(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HideTooltips(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			self.HideTooltips();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EnableSound(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			self.EnableSound();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DisableSound(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			self.DisableSound();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PlayOneShotSound(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				UnityEngine.AudioClip a1;
				checkType(l,2,out a1);
				self.PlayOneShotSound(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
				UnityEngine.AudioClip a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.PlayOneShotSound(a1,a2);
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
	static public int get_contentScaleFactor(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.GRoot.contentScaleFactor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inst(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.GRoot.inst);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasModalWindow(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasModalWindow);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modalWaiting(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.modalWaiting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchTarget(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.touchTarget);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasAnyPopup(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasAnyPopup);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_focus(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.focus);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_focus(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			FairyGUI.GObject v;
			checkType(l,2,out v);
			self.focus=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_soundVolume(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.soundVolume);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_soundVolume(IntPtr l) {
		try {
			FairyGUI.GRoot self=(FairyGUI.GRoot)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.soundVolume=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GRoot");
		addMember(l,SetContentScaleFactor);
		addMember(l,ApplyContentScaleFactor);
		addMember(l,ShowWindow);
		addMember(l,HideWindow);
		addMember(l,HideWindowImmediately);
		addMember(l,BringToFront);
		addMember(l,ShowModalWait);
		addMember(l,CloseModalWait);
		addMember(l,CloseAllExceptModals);
		addMember(l,CloseAllWindows);
		addMember(l,GetTopWindow);
		addMember(l,DisplayObjectToGObject);
		addMember(l,ShowPopup);
		addMember(l,GetPoupPosition);
		addMember(l,TogglePopup);
		addMember(l,HidePopup);
		addMember(l,ShowTooltips);
		addMember(l,ShowTooltipsWin);
		addMember(l,HideTooltips);
		addMember(l,EnableSound);
		addMember(l,DisableSound);
		addMember(l,PlayOneShotSound);
		addMember(l,"contentScaleFactor",get_contentScaleFactor,null,false);
		addMember(l,"inst",get_inst,null,false);
		addMember(l,"hasModalWindow",get_hasModalWindow,null,true);
		addMember(l,"modalWaiting",get_modalWaiting,null,true);
		addMember(l,"touchTarget",get_touchTarget,null,true);
		addMember(l,"hasAnyPopup",get_hasAnyPopup,null,true);
		addMember(l,"focus",get_focus,set_focus,true);
		addMember(l,"soundVolume",get_soundVolume,set_soundVolume,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GRoot),typeof(FairyGUI.GComponent));
	}
}
