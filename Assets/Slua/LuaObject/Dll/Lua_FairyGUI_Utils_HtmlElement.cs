using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_HtmlElement : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement o;
			o=new FairyGUI.Utils.HtmlElement();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Get(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Get(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Set(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			self.Set(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetString(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetString(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				var ret=self.GetString(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInt(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetInt(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=self.GetInt(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetFloat(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetFloat(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				var ret=self.GetFloat(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBool(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetBool(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.GetBool(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetColor(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			var ret=self.GetColor(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FetchAttributes(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			self.FetchAttributes();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetElement_s(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElementType a1;
			checkEnum(l,1,out a1);
			var ret=FairyGUI.Utils.HtmlElement.GetElement(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReturnElement_s(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement a1;
			checkType(l,1,out a1);
			FairyGUI.Utils.HtmlElement.ReturnElement(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReturnElements_s(IntPtr l) {
		try {
			System.Collections.Generic.List<FairyGUI.Utils.HtmlElement> a1;
			checkType(l,1,out a1);
			FairyGUI.Utils.HtmlElement.ReturnElements(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			FairyGUI.Utils.HtmlElementType v;
			checkEnum(l,2,out v);
			self.type=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.name=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.text);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.text=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_format(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.format);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_format(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			FairyGUI.TextFormat v;
			checkType(l,2,out v);
			self.format=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_htmlObject(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.htmlObject);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_htmlObject(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			FairyGUI.Utils.IHtmlObject v;
			checkType(l,2,out v);
			self.htmlObject=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_space(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.space);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_space(IntPtr l) {
		try {
			FairyGUI.Utils.HtmlElement self=(FairyGUI.Utils.HtmlElement)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.space=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Utils.HtmlElement");
		addMember(l,Get);
		addMember(l,Set);
		addMember(l,GetString);
		addMember(l,GetInt);
		addMember(l,GetFloat);
		addMember(l,GetBool);
		addMember(l,GetColor);
		addMember(l,FetchAttributes);
		addMember(l,GetElement_s);
		addMember(l,ReturnElement_s);
		addMember(l,ReturnElements_s);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"format",get_format,set_format,true);
		addMember(l,"htmlObject",get_htmlObject,set_htmlObject,true);
		addMember(l,"space",get_space,set_space,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Utils.HtmlElement));
	}
}
