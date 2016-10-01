using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_MobileInputAdapter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.MobileInputAdapter o;
			o=new FairyGUI.MobileInputAdapter();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInput(IntPtr l) {
		try {
			FairyGUI.MobileInputAdapter self=(FairyGUI.MobileInputAdapter)checkSelf(l);
			var ret=self.GetInput();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OpenKeyboard(IntPtr l) {
		try {
			FairyGUI.MobileInputAdapter self=(FairyGUI.MobileInputAdapter)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			System.Boolean a5;
			checkType(l,6,out a5);
			System.String a6;
			checkType(l,7,out a6);
			self.OpenKeyboard(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CloseKeyboard(IntPtr l) {
		try {
			FairyGUI.MobileInputAdapter self=(FairyGUI.MobileInputAdapter)checkSelf(l);
			self.CloseKeyboard();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyboardType(IntPtr l) {
		try {
			FairyGUI.MobileInputAdapter self=(FairyGUI.MobileInputAdapter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.keyboardType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyboardType(IntPtr l) {
		try {
			FairyGUI.MobileInputAdapter self=(FairyGUI.MobileInputAdapter)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.keyboardType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_done(IntPtr l) {
		try {
			FairyGUI.MobileInputAdapter self=(FairyGUI.MobileInputAdapter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.done);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.MobileInputAdapter");
		addMember(l,GetInput);
		addMember(l,OpenKeyboard);
		addMember(l,CloseKeyboard);
		addMember(l,"keyboardType",get_keyboardType,set_keyboardType,true);
		addMember(l,"done",get_done,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.MobileInputAdapter));
	}
}
