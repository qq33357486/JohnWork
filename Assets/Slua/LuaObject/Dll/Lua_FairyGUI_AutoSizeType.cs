using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_AutoSizeType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.AutoSizeType");
		addMember(l,0,"None");
		addMember(l,1,"Both");
		addMember(l,2,"Height");
		LuaDLL.lua_pop(l, 1);
	}
}
