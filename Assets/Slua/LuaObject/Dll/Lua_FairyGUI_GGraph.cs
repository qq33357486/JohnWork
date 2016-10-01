using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GGraph : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GGraph o;
			o=new FairyGUI.GGraph();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReplaceMe(IntPtr l) {
		try {
			FairyGUI.GGraph self=(FairyGUI.GGraph)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			self.ReplaceMe(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddBeforeMe(IntPtr l) {
		try {
			FairyGUI.GGraph self=(FairyGUI.GGraph)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			self.AddBeforeMe(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddAfterMe(IntPtr l) {
		try {
			FairyGUI.GGraph self=(FairyGUI.GGraph)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			self.AddAfterMe(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetNativeObject(IntPtr l) {
		try {
			FairyGUI.GGraph self=(FairyGUI.GGraph)checkSelf(l);
			FairyGUI.DisplayObject a1;
			checkType(l,2,out a1);
			self.SetNativeObject(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawRect(IntPtr l) {
		try {
			FairyGUI.GGraph self=(FairyGUI.GGraph)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Color a4;
			checkType(l,5,out a4);
			UnityEngine.Color a5;
			checkType(l,6,out a5);
			self.DrawRect(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawEllipse(IntPtr l) {
		try {
			FairyGUI.GGraph self=(FairyGUI.GGraph)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			UnityEngine.Color a3;
			checkType(l,4,out a3);
			self.DrawEllipse(a1,a2,a3);
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
			FairyGUI.GGraph self=(FairyGUI.GGraph)checkSelf(l);
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
	static public int get_shape(IntPtr l) {
		try {
			FairyGUI.GGraph self=(FairyGUI.GGraph)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shape);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GGraph");
		addMember(l,ReplaceMe);
		addMember(l,AddBeforeMe);
		addMember(l,AddAfterMe);
		addMember(l,SetNativeObject);
		addMember(l,DrawRect);
		addMember(l,DrawEllipse);
		addMember(l,Setup_BeforeAdd);
		addMember(l,"shape",get_shape,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GGraph),typeof(FairyGUI.GObject));
	}
}
