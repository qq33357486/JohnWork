using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_UBBParser : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Utils.UBBParser o;
			o=new FairyGUI.Utils.UBBParser();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Parse(IntPtr l) {
		try {
			FairyGUI.Utils.UBBParser self=(FairyGUI.Utils.UBBParser)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Parse(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inst(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Utils.UBBParser.inst);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inst(IntPtr l) {
		try {
			FairyGUI.Utils.UBBParser v;
			checkType(l,2,out v);
			FairyGUI.Utils.UBBParser.inst=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultImgWidth(IntPtr l) {
		try {
			FairyGUI.Utils.UBBParser self=(FairyGUI.Utils.UBBParser)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultImgWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultImgWidth(IntPtr l) {
		try {
			FairyGUI.Utils.UBBParser self=(FairyGUI.Utils.UBBParser)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.defaultImgWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultImgHeight(IntPtr l) {
		try {
			FairyGUI.Utils.UBBParser self=(FairyGUI.Utils.UBBParser)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultImgHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultImgHeight(IntPtr l) {
		try {
			FairyGUI.Utils.UBBParser self=(FairyGUI.Utils.UBBParser)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.defaultImgHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Utils.UBBParser");
		addMember(l,Parse);
		addMember(l,"inst",get_inst,set_inst,false);
		addMember(l,"defaultImgWidth",get_defaultImgWidth,set_defaultImgWidth,true);
		addMember(l,"defaultImgHeight",get_defaultImgHeight,set_defaultImgHeight,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Utils.UBBParser));
	}
}
