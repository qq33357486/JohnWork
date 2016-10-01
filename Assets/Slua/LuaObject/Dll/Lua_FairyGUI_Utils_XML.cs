using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_XML : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Utils.XML o;
			System.String a1;
			checkType(l,2,out a1);
			o=new FairyGUI.Utils.XML(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HasAttribute(IntPtr l) {
		try {
			FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasAttribute(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAttribute(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetAttribute(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				var ret=self.GetAttribute(a1,a2);
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
	static public int GetAttributeInt(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetAttributeInt(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=self.GetAttributeInt(a1,a2);
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
	static public int GetAttributeFloat(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetAttributeFloat(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				var ret=self.GetAttributeFloat(a1,a2);
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
	static public int GetAttributeBool(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetAttributeBool(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.GetAttributeBool(a1,a2);
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
	static public int GetAttributeArray(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetAttributeArray(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Char a2;
				checkType(l,3,out a2);
				var ret=self.GetAttributeArray(a1,a2);
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
	static public int GetAttributeColor(IntPtr l) {
		try {
			FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			var ret=self.GetAttributeColor(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAttributeVector(IntPtr l) {
		try {
			FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetAttributeVector(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetAttribute(IntPtr l) {
		try {
			FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.SetAttribute(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNode(IntPtr l) {
		try {
			FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetNode(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Elements(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
				var ret=self.Elements();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.Elements(a1);
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
	static public int get_name(IntPtr l) {
		try {
			FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		try {
			FairyGUI.Utils.XML self=(FairyGUI.Utils.XML)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.text);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Utils.XML");
		addMember(l,HasAttribute);
		addMember(l,GetAttribute);
		addMember(l,GetAttributeInt);
		addMember(l,GetAttributeFloat);
		addMember(l,GetAttributeBool);
		addMember(l,GetAttributeArray);
		addMember(l,GetAttributeColor);
		addMember(l,GetAttributeVector);
		addMember(l,SetAttribute);
		addMember(l,GetNode);
		addMember(l,Elements);
		addMember(l,"name",get_name,null,true);
		addMember(l,"text",get_text,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Utils.XML));
	}
}
