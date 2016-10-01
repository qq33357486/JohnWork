using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_OverflowType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.OverflowType");
		addMember(l,0,"Visible");
		addMember(l,1,"Hidden");
		addMember(l,2,"Scroll");
		LuaDLL.lua_pop(l, 1);
	}
}
