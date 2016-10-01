using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_FillType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.FillType");
		addMember(l,0,"None");
		addMember(l,1,"Scale");
		addMember(l,2,"ScaleFree");
		LuaDLL.lua_pop(l, 1);
	}
}
