using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WSA_TileForegroundText : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.WSA.TileForegroundText");
		addMember(l,0,"Dark");
		addMember(l,1,"Light");
		addMember(l,-1,"Default");
		LuaDLL.lua_pop(l, 1);
	}
}
