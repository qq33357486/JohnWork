using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_ChildrenRenderOrder : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.ChildrenRenderOrder");
		addMember(l,0,"Ascent");
		addMember(l,1,"Descent");
		addMember(l,2,"Arch");
		LuaDLL.lua_pop(l, 1);
	}
}
