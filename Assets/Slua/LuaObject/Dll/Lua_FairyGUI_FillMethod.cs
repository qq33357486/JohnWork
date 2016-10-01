using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_FillMethod : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.FillMethod");
		addMember(l,0,"None");
		addMember(l,1,"Horizontal");
		addMember(l,2,"Vertical");
		addMember(l,3,"Radial90");
		addMember(l,4,"Radial180");
		addMember(l,5,"Radial360");
		LuaDLL.lua_pop(l, 1);
	}
}
