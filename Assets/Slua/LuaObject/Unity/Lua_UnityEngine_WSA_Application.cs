using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WSA_Application : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.WSA.Application o;
			o=new UnityEngine.WSA.Application();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int InvokeOnAppThread_s(IntPtr l) {
		try {
			UnityEngine.WSA.AppCallbackItem a1;
			LuaDelegation.checkDelegate(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			UnityEngine.WSA.Application.InvokeOnAppThread(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int InvokeOnUIThread_s(IntPtr l) {
		try {
			UnityEngine.WSA.AppCallbackItem a1;
			LuaDelegation.checkDelegate(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			UnityEngine.WSA.Application.InvokeOnUIThread(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RunningOnAppThread_s(IntPtr l) {
		try {
			var ret=UnityEngine.WSA.Application.RunningOnAppThread();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RunningOnUIThread_s(IntPtr l) {
		try {
			var ret=UnityEngine.WSA.Application.RunningOnUIThread();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_arguments(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.WSA.Application.arguments);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_advertisingIdentifier(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.WSA.Application.advertisingIdentifier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WSA.Application");
		addMember(l,InvokeOnAppThread_s);
		addMember(l,InvokeOnUIThread_s);
		addMember(l,RunningOnAppThread_s);
		addMember(l,RunningOnUIThread_s);
		addMember(l,"arguments",get_arguments,null,false);
		addMember(l,"advertisingIdentifier",get_advertisingIdentifier,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.WSA.Application));
	}
}
