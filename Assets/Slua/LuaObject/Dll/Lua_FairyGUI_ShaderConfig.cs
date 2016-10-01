using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_ShaderConfig : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.ShaderConfig o;
			o=new FairyGUI.ShaderConfig();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetShader_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.ShaderConfig.GetShader(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_Get(IntPtr l) {
		try {
			FairyGUI.ShaderConfig.GetFunction v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) FairyGUI.ShaderConfig.Get=v;
			else if(op==1) FairyGUI.ShaderConfig.Get+=v;
			else if(op==2) FairyGUI.ShaderConfig.Get-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_imageShader(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.ShaderConfig.imageShader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_imageShader(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.ShaderConfig.imageShader=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textShader(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.ShaderConfig.textShader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textShader(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.ShaderConfig.textShader=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textBrighterShader(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.ShaderConfig.textBrighterShader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textBrighterShader(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.ShaderConfig.textBrighterShader=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bmFontShader(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.ShaderConfig.bmFontShader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bmFontShader(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.ShaderConfig.bmFontShader=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.ShaderConfig");
		addMember(l,GetShader_s);
		addMember(l,"Get",null,set_Get,false);
		addMember(l,"imageShader",get_imageShader,set_imageShader,false);
		addMember(l,"textShader",get_textShader,set_textShader,false);
		addMember(l,"textBrighterShader",get_textBrighterShader,set_textBrighterShader,false);
		addMember(l,"bmFontShader",get_bmFontShader,set_bmFontShader,false);
		createTypeMetatable(l,constructor, typeof(FairyGUI.ShaderConfig));
	}
}
