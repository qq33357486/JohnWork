using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_BlurFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.BlurFilter o;
			o=new FairyGUI.BlurFilter();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispose(IntPtr l) {
		try {
			FairyGUI.BlurFilter self=(FairyGUI.BlurFilter)checkSelf(l);
			self.Dispose();
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
			FairyGUI.BlurFilter self=(FairyGUI.BlurFilter)checkSelf(l);
			self.Update();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blurSize(IntPtr l) {
		try {
			FairyGUI.BlurFilter self=(FairyGUI.BlurFilter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.blurSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_blurSize(IntPtr l) {
		try {
			FairyGUI.BlurFilter self=(FairyGUI.BlurFilter)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.blurSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		try {
			FairyGUI.BlurFilter self=(FairyGUI.BlurFilter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.target);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		try {
			FairyGUI.BlurFilter self=(FairyGUI.BlurFilter)checkSelf(l);
			FairyGUI.DisplayObject v;
			checkType(l,2,out v);
			self.target=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.BlurFilter");
		addMember(l,Dispose);
		addMember(l,Update);
		addMember(l,"blurSize",get_blurSize,set_blurSize,true);
		addMember(l,"target",get_target,set_target,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.BlurFilter));
	}
}
