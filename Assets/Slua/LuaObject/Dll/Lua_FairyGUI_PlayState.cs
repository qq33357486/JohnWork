using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_PlayState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.PlayState o;
			o=new FairyGUI.PlayState();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Update(IntPtr l) {
		try {
			FairyGUI.PlayState self=(FairyGUI.PlayState)checkSelf(l);
			FairyGUI.MovieClip a1;
			checkType(l,2,out a1);
			FairyGUI.UpdateContext a2;
			checkType(l,3,out a2);
			self.Update(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Rewind(IntPtr l) {
		try {
			FairyGUI.PlayState self=(FairyGUI.PlayState)checkSelf(l);
			self.Rewind();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Reset(IntPtr l) {
		try {
			FairyGUI.PlayState self=(FairyGUI.PlayState)checkSelf(l);
			self.Reset();
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
			FairyGUI.PlayState self=(FairyGUI.PlayState)checkSelf(l);
			FairyGUI.PlayState a1;
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
	static public int get_ignoreTimeScale(IntPtr l) {
		try {
			FairyGUI.PlayState self=(FairyGUI.PlayState)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ignoreTimeScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreTimeScale(IntPtr l) {
		try {
			FairyGUI.PlayState self=(FairyGUI.PlayState)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.ignoreTimeScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reachEnding(IntPtr l) {
		try {
			FairyGUI.PlayState self=(FairyGUI.PlayState)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.reachEnding);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reversed(IntPtr l) {
		try {
			FairyGUI.PlayState self=(FairyGUI.PlayState)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.reversed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_repeatedCount(IntPtr l) {
		try {
			FairyGUI.PlayState self=(FairyGUI.PlayState)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.repeatedCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currrentFrame(IntPtr l) {
		try {
			FairyGUI.PlayState self=(FairyGUI.PlayState)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currrentFrame);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_currrentFrame(IntPtr l) {
		try {
			FairyGUI.PlayState self=(FairyGUI.PlayState)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.currrentFrame=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.PlayState");
		addMember(l,Update);
		addMember(l,Rewind);
		addMember(l,Reset);
		addMember(l,Copy);
		addMember(l,"ignoreTimeScale",get_ignoreTimeScale,set_ignoreTimeScale,true);
		addMember(l,"reachEnding",get_reachEnding,null,true);
		addMember(l,"reversed",get_reversed,null,true);
		addMember(l,"repeatedCount",get_repeatedCount,null,true);
		addMember(l,"currrentFrame",get_currrentFrame,set_currrentFrame,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.PlayState));
	}
}
