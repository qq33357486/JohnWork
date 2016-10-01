using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_HtmlInput : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlInput o;
			o=new FairyGUI.Utils.HtmlInput();
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
			FairyGUI.Utils.HtmlInput self=(FairyGUI.Utils.HtmlInput)checkSelf(l);
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
			FairyGUI.Utils.HtmlInput self=(FairyGUI.Utils.HtmlInput)checkSelf(l);
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
			FairyGUI.Utils.HtmlInput self=(FairyGUI.Utils.HtmlInput)checkSelf(l);
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
			FairyGUI.Utils.HtmlInput self=(FairyGUI.Utils.HtmlInput)checkSelf(l);
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
			FairyGUI.Utils.HtmlInput self=(FairyGUI.Utils.HtmlInput)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultBorderSize(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Utils.HtmlInput.defaultBorderSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultBorderSize(IntPtr l) {
		try {
			System.Int32 v;
			checkType(l,2,out v);
			FairyGUI.Utils.HtmlInput.defaultBorderSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultBorderColor(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Utils.HtmlInput.defaultBorderColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultBorderColor(IntPtr l) {
		try {
			UnityEngine.Color v;
			checkType(l,2,out v);
			FairyGUI.Utils.HtmlInput.defaultBorderColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textInput(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlInput self=(FairyGUI.Utils.HtmlInput)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textInput);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_element(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlInput self=(FairyGUI.Utils.HtmlInput)checkSelf(l);
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
			FairyGUI.Utils.HtmlInput self=(FairyGUI.Utils.HtmlInput)checkSelf(l);
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
			FairyGUI.Utils.HtmlInput self=(FairyGUI.Utils.HtmlInput)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Utils.HtmlInput");
		addMember(l,Create);
		addMember(l,SetPosition);
		addMember(l,Add);
		addMember(l,Remove);
		addMember(l,Dispose);
		addMember(l,"defaultBorderSize",get_defaultBorderSize,set_defaultBorderSize,false);
		addMember(l,"defaultBorderColor",get_defaultBorderColor,set_defaultBorderColor,false);
		addMember(l,"textInput",get_textInput,null,true);
		addMember(l,"element",get_element,null,true);
		addMember(l,"width",get_width,null,true);
		addMember(l,"height",get_height,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Utils.HtmlInput));
	}
}
