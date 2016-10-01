using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_XMLUtils : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Utils.XMLUtils o;
			o=new FairyGUI.Utils.XMLUtils();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DecodeString_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.Utils.XMLUtils.DecodeString(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EncodeString_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.Utils.XMLUtils.EncodeString(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Utils.XMLUtils");
		addMember(l,DecodeString_s);
		addMember(l,EncodeString_s);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Utils.XMLUtils));
	}
}
