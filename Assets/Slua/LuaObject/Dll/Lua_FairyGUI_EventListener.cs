using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_EventListener : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.EventListener o;
			FairyGUI.EventDispatcher a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			o=new FairyGUI.EventListener(a1,a2);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddCapture(IntPtr l) {
		try {
			FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
			FairyGUI.EventCallback1 a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			self.AddCapture(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveCapture(IntPtr l) {
		try {
			FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
			FairyGUI.EventCallback1 a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			self.RemoveCapture(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(FairyGUI.EventCallback0))){
				FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
				FairyGUI.EventCallback0 a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				self.Add(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(FairyGUI.EventCallback1))){
				FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
				FairyGUI.EventCallback1 a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				self.Add(a1);
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
	static public int Remove(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(FairyGUI.EventCallback0))){
				FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
				FairyGUI.EventCallback0 a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				self.Remove(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(FairyGUI.EventCallback1))){
				FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
				FairyGUI.EventCallback1 a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				self.Remove(a1);
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
	static public int Set(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(FairyGUI.EventCallback1))){
				FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
				FairyGUI.EventCallback1 a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				self.Set(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(FairyGUI.EventCallback0))){
				FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
				FairyGUI.EventCallback0 a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				self.Set(a1);
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
	static public int Clear(IntPtr l) {
		try {
			FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
			self.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Call(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
				var ret=self.Call();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
				System.Object a1;
				checkType(l,2,out a1);
				var ret=self.Call(a1);
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
	static public int BubbleCall(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
				var ret=self.BubbleCall();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
				System.Object a1;
				checkType(l,2,out a1);
				var ret=self.BubbleCall(a1);
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
	static public int BroadcastCall(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
				var ret=self.BroadcastCall();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
				System.Object a1;
				checkType(l,2,out a1);
				var ret=self.BroadcastCall(a1);
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
	static public int get_owner(IntPtr l) {
		try {
			FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.owner);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		try {
			FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isEmpty(IntPtr l) {
		try {
			FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isEmpty);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDispatching(IntPtr l) {
		try {
			FairyGUI.EventListener self=(FairyGUI.EventListener)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isDispatching);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.EventListener");
		addMember(l,AddCapture);
		addMember(l,RemoveCapture);
		addMember(l,Add);
		addMember(l,Remove);
		addMember(l,Set);
		addMember(l,Clear);
		addMember(l,Call);
		addMember(l,BubbleCall);
		addMember(l,BroadcastCall);
		addMember(l,"owner",get_owner,null,true);
		addMember(l,"type",get_type,null,true);
		addMember(l,"isEmpty",get_isEmpty,null,true);
		addMember(l,"isDispatching",get_isDispatching,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.EventListener));
	}
}
