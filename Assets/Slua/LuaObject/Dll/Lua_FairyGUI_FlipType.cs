using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_FlipType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.FlipType");
		addMember(l,0,"None");
		addMember(l,1,"Horizontal");
		addMember(l,2,"Vertical");
		addMember(l,3,"Both");
		LuaDLL.lua_pop(l, 1);
	}
}
