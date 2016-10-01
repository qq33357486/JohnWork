using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Timers : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Timers o;
			o=new FairyGUI.Timers();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				FairyGUI.Timers self=(FairyGUI.Timers)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				FairyGUI.TimerCallback a3;
				LuaDelegation.checkDelegate(l,4,out a3);
				self.Add(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				FairyGUI.Timers self=(FairyGUI.Timers)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				FairyGUI.TimerCallback a3;
				LuaDelegation.checkDelegate(l,4,out a3);
				System.Object a4;
				checkType(l,5,out a4);
				self.Add(a1,a2,a3,a4);
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
	static public int CallLater(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Timers self=(FairyGUI.Timers)checkSelf(l);
				FairyGUI.TimerCallback a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				self.CallLater(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.Timers self=(FairyGUI.Timers)checkSelf(l);
				FairyGUI.TimerCallback a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.CallLater(a1,a2);
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
	static public int AddUpdate(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Timers self=(FairyGUI.Timers)checkSelf(l);
				FairyGUI.TimerCallback a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				self.AddUpdate(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.Timers self=(FairyGUI.Timers)checkSelf(l);
				FairyGUI.TimerCallback a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.AddUpdate(a1,a2);
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
	static public int Exists(IntPtr l) {
		try {
			FairyGUI.Timers self=(FairyGUI.Timers)checkSelf(l);
			FairyGUI.TimerCallback a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			var ret=self.Exists(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Remove(IntPtr l) {
		try {
			FairyGUI.Timers self=(FairyGUI.Timers)checkSelf(l);
			FairyGUI.TimerCallback a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			self.Remove(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Update(IntPtr l) {
		try {
			FairyGUI.Timers self=(FairyGUI.Timers)checkSelf(l);
			self.Update();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_repeat(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Timers.repeat);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_repeat(IntPtr l) {
		try {
			System.Int32 v;
			checkType(l,2,out v);
			FairyGUI.Timers.repeat=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Timers.time);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		try {
			System.Single v;
			checkType(l,2,out v);
			FairyGUI.Timers.time=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Timers.gameObject);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gameObject(IntPtr l) {
		try {
			UnityEngine.GameObject v;
			checkType(l,2,out v);
			FairyGUI.Timers.gameObject=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inst(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Timers.inst);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Timers");
		addMember(l,Add);
		addMember(l,CallLater);
		addMember(l,AddUpdate);
		addMember(l,Exists);
		addMember(l,Remove);
		addMember(l,Update);
		addMember(l,"repeat",get_repeat,set_repeat,false);
		addMember(l,"time",get_time,set_time,false);
		addMember(l,"gameObject",get_gameObject,set_gameObject,false);
		addMember(l,"inst",get_inst,null,false);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Timers));
	}
}
