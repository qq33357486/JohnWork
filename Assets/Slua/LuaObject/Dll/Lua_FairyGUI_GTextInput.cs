using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GTextInput : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GTextInput o;
			o=new FairyGUI.GTextInput();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReplaceSelection(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.ReplaceSelection(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Setup_BeforeAdd(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.Setup_BeforeAdd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Setup_AfterAdd(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.Setup_AfterAdd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_editable(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.editable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_editable(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.editable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxLength(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxLength(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.maxLength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_restrict(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.restrict);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_restrict(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.restrict=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_displayAsPassword(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.displayAsPassword);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_displayAsPassword(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.displayAsPassword=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_caretPosition(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.caretPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_caretPosition(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.caretPosition=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_promptText(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.promptText);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_promptText(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.promptText=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyboardType(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.keyboardType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyboardType(IntPtr l) {
		try {
			FairyGUI.GTextInput self=(FairyGUI.GTextInput)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.keyboardType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GTextInput");
		addMember(l,ReplaceSelection);
		addMember(l,Setup_BeforeAdd);
		addMember(l,Setup_AfterAdd);
		addMember(l,"editable",get_editable,set_editable,true);
		addMember(l,"maxLength",get_maxLength,set_maxLength,true);
		addMember(l,"restrict",get_restrict,set_restrict,true);
		addMember(l,"displayAsPassword",get_displayAsPassword,set_displayAsPassword,true);
		addMember(l,"caretPosition",get_caretPosition,set_caretPosition,true);
		addMember(l,"promptText",get_promptText,set_promptText,true);
		addMember(l,"keyboardType",get_keyboardType,set_keyboardType,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GTextInput),typeof(FairyGUI.GTextField));
	}
}
