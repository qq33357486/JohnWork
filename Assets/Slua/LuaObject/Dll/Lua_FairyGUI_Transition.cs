using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Transition : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Transition o;
			FairyGUI.GComponent a1;
			checkType(l,2,out a1);
			o=new FairyGUI.Transition(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
				self.Play();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
				FairyGUI.PlayCompleteCallback a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				self.Play(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				FairyGUI.PlayCompleteCallback a3;
				LuaDelegation.checkDelegate(l,4,out a3);
				self.Play(a1,a2,a3);
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
	static public int PlayReverse(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
				self.PlayReverse();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
				FairyGUI.PlayCompleteCallback a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				self.PlayReverse(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				FairyGUI.PlayCompleteCallback a3;
				LuaDelegation.checkDelegate(l,4,out a3);
				self.PlayReverse(a1,a2,a3);
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
	static public int Stop(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
				self.Stop();
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.Stop(a1,a2);
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
	static public int SetValue(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object[] a2;
			checkParams(l,3,out a2);
			self.SetValue(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetHook(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			FairyGUI.TransitionHook a2;
			LuaDelegation.checkDelegate(l,3,out a2);
			self.SetHook(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearHooks(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			self.ClearHooks();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetTarget(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			FairyGUI.GObject a2;
			checkType(l,3,out a2);
			self.SetTarget(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Copy(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			FairyGUI.Transition a1;
			checkType(l,2,out a1);
			self.Copy(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Setup(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.Setup(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoPlay(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoPlay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoPlay(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.autoPlay=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoPlayRepeat(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoPlayRepeat);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoPlayRepeat(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.autoPlayRepeat=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoPlayDelay(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoPlayDelay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoPlayDelay(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.autoPlayDelay=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playing(IntPtr l) {
		try {
			FairyGUI.Transition self=(FairyGUI.Transition)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.playing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Transition");
		addMember(l,Play);
		addMember(l,PlayReverse);
		addMember(l,Stop);
		addMember(l,SetValue);
		addMember(l,SetHook);
		addMember(l,ClearHooks);
		addMember(l,SetTarget);
		addMember(l,Copy);
		addMember(l,Setup);
		addMember(l,"autoPlay",get_autoPlay,set_autoPlay,true);
		addMember(l,"autoPlayRepeat",get_autoPlayRepeat,set_autoPlayRepeat,true);
		addMember(l,"autoPlayDelay",get_autoPlayDelay,set_autoPlayDelay,true);
		addMember(l,"name",get_name,null,true);
		addMember(l,"playing",get_playing,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Transition));
	}
}
