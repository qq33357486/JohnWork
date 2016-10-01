using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_ProgressTitleType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.ProgressTitleType");
		addMember(l,0,"Percent");
		addMember(l,1,"ValueAndMax");
		addMember(l,2,"Value");
		addMember(l,3,"Max");
		LuaDLL.lua_pop(l, 1);
	}
}
