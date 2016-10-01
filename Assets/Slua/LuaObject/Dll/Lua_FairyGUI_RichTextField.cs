using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_RichTextField : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			FairyGUI.RichTextField o;
			if(argc==1){
				o=new FairyGUI.RichTextField();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				FairyGUI.TextField a1;
				checkType(l,2,out a1);
				o=new FairyGUI.RichTextField(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetHtmlObject(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
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
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
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
	static public int Update(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			FairyGUI.UpdateContext a1;
			checkType(l,2,out a1);
			self.Update(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onFocusIn(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onFocusIn);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onFocusOut(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onFocusOut);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onChanged(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onChanged);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_htmlPageContext(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.htmlPageContext);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_htmlPageContext(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			FairyGUI.Utils.IHtmlPageContext v;
			checkType(l,2,out v);
			self.htmlPageContext=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_htmlParseOptions(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.htmlParseOptions);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_emojies(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.emojies);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_emojies(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			Dictionary<System.UInt32,FairyGUI.Emoji> v;
			checkType(l,2,out v);
			self.emojies=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textField(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textField);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
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
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			string v;
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
	static public int get_htmlText(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.htmlText);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_htmlText(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.htmlText=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textFormat(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textFormat);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textFormat(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			FairyGUI.TextFormat v;
			checkType(l,2,out v);
			self.textFormat=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_htmlObjectCount(IntPtr l) {
		try {
			FairyGUI.RichTextField self=(FairyGUI.RichTextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.htmlObjectCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.RichTextField");
		addMember(l,GetHtmlObject);
		addMember(l,GetHtmlObjectAt);
		addMember(l,Update);
		addMember(l,"onFocusIn",get_onFocusIn,null,true);
		addMember(l,"onFocusOut",get_onFocusOut,null,true);
		addMember(l,"onChanged",get_onChanged,null,true);
		addMember(l,"htmlPageContext",get_htmlPageContext,set_htmlPageContext,true);
		addMember(l,"htmlParseOptions",get_htmlParseOptions,null,true);
		addMember(l,"emojies",get_emojies,set_emojies,true);
		addMember(l,"textField",get_textField,null,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"htmlText",get_htmlText,set_htmlText,true);
		addMember(l,"textFormat",get_textFormat,set_textFormat,true);
		addMember(l,"htmlObjectCount",get_htmlObjectCount,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.RichTextField),typeof(FairyGUI.Container));
	}
}
