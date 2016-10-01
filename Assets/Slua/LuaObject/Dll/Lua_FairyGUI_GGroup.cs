using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GGroup o;
			o=new FairyGUI.GGroup();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateBounds(IntPtr l) {
		try {
			FairyGUI.GGroup self=(FairyGUI.GGroup)checkSelf(l);
			self.UpdateBounds();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GGroup");
		addMember(l,UpdateBounds);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GGroup),typeof(FairyGUI.GObject));
	}
}
