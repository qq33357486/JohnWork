using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GObjectPool : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GObjectPool o;
			o=new FairyGUI.GObjectPool();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try {
			FairyGUI.GObjectPool self=(FairyGUI.GObjectPool)checkSelf(l);
			self.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetObject(IntPtr l) {
		try {
			FairyGUI.GObjectPool self=(FairyGUI.GObjectPool)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetObject(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReturnObject(IntPtr l) {
		try {
			FairyGUI.GObjectPool self=(FairyGUI.GObjectPool)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			self.ReturnObject(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_initCallback(IntPtr l) {
		try {
			FairyGUI.GObjectPool self=(FairyGUI.GObjectPool)checkSelf(l);
			FairyGUI.GObjectPool.InitCallbackDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.initCallback=v;
			else if(op==1) self.initCallback+=v;
			else if(op==2) self.initCallback-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_count(IntPtr l) {
		try {
			FairyGUI.GObjectPool self=(FairyGUI.GObjectPool)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.count);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GObjectPool");
		addMember(l,Clear);
		addMember(l,GetObject);
		addMember(l,ReturnObject);
		addMember(l,"initCallback",null,set_initCallback,true);
		addMember(l,"count",get_count,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GObjectPool));
	}
}
