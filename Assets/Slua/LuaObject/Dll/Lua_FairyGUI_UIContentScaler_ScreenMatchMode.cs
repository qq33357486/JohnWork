using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_UIContentScaler_ScreenMatchMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.UIContentScaler.ScreenMatchMode");
		addMember(l,0,"MatchWidthOrHeight");
		addMember(l,1,"MatchWidth");
		addMember(l,2,"MatchHeight");
		LuaDLL.lua_pop(l, 1);
	}
}
