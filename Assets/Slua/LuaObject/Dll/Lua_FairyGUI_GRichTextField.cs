using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GRichTextField : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GRichTextField o;
			o=new FairyGUI.GRichTextField();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetHtmlObject(IntPtr l) {
		try {
			FairyGUI.GRichTextField self=(FairyGUI.GRichTextField)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetHtmlObject(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetHtmlObjectAt(IntPtr l) {
		try {
			FairyGUI.GRichTextField self=(FairyGUI.GRichTextField)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetHtmlObjectAt(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_htmlObjectCount(IntPtr l) {
		try {
			FairyGUI.GRichTextField self=(FairyGUI.GRichTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.htmlObjectCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GRichTextField");
		addMember(l,GetHtmlObject);
		addMember(l,GetHtmlObjectAt);
		addMember(l,"htmlObjectCount",get_htmlObjectCount,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GRichTextField),typeof(FairyGUI.GTextField));
	}
}
