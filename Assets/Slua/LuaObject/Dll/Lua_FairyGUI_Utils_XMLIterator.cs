using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_XMLIterator : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Utils.XMLIterator o;
			o=new FairyGUI.Utils.XMLIterator();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Begin_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			FairyGUI.Utils.XMLIterator.Begin(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int NextTag_s(IntPtr l) {
		try {
			var ret=FairyGUI.Utils.XMLIterator.NextTag();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTagSource_s(IntPtr l) {
		try {
			var ret=FairyGUI.Utils.XMLIterator.GetTagSource();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRawText_s(IntPtr l) {
		try {
			System.Boolean a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.Utils.XMLIterator.GetRawText(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetText_s(IntPtr l) {
		try {
			System.Boolean a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.Utils.XMLIterator.GetText(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HasAttribute_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.Utils.XMLIterator.HasAttribute(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAttribute_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				var ret=FairyGUI.Utils.XMLIterator.GetAttribute(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				var ret=FairyGUI.Utils.XMLIterator.GetAttribute(a1,a2);
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
	static public int GetAttributeInt_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				var ret=FairyGUI.Utils.XMLIterator.GetAttributeInt(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				var ret=FairyGUI.Utils.XMLIterator.GetAttributeInt(a1,a2);
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
	static public int GetAttributeFloat_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				var ret=FairyGUI.Utils.XMLIterator.GetAttributeFloat(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=FairyGUI.Utils.XMLIterator.GetAttributeFloat(a1,a2);
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
	static public int GetAttributeBool_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				var ret=FairyGUI.Utils.XMLIterator.GetAttributeBool(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				var ret=FairyGUI.Utils.XMLIterator.GetAttributeBool(a1,a2);
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
	static public int GetAttributes_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(System.Collections.Hashtable))){
				System.Collections.Hashtable a1;
				checkType(l,1,out a1);
				var ret=FairyGUI.Utils.XMLIterator.GetAttributes(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(Dictionary<System.String,System.String>))){
				System.Collections.Generic.Dictionary<System.String,System.String> a1;
				checkType(l,1,out a1);
				var ret=FairyGUI.Utils.XMLIterator.GetAttributes(a1);
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
	static public int get_tagName(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Utils.XMLIterator.tagName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tagName(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.Utils.XMLIterator.tagName=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tagType(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)FairyGUI.Utils.XMLIterator.tagType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tagType(IntPtr l) {
		try {
			FairyGUI.Utils.XMLTagType v;
			checkEnum(l,2,out v);
			FairyGUI.Utils.XMLIterator.tagType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastTagName(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Utils.XMLIterator.lastTagName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lastTagName(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.Utils.XMLIterator.lastTagName=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Utils.XMLIterator");
		addMember(l,Begin_s);
		addMember(l,NextTag_s);
		addMember(l,GetTagSource_s);
		addMember(l,GetRawText_s);
		addMember(l,GetText_s);
		addMember(l,HasAttribute_s);
		addMember(l,GetAttribute_s);
		addMember(l,GetAttributeInt_s);
		addMember(l,GetAttributeFloat_s);
		addMember(l,GetAttributeBool_s);
		addMember(l,GetAttributes_s);
		addMember(l,"tagName",get_tagName,set_tagName,false);
		addMember(l,"tagType",get_tagType,set_tagType,false);
		addMember(l,"lastTagName",get_lastTagName,set_lastTagName,false);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Utils.XMLIterator));
	}
}
