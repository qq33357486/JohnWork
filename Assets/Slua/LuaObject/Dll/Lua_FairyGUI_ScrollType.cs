using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_ScrollType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.ScrollType");
		addMember(l,0,"Horizontal");
		addMember(l,1,"Vertical");
		addMember(l,2,"Both");
		LuaDLL.lua_pop(l, 1);
	}
}
