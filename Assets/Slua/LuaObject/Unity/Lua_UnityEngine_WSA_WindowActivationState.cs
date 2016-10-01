using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WSA_WindowActivationState : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.WSA.WindowActivationState");
		addMember(l,0,"CodeActivated");
		addMember(l,1,"Deactivated");
		addMember(l,2,"PointerActivated");
		LuaDLL.lua_pop(l, 1);
	}
}
