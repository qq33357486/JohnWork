using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_MeshColliderHitTest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.MeshColliderHitTest o;
			UnityEngine.MeshCollider a1;
			checkType(l,2,out a1);
			o=new FairyGUI.MeshColliderHitTest(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetArea(IntPtr l) {
		try {
			FairyGUI.MeshColliderHitTest self=(FairyGUI.MeshColliderHitTest)checkSelf(l);
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
	static public int HitTest(IntPtr l) {
		try {
			FairyGUI.MeshColliderHitTest self=(FairyGUI.MeshColliderHitTest)checkSelf(l);
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
	static public int ScreenToLocal(IntPtr l) {
		try {
			FairyGUI.MeshColliderHitTest self=(FairyGUI.MeshColliderHitTest)checkSelf(l);
			UnityEngine.Camera a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,4,out a3);
			var ret=self.ScreenToLocal(a1,a2,ref a3);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.MeshColliderHitTest");
		addMember(l,SetArea);
		addMember(l,HitTest);
		addMember(l,ScreenToLocal);
		createTypeMetatable(l,constructor, typeof(FairyGUI.MeshColliderHitTest),typeof(FairyGUI.ColliderHitTest));
	}
}
