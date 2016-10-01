using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_ByteBuffer_Endian : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.Utils.ByteBuffer.Endian");
		addMember(l,0,"BIG_ENDIAN");
		addMember(l,1,"LITTLE_ENDIAN");
		LuaDLL.lua_pop(l, 1);
	}
}
