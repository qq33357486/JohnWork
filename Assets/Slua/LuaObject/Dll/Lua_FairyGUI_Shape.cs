using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Shape : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Shape o;
			o=new FairyGUI.Shape();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawRect(IntPtr l) {
		try {
			FairyGUI.Shape self=(FairyGUI.Shape)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			UnityEngine.Color a3;
			checkType(l,4,out a3);
			self.DrawRect(a1,a2,a3);
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
			FairyGUI.Shape self=(FairyGUI.Shape)checkSelf(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			self.DrawEllipse(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawPolygon(IntPtr l) {
		try {
			FairyGUI.Shape self=(FairyGUI.Shape)checkSelf(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2[] a2;
			checkArray(l,3,out a2);
			self.DrawPolygon(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try {
			FairyGUI.Shape self=(FairyGUI.Shape)checkSelf(l);
			self.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Update(IntPtr l) {
		try {
			FairyGUI.Shape self=(FairyGUI.Shape)checkSelf(l);
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
	static public int get_empty(IntPtr l) {
		try {
			FairyGUI.Shape self=(FairyGUI.Shape)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.empty);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Shape");
		addMember(l,DrawRect);
		addMember(l,DrawEllipse);
		addMember(l,DrawPolygon);
		addMember(l,Clear);
		addMember(l,Update);
		addMember(l,"empty",get_empty,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Shape),typeof(FairyGUI.DisplayObject));
	}
}
