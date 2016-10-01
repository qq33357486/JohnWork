using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_AlignType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.AlignType");
		addMember(l,0,"Left");
		addMember(l,1,"Center");
		addMember(l,2,"Right");
		LuaDLL.lua_pop(l, 1);
	}
}
