using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_HtmlElementType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.Utils.HtmlElementType");
		addMember(l,0,"Text");
		addMember(l,1,"Link");
		addMember(l,2,"Image");
		addMember(l,3,"Input");
		addMember(l,4,"Select");
		addMember(l,5,"Object");
		addMember(l,6,"LinkEnd");
		LuaDLL.lua_pop(l, 1);
	}
}
