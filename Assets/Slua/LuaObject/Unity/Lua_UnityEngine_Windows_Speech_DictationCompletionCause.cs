using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Windows_Speech_DictationCompletionCause : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Windows.Speech.DictationCompletionCause");
		addMember(l,0,"Complete");
		addMember(l,1,"AudioQualityFailure");
		addMember(l,2,"Canceled");
		addMember(l,3,"TimeoutExceeded");
		addMember(l,4,"PauseLimitExceeded");
		addMember(l,5,"NetworkFailure");
		addMember(l,6,"MicrophoneUnavailable");
		addMember(l,7,"UnknownError");
		LuaDLL.lua_pop(l, 1);
	}
}
