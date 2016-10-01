using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Windows_Speech_SpeechSystemStatus : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Windows.Speech.SpeechSystemStatus");
		addMember(l,0,"Stopped");
		addMember(l,1,"Running");
		addMember(l,2,"Failed");
		LuaDLL.lua_pop(l, 1);
	}
}
