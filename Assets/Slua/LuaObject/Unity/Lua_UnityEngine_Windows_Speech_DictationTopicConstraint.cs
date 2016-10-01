using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Windows_Speech_DictationTopicConstraint : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Windows.Speech.DictationTopicConstraint");
		addMember(l,0,"WebSearch");
		addMember(l,1,"Form");
		addMember(l,2,"Dictation");
		LuaDLL.lua_pop(l, 1);
	}
}
