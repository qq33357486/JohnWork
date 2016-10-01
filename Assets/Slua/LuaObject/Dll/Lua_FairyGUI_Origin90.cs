using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Origin90 : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.Origin90");
		addMember(l,0,"TopLeft");
		addMember(l,1,"TopRight");
		addMember(l,2,"BottomLeft");
		addMember(l,3,"BottomRight");
		LuaDLL.lua_pop(l, 1);
	}
}
