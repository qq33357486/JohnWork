using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_HtmlImage : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlImage o;
			o=new FairyGUI.Utils.HtmlImage();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Create(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlImage self=(FairyGUI.Utils.HtmlImage)checkSelf(l);
			FairyGUI.RichTextField a1;
			checkType(l,2,out a1);
			FairyGUI.Utils.HtmlElement a2;
			checkType(l,3,out a2);
			self.Create(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPosition(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlImage self=(FairyGUI.Utils.HtmlImage)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetPosition(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlImage self=(FairyGUI.Utils.HtmlImage)checkSelf(l);
			self.Add();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Remove(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlImage self=(FairyGUI.Utils.HtmlImage)checkSelf(l);
			self.Remove();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispose(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlImage self=(FairyGUI.Utils.HtmlImage)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loader(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlImage self=(FairyGUI.Utils.HtmlImage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.loader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_element(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlImage self=(FairyGUI.Utils.HtmlImage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.element);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlImage self=(FairyGUI.Utils.HtmlImage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlImage self=(FairyGUI.Utils.HtmlImage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Utils.HtmlImage");
		addMember(l,Create);
		addMember(l,SetPosition);
		addMember(l,Add);
		addMember(l,Remove);
		addMember(l,Dispose);
		addMember(l,"loader",get_loader,null,true);
		addMember(l,"element",get_element,null,true);
		addMember(l,"width",get_width,null,true);
		addMember(l,"height",get_height,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Utils.HtmlImage));
	}
}
