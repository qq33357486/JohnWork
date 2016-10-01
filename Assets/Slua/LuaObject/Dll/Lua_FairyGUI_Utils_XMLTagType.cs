using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_XMLTagType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.Utils.XMLTagType");
		addMember(l,0,"Start");
		addMember(l,1,"End");
		addMember(l,2,"Void");
		addMember(l,3,"CDATA");
		addMember(l,4,"Comment");
		addMember(l,5,"Instruction");
		LuaDLL.lua_pop(l, 1);
	}
}
