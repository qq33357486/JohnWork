using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_HtmlPageContext : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlPageContext o;
			o=new FairyGUI.Utils.HtmlPageContext();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateObject(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlPageContext self=(FairyGUI.Utils.HtmlPageContext)checkSelf(l);
			FairyGUI.RichTextField a1;
			checkType(l,2,out a1);
			FairyGUI.Utils.HtmlElement a2;
			checkType(l,3,out a2);
			var ret=self.CreateObject(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FreeObject(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlPageContext self=(FairyGUI.Utils.HtmlPageContext)checkSelf(l);
			FairyGUI.Utils.IHtmlObject a1;
			checkType(l,2,out a1);
			self.FreeObject(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetImageTexture(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlPageContext self=(FairyGUI.Utils.HtmlPageContext)checkSelf(l);
			FairyGUI.Utils.HtmlImage a1;
			checkType(l,2,out a1);
			var ret=self.GetImageTexture(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FreeImageTexture(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlPageContext self=(FairyGUI.Utils.HtmlPageContext)checkSelf(l);
			FairyGUI.Utils.HtmlImage a1;
			checkType(l,2,out a1);
			FairyGUI.NTexture a2;
			checkType(l,3,out a2);
			self.FreeImageTexture(a1,a2);
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
			pushValue(l,FairyGUI.Utils.HtmlPageContext.inst);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inst(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlPageContext v;
			checkType(l,2,out v);
			FairyGUI.Utils.HtmlPageContext.inst=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Utils.HtmlPageContext");
		addMember(l,CreateObject);
		addMember(l,FreeObject);
		addMember(l,GetImageTexture);
		addMember(l,FreeImageTexture);
		addMember(l,"inst",get_inst,set_inst,false);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Utils.HtmlPageContext));
	}
}
