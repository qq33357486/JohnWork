using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_BlendMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.BlendMode");
		addMember(l,0,"Normal");
		addMember(l,1,"None");
		addMember(l,2,"Add");
		addMember(l,3,"Multiply");
		addMember(l,4,"Screen");
		addMember(l,5,"Erase");
		addMember(l,6,"Mask");
		addMember(l,7,"Below");
		addMember(l,8,"Custom1");
		addMember(l,9,"Custom2");
		addMember(l,10,"Custom3");
		LuaDLL.lua_pop(l, 1);
	}
}
