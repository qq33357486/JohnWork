using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_EventDispatcher : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.EventDispatcher o;
			o=new FairyGUI.EventDispatcher();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddEventListener(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string),typeof(FairyGUI.EventCallback1))){
				FairyGUI.EventDispatcher self=(FairyGUI.EventDispatcher)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				FairyGUI.EventCallback1 a2;
				LuaDelegation.checkDelegate(l,3,out a2);
				self.AddEventListener(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(FairyGUI.EventCallback0))){
				FairyGUI.EventDispatcher self=(FairyGUI.EventDispatcher)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				FairyGUI.EventCallback0 a2;
				LuaDelegation.checkDelegate(l,3,out a2);
				self.AddEventListener(a1,a2);
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
	static public int RemoveEventListener(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string),typeof(FairyGUI.EventCallback1))){
				FairyGUI.EventDispatcher self=(FairyGUI.EventDispatcher)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				FairyGUI.EventCallback1 a2;
				LuaDelegation.checkDelegate(l,3,out a2);
				self.RemoveEventListener(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(FairyGUI.EventCallback0))){
				FairyGUI.EventDispatcher self=(FairyGUI.EventDispatcher)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				FairyGUI.EventCallback0 a2;
				LuaDelegation.checkDelegate(l,3,out a2);
				self.RemoveEventListener(a1,a2);
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
	static public int RemoveEventListeners(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.EventDispatcher self=(FairyGUI.EventDispatcher)checkSelf(l);
				self.RemoveEventListeners();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				FairyGUI.EventDispatcher self=(FairyGUI.EventDispatcher)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.RemoveEventListeners(a1);
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
	static public int DispatchEvent(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(FairyGUI.EventContext))){
				FairyGUI.EventDispatcher self=(FairyGUI.EventDispatcher)checkSelf(l);
				FairyGUI.EventContext a1;
				checkType(l,2,out a1);
				var ret=self.DispatchEvent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				FairyGUI.EventDispatcher self=(FairyGUI.EventDispatcher)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.DispatchEvent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.EventDispatcher self=(FairyGUI.EventDispatcher)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				var ret=self.DispatchEvent(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				FairyGUI.EventDispatcher self=(FairyGUI.EventDispatcher)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				System.Object a3;
				checkType(l,4,out a3);
				var ret=self.DispatchEvent(a1,a2,a3);
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
	static public int BubbleEvent(IntPtr l) {
		try {
			FairyGUI.EventDispatcher self=(FairyGUI.EventDispatcher)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			var ret=self.BubbleEvent(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BroadcastEvent(IntPtr l) {
		try {
			FairyGUI.EventDispatcher self=(FairyGUI.EventDispatcher)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			var ret=self.BroadcastEvent(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.EventDispatcher");
		addMember(l,AddEventListener);
		addMember(l,RemoveEventListener);
		addMember(l,RemoveEventListeners);
		addMember(l,DispatchEvent);
		addMember(l,BubbleEvent);
		addMember(l,BroadcastEvent);
		createTypeMetatable(l,constructor, typeof(FairyGUI.EventDispatcher));
	}
}
