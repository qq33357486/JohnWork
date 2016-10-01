using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_FitScreen : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.FitScreen");
		addMember(l,0,"None");
		addMember(l,1,"FitSize");
		addMember(l,2,"FitWidthAndSetMiddle");
		addMember(l,3,"FitHeightAndSetCenter");
		LuaDLL.lua_pop(l, 1);
	}
}
