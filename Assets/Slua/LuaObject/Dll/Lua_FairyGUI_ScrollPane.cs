using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_ScrollPane : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.ScrollPane o;
			FairyGUI.GComponent a1;
			checkType(l,2,out a1);
			FairyGUI.ScrollType a2;
			checkEnum(l,3,out a2);
			FairyGUI.Margin a3;
			checkValueType(l,4,out a3);
			FairyGUI.ScrollBarDisplayType a4;
			checkEnum(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			System.String a6;
			checkType(l,7,out a6);
			System.String a7;
			checkType(l,8,out a7);
			o=new FairyGUI.ScrollPane(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPercX(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetPercX(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPercY(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetPercY(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPosX(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetPosX(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPosY(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetPosY(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScrollTop(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				self.ScrollTop();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.ScrollTop(a1);
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
	static public int ScrollBottom(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				self.ScrollBottom();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.ScrollBottom(a1);
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
	static public int ScrollUp(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				self.ScrollUp();
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.ScrollUp(a1,a2);
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
	static public int ScrollDown(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				self.ScrollDown();
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.ScrollDown(a1,a2);
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
	static public int ScrollLeft(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				self.ScrollLeft();
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.ScrollLeft(a1,a2);
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
	static public int ScrollRight(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				self.ScrollRight();
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.ScrollRight(a1,a2);
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
	static public int ScrollToView(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				self.ScrollToView(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.ScrollToView(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rect),typeof(bool),typeof(bool))){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				UnityEngine.Rect a1;
				checkValueType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				self.ScrollToView(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(FairyGUI.GObject),typeof(bool),typeof(bool))){
				FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
				FairyGUI.GObject a1;
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
	static public int IsChildInView(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			var ret=self.IsChildInView(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onScroll(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onScroll);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onScrollEnd(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onScrollEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_owner(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.owner);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bouncebackEffect(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bouncebackEffect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bouncebackEffect(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.bouncebackEffect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchEffect(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.touchEffect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_touchEffect(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.touchEffect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inertiaDisabled(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.inertiaDisabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inertiaDisabled(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.inertiaDisabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_softnessOnTopOrLeftSide(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.softnessOnTopOrLeftSide);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_softnessOnTopOrLeftSide(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.softnessOnTopOrLeftSide=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollSpeed(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scrollSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollSpeed(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.scrollSpeed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_snapToItem(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.snapToItem);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_snapToItem(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.snapToItem=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mouseWheelEnabled(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mouseWheelEnabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mouseWheelEnabled(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.mouseWheelEnabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_percX(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.percX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_percX(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.percX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_percY(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.percY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_percY(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.percY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_posX(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.posX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_posX(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.posX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_posY(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.posY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_posY(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.posY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isBottomMost(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isBottomMost);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isRightMost(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isRightMost);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentPageX(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currentPageX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_currentPageX(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.currentPageX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentPageY(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currentPageY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_currentPageY(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.currentPageY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contentWidth(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.contentWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contentHeight(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.contentHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_viewWidth(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.viewWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_viewWidth(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.viewWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_viewHeight(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.viewHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_viewHeight(IntPtr l) {
		try {
			FairyGUI.ScrollPane self=(FairyGUI.ScrollPane)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.viewHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.ScrollPane");
		addMember(l,SetPercX);
		addMember(l,SetPercY);
		addMember(l,SetPosX);
		addMember(l,SetPosY);
		addMember(l,ScrollTop);
		addMember(l,ScrollBottom);
		addMember(l,ScrollUp);
		addMember(l,ScrollDown);
		addMember(l,ScrollLeft);
		addMember(l,ScrollRight);
		addMember(l,ScrollToView);
		addMember(l,IsChildInView);
		addMember(l,"onScroll",get_onScroll,null,true);
		addMember(l,"onScrollEnd",get_onScrollEnd,null,true);
		addMember(l,"owner",get_owner,null,true);
		addMember(l,"bouncebackEffect",get_bouncebackEffect,set_bouncebackEffect,true);
		addMember(l,"touchEffect",get_touchEffect,set_touchEffect,true);
		addMember(l,"inertiaDisabled",get_inertiaDisabled,set_inertiaDisabled,true);
		addMember(l,"softnessOnTopOrLeftSide",get_softnessOnTopOrLeftSide,set_softnessOnTopOrLeftSide,true);
		addMember(l,"scrollSpeed",get_scrollSpeed,set_scrollSpeed,true);
		addMember(l,"snapToItem",get_snapToItem,set_snapToItem,true);
		addMember(l,"mouseWheelEnabled",get_mouseWheelEnabled,set_mouseWheelEnabled,true);
		addMember(l,"percX",get_percX,set_percX,true);
		addMember(l,"percY",get_percY,set_percY,true);
		addMember(l,"posX",get_posX,set_posX,true);
		addMember(l,"posY",get_posY,set_posY,true);
		addMember(l,"isBottomMost",get_isBottomMost,null,true);
		addMember(l,"isRightMost",get_isRightMost,null,true);
		addMember(l,"currentPageX",get_currentPageX,set_currentPageX,true);
		addMember(l,"currentPageY",get_currentPageY,set_currentPageY,true);
		addMember(l,"contentWidth",get_contentWidth,null,true);
		addMember(l,"contentHeight",get_contentHeight,null,true);
		addMember(l,"viewWidth",get_viewWidth,set_viewWidth,true);
		addMember(l,"viewHeight",get_viewHeight,set_viewHeight,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.ScrollPane),typeof(FairyGUI.EventDispatcher));
	}
}
