using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_PackageItemType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.PackageItemType");
		addMember(l,0,"Image");
		addMember(l,1,"MovieClip");
		addMember(l,2,"Sound");
		addMember(l,3,"Component");
		addMember(l,4,"Atlas");
		addMember(l,5,"Font");
		addMember(l,6,"Misc");
		LuaDLL.lua_pop(l, 1);
	}
}
