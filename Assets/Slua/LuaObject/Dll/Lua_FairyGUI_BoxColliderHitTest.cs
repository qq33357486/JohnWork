using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_BoxColliderHitTest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.BoxColliderHitTest o;
			UnityEngine.BoxCollider a1;
			checkType(l,2,out a1);
			o=new FairyGUI.BoxColliderHitTest(a1);
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
			FairyGUI.BoxColliderHitTest self=(FairyGUI.BoxColliderHitTest)checkSelf(l);
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
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.BoxColliderHitTest");
		addMember(l,SetArea);
		createTypeMetatable(l,constructor, typeof(FairyGUI.BoxColliderHitTest),typeof(FairyGUI.ColliderHitTest));
	}
}
