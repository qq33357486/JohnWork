using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_OriginVertical : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.OriginVertical");
		addMember(l,0,"Top");
		addMember(l,1,"Bottom");
		LuaDLL.lua_pop(l, 1);
	}
}
