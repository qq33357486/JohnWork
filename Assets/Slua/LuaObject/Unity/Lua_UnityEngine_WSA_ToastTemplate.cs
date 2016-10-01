using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WSA_ToastTemplate : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.WSA.ToastTemplate");
		addMember(l,0,"ToastImageAndText01");
		addMember(l,1,"ToastImageAndText02");
		addMember(l,2,"ToastImageAndText03");
		addMember(l,3,"ToastImageAndText04");
		addMember(l,4,"ToastText01");
		addMember(l,5,"ToastText02");
		addMember(l,6,"ToastText03");
		addMember(l,7,"ToastText04");
		LuaDLL.lua_pop(l, 1);
	}
}
