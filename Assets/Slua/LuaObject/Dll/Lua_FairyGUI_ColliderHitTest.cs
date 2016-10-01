using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_ColliderHitTest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetArea(IntPtr l) {
		try {
			FairyGUI.ColliderHitTest self=(FairyGUI.ColliderHitTest)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			self.SetArea(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetEnabled(IntPtr l) {
		try {
			FairyGUI.ColliderHitTest self=(FairyGUI.ColliderHitTest)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.SetEnabled(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HitTest(IntPtr l) {
		try {
			FairyGUI.ColliderHitTest self=(FairyGUI.ColliderHitTest)checkSelf(l);
			FairyGUI.Container a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,3,out a2);
			var ret=self.HitTest(a1,ref a2);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		try {
			FairyGUI.ColliderHitTest self=(FairyGUI.ColliderHitTest)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.collider);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collider(IntPtr l) {
		try {
			FairyGUI.ColliderHitTest self=(FairyGUI.ColliderHitTest)checkSelf(l);
			UnityEngine.Collider v;
			checkType(l,2,out v);
			self.collider=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.ColliderHitTest");
		addMember(l,SetArea);
		addMember(l,SetEnabled);
		addMember(l,HitTest);
		addMember(l,"collider",get_collider,set_collider,true);
		createTypeMetatable(l,null, typeof(FairyGUI.ColliderHitTest));
	}
}
