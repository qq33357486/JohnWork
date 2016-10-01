using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Windows_Speech_ConfidenceLevel : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Windows.Speech.ConfidenceLevel");
		addMember(l,0,"High");
		addMember(l,1,"Medium");
		addMember(l,2,"Low");
		addMember(l,3,"Rejected");
		LuaDLL.lua_pop(l, 1);
	}
}
