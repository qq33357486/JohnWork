using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Windows_Speech_SpeechError : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Windows.Speech.SpeechError");
		addMember(l,0,"NoError");
		addMember(l,1,"TopicLanguageNotSupported");
		addMember(l,2,"GrammarLanguageMismatch");
		addMember(l,3,"GrammarCompilationFailure");
		addMember(l,4,"AudioQualityFailure");
		addMember(l,5,"PauseLimitExceeded");
		addMember(l,6,"TimeoutExceeded");
		addMember(l,7,"NetworkFailure");
		addMember(l,8,"MicrophoneUnavailable");
		addMember(l,9,"UnknownError");
		LuaDLL.lua_pop(l, 1);
	}
}
