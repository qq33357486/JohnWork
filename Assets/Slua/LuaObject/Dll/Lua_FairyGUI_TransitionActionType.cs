using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_TransitionActionType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.TransitionActionType");
		addMember(l,0,"XY");
		addMember(l,1,"Size");
		addMember(l,2,"Scale");
		addMember(l,3,"Pivot");
		addMember(l,4,"Alpha");
		addMember(l,5,"Rotation");
		addMember(l,6,"Color");
		addMember(l,7,"Animation");
		addMember(l,8,"Visible");
		addMember(l,9,"Controller");
		addMember(l,10,"Sound");
		addMember(l,11,"Transition");
		addMember(l,12,"Shake");
		addMember(l,13,"Unknown");
		LuaDLL.lua_pop(l, 1);
	}
}
