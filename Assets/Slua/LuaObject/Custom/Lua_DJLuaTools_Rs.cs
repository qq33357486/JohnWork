using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_DJLuaTools_Rs : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			DJLuaTools.Rs o;
			o=new DJLuaTools.Rs();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadText_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=DJLuaTools.Rs.LoadText(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"DJLuaTools.Rs");
		addMember(l,LoadText_s);
		createTypeMetatable(l,constructor, typeof(DJLuaTools.Rs));
	}
}
