using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_HtmlParser : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParser o;
			o=new FairyGUI.Utils.HtmlParser();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Parse(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParser self=(FairyGUI.Utils.HtmlParser)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			FairyGUI.TextFormat a2;
			checkType(l,3,out a2);
			System.Collections.Generic.List<FairyGUI.Utils.HtmlElement> a3;
			checkType(l,4,out a3);
			FairyGUI.Utils.HtmlParseOptions a4;
			checkType(l,5,out a4);
			self.Parse(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inst(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Utils.HtmlParser.inst);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inst(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParser v;
			checkType(l,2,out v);
			FairyGUI.Utils.HtmlParser.inst=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Utils.HtmlParser");
		addMember(l,Parse);
		addMember(l,"inst",get_inst,set_inst,false);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Utils.HtmlParser));
	}
}
