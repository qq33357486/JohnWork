using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_RelationType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.RelationType");
		addMember(l,0,"Left_Left");
		addMember(l,1,"Left_Center");
		addMember(l,2,"Left_Right");
		addMember(l,3,"Center_Center");
		addMember(l,4,"Right_Left");
		addMember(l,5,"Right_Center");
		addMember(l,6,"Right_Right");
		addMember(l,7,"Top_Top");
		addMember(l,8,"Top_Middle");
		addMember(l,9,"Top_Bottom");
		addMember(l,10,"Middle_Middle");
		addMember(l,11,"Bottom_Top");
		addMember(l,12,"Bottom_Middle");
		addMember(l,13,"Bottom_Bottom");
		addMember(l,14,"Width");
		addMember(l,15,"Height");
		addMember(l,16,"LeftExt_Left");
		addMember(l,17,"LeftExt_Right");
		addMember(l,18,"RightExt_Left");
		addMember(l,19,"RightExt_Right");
		addMember(l,20,"TopExt_Top");
		addMember(l,21,"TopExt_Bottom");
		addMember(l,22,"BottomExt_Top");
		addMember(l,23,"BottomExt_Bottom");
		addMember(l,24,"Size");
		LuaDLL.lua_pop(l, 1);
	}
}
