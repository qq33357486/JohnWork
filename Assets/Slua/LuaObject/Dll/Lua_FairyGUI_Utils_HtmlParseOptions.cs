using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_HtmlParseOptions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParseOptions o;
			o=new FairyGUI.Utils.HtmlParseOptions();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linkUnderline(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParseOptions self=(FairyGUI.Utils.HtmlParseOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.linkUnderline);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_linkUnderline(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParseOptions self=(FairyGUI.Utils.HtmlParseOptions)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.linkUnderline=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linkColor(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParseOptions self=(FairyGUI.Utils.HtmlParseOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.linkColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_linkColor(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParseOptions self=(FairyGUI.Utils.HtmlParseOptions)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.linkColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linkBgColor(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParseOptions self=(FairyGUI.Utils.HtmlParseOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.linkBgColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_linkBgColor(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParseOptions self=(FairyGUI.Utils.HtmlParseOptions)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.linkBgColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linkHoverBgColor(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParseOptions self=(FairyGUI.Utils.HtmlParseOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.linkHoverBgColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_linkHoverBgColor(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParseOptions self=(FairyGUI.Utils.HtmlParseOptions)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.linkHoverBgColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreWhiteSpace(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParseOptions self=(FairyGUI.Utils.HtmlParseOptions)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ignoreWhiteSpace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreWhiteSpace(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlParseOptions self=(FairyGUI.Utils.HtmlParseOptions)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.ignoreWhiteSpace=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DefaultLinkUnderline(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Utils.HtmlParseOptions.DefaultLinkUnderline);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_DefaultLinkUnderline(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			FairyGUI.Utils.HtmlParseOptions.DefaultLinkUnderline=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DefaultLinkColor(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Utils.HtmlParseOptions.DefaultLinkColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_DefaultLinkColor(IntPtr l) {
		try {
			UnityEngine.Color v;
			checkType(l,2,out v);
			FairyGUI.Utils.HtmlParseOptions.DefaultLinkColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DefaultLinkBgColor(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Utils.HtmlParseOptions.DefaultLinkBgColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_DefaultLinkBgColor(IntPtr l) {
		try {
			UnityEngine.Color v;
			checkType(l,2,out v);
			FairyGUI.Utils.HtmlParseOptions.DefaultLinkBgColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DefaultLinkHoverBgColor(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Utils.HtmlParseOptions.DefaultLinkHoverBgColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_DefaultLinkHoverBgColor(IntPtr l) {
		try {
			UnityEngine.Color v;
			checkType(l,2,out v);
			FairyGUI.Utils.HtmlParseOptions.DefaultLinkHoverBgColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Utils.HtmlParseOptions");
		addMember(l,"linkUnderline",get_linkUnderline,set_linkUnderline,true);
		addMember(l,"linkColor",get_linkColor,set_linkColor,true);
		addMember(l,"linkBgColor",get_linkBgColor,set_linkBgColor,true);
		addMember(l,"linkHoverBgColor",get_linkHoverBgColor,set_linkHoverBgColor,true);
		addMember(l,"ignoreWhiteSpace",get_ignoreWhiteSpace,set_ignoreWhiteSpace,true);
		addMember(l,"DefaultLinkUnderline",get_DefaultLinkUnderline,set_DefaultLinkUnderline,false);
		addMember(l,"DefaultLinkColor",get_DefaultLinkColor,set_DefaultLinkColor,false);
		addMember(l,"DefaultLinkBgColor",get_DefaultLinkBgColor,set_DefaultLinkBgColor,false);
		addMember(l,"DefaultLinkHoverBgColor",get_DefaultLinkHoverBgColor,set_DefaultLinkHoverBgColor,false);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Utils.HtmlParseOptions));
	}
}
