using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_ScrollBarDisplayType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.ScrollBarDisplayType");
		addMember(l,0,"Default");
		addMember(l,1,"Visible");
		addMember(l,2,"Auto");
		addMember(l,3,"Hidden");
		LuaDLL.lua_pop(l, 1);
	}
}
