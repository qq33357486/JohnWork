using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GearColor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GearColor o;
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			o=new FairyGUI.GearColor(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Apply(IntPtr l) {
		try {
			FairyGUI.GearColor self=(FairyGUI.GearColor)checkSelf(l);
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
			FairyGUI.GearColor self=(FairyGUI.GearColor)checkSelf(l);
			self.UpdateState();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GearColor");
		addMember(l,Apply);
		addMember(l,UpdateState);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GearColor),typeof(FairyGUI.GearBase));
	}
}
