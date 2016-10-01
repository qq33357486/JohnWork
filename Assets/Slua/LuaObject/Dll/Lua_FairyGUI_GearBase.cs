using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GearBase : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Setup(IntPtr l) {
		try {
			FairyGUI.GearBase self=(FairyGUI.GearBase)checkSelf(l);
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
	static public int Apply(IntPtr l) {
		try {
			FairyGUI.GearBase self=(FairyGUI.GearBase)checkSelf(l);
			self.Apply();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateState(IntPtr l) {
		try {
			FairyGUI.GearBase self=(FairyGUI.GearBase)checkSelf(l);
			self.UpdateState();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disableAllTweenEffect(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.GearBase.disableAllTweenEffect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disableAllTweenEffect(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			FairyGUI.GearBase.disableAllTweenEffect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tween(IntPtr l) {
		try {
			FairyGUI.GearBase self=(FairyGUI.GearBase)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tween);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tween(IntPtr l) {
		try {
			FairyGUI.GearBase self=(FairyGUI.GearBase)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.tween=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_easeType(IntPtr l) {
		try {
			FairyGUI.GearBase self=(FairyGUI.GearBase)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.easeType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_easeType(IntPtr l) {
		try {
			FairyGUI.GearBase self=(FairyGUI.GearBase)checkSelf(l);
			DG.Tweening.Ease v;
			checkEnum(l,2,out v);
			self.easeType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tweenTime(IntPtr l) {
		try {
			FairyGUI.GearBase self=(FairyGUI.GearBase)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tweenTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tweenTime(IntPtr l) {
		try {
			FairyGUI.GearBase self=(FairyGUI.GearBase)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.tweenTime=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delay(IntPtr l) {
		try {
			FairyGUI.GearBase self=(FairyGUI.GearBase)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.delay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delay(IntPtr l) {
		try {
			FairyGUI.GearBase self=(FairyGUI.GearBase)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.delay=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_controller(IntPtr l) {
		try {
			FairyGUI.GearBase self=(FairyGUI.GearBase)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.controller);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_controller(IntPtr l) {
		try {
			FairyGUI.GearBase self=(FairyGUI.GearBase)checkSelf(l);
			FairyGUI.Controller v;
			checkType(l,2,out v);
			self.controller=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GearBase");
		addMember(l,Setup);
		addMember(l,Apply);
		addMember(l,UpdateState);
		addMember(l,"disableAllTweenEffect",get_disableAllTweenEffect,set_disableAllTweenEffect,false);
		addMember(l,"tween",get_tween,set_tween,true);
		addMember(l,"easeType",get_easeType,set_easeType,true);
		addMember(l,"tweenTime",get_tweenTime,set_tweenTime,true);
		addMember(l,"delay",get_delay,set_delay,true);
		addMember(l,"controller",get_controller,set_controller,true);
		createTypeMetatable(l,null, typeof(FairyGUI.GearBase));
	}
}
