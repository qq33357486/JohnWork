using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_BlendModeUtils : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.BlendModeUtils o;
			o=new FairyGUI.BlendModeUtils();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Apply_s(IntPtr l) {
		try {
			UnityEngine.Material a1;
			checkType(l,1,out a1);
			FairyGUI.BlendMode a2;
			checkEnum(l,2,out a2);
			FairyGUI.BlendModeUtils.Apply(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Override_s(IntPtr l) {
		try {
			FairyGUI.BlendMode a1;
			checkEnum(l,1,out a1);
			UnityEngine.Rendering.BlendMode a2;
			checkEnum(l,2,out a2);
			UnityEngine.Rendering.BlendMode a3;
			checkEnum(l,3,out a3);
			FairyGUI.BlendModeUtils.Override(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.BlendModeUtils");
		addMember(l,Apply_s);
		addMember(l,Override_s);
		createTypeMetatable(l,constructor, typeof(FairyGUI.BlendModeUtils));
	}
}
