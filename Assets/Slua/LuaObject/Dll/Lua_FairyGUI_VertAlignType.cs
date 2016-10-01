using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_VertAlignType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.VertAlignType");
		addMember(l,0,"Top");
		addMember(l,1,"Middle");
		addMember(l,2,"Bottom");
		LuaDLL.lua_pop(l, 1);
	}
}
