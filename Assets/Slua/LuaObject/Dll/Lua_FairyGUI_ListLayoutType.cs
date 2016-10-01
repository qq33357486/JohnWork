using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_ListLayoutType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.ListLayoutType");
		addMember(l,0,"SingleColumn");
		addMember(l,1,"SingleRow");
		addMember(l,2,"FlowHorizontal");
		addMember(l,3,"FlowVertical");
		LuaDLL.lua_pop(l, 1);
	}
}
