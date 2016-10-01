using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Origin180 : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.Origin180");
		addMember(l,0,"Top");
		addMember(l,1,"Bottom");
		addMember(l,2,"Left");
		addMember(l,3,"Right");
		LuaDLL.lua_pop(l, 1);
	}
}
