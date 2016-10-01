using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_UIContentScaler_ScaleMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.UIContentScaler.ScaleMode");
		addMember(l,0,"ConstantPixelSize");
		addMember(l,1,"ScaleWithScreenSize");
		LuaDLL.lua_pop(l, 1);
	}
}
