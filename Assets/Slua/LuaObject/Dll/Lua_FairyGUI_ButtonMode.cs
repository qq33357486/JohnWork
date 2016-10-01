using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_ButtonMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.ButtonMode");
		addMember(l,0,"Common");
		addMember(l,1,"Check");
		addMember(l,2,"Radio");
		LuaDLL.lua_pop(l, 1);
	}
}
