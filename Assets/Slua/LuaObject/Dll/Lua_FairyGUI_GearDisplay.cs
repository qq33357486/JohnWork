using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GearDisplay : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GearDisplay o;
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			o=new FairyGUI.GearDisplay(a1);
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
			FairyGUI.GearDisplay self=(FairyGUI.GearDisplay)checkSelf(l);
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
			FairyGUI.GearDisplay self=(FairyGUI.GearDisplay)checkSelf(l);
			self.UpdateState();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pages(IntPtr l) {
		try {
			FairyGUI.GearDisplay self=(FairyGUI.GearDisplay)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pages);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GearDisplay");
		addMember(l,Apply);
		addMember(l,UpdateState);
		addMember(l,"pages",get_pages,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GearDisplay),typeof(FairyGUI.GearBase));
	}
}
