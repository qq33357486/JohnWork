using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_HitTestMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.HitTestMode");
		addMember(l,0,"Default");
		addMember(l,1,"Raycast");
		LuaDLL.lua_pop(l, 1);
	}
}
