using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Relations : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Relations o;
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			o=new FairyGUI.Relations(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				FairyGUI.Relations self=(FairyGUI.Relations)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				FairyGUI.RelationType a2;
				checkEnum(l,3,out a2);
				self.Add(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				FairyGUI.Relations self=(FairyGUI.Relations)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				FairyGUI.RelationType a2;
				checkEnum(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				self.Add(a1,a2,a3);
				pushValue(l,true);
				return 1;
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
	static public int Remove(IntPtr l) {
		try {
			FairyGUI.Relations self=(FairyGUI.Relations)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			FairyGUI.RelationType a2;
			checkEnum(l,3,out a2);
			self.Remove(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Contains(IntPtr l) {
		try {
			FairyGUI.Relations self=(FairyGUI.Relations)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			var ret=self.Contains(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearFor(IntPtr l) {
		try {
			FairyGUI.Relations self=(FairyGUI.Relations)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			self.ClearFor(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearAll(IntPtr l) {
		try {
			FairyGUI.Relations self=(FairyGUI.Relations)checkSelf(l);
			self.ClearAll();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CopyFrom(IntPtr l) {
		try {
			FairyGUI.Relations self=(FairyGUI.Relations)checkSelf(l);
			FairyGUI.Relations a1;
			checkType(l,2,out a1);
			self.CopyFrom(a1);
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
			FairyGUI.Relations self=(FairyGUI.Relations)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnOwnerSizeChanged(IntPtr l) {
		try {
			FairyGUI.Relations self=(FairyGUI.Relations)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.OnOwnerSizeChanged(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Setup(IntPtr l) {
		try {
			FairyGUI.Relations self=(FairyGUI.Relations)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.Setup(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isEmpty(IntPtr l) {
		try {
			FairyGUI.Relations self=(FairyGUI.Relations)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isEmpty);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Relations");
		addMember(l,Add);
		addMember(l,Remove);
		addMember(l,Contains);
		addMember(l,ClearFor);
		addMember(l,ClearAll);
		addMember(l,CopyFrom);
		addMember(l,Dispose);
		addMember(l,OnOwnerSizeChanged);
		addMember(l,Setup);
		addMember(l,"isEmpty",get_isEmpty,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Relations));
	}
}
