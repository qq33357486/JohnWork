using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_ListSelectionMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.ListSelectionMode");
		addMember(l,0,"Single");
		addMember(l,1,"Multiple");
		addMember(l,2,"Multiple_SingleClick");
		addMember(l,3,"None");
		LuaDLL.lua_pop(l, 1);
	}
}
