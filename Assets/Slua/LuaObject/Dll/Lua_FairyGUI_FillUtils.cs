using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_FillUtils : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.FillUtils o;
			o=new FairyGUI.FillUtils();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FillHorizontal_s(IntPtr l) {
		try {
			FairyGUI.OriginHorizontal a1;
			checkEnum(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Rect a3;
			checkValueType(l,3,out a3);
			UnityEngine.Rect a4;
			checkValueType(l,4,out a4);
			UnityEngine.Vector3[] a5;
			checkArray(l,5,out a5);
			UnityEngine.Vector2[] a6;
			checkArray(l,6,out a6);
			FairyGUI.FillUtils.FillHorizontal(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FillVertical_s(IntPtr l) {
		try {
			FairyGUI.OriginVertical a1;
			checkEnum(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Rect a3;
			checkValueType(l,3,out a3);
			UnityEngine.Rect a4;
			checkValueType(l,4,out a4);
			UnityEngine.Vector3[] a5;
			checkArray(l,5,out a5);
			UnityEngine.Vector2[] a6;
			checkArray(l,6,out a6);
			FairyGUI.FillUtils.FillVertical(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FillRadial90_s(IntPtr l) {
		try {
			FairyGUI.Origin90 a1;
			checkEnum(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			UnityEngine.Rect a4;
			checkValueType(l,4,out a4);
			UnityEngine.Rect a5;
			checkValueType(l,5,out a5);
			UnityEngine.Vector3[] a6;
			checkArray(l,6,out a6);
			UnityEngine.Vector2[] a7;
			checkArray(l,7,out a7);
			FairyGUI.FillUtils.FillRadial90(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FillRadial180_s(IntPtr l) {
		try {
			FairyGUI.Origin180 a1;
			checkEnum(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			UnityEngine.Rect a4;
			checkValueType(l,4,out a4);
			UnityEngine.Rect a5;
			checkValueType(l,5,out a5);
			UnityEngine.Vector3[] a6;
			checkArray(l,6,out a6);
			UnityEngine.Vector2[] a7;
			checkArray(l,7,out a7);
			FairyGUI.FillUtils.FillRadial180(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FillRadial360_s(IntPtr l) {
		try {
			FairyGUI.Origin360 a1;
			checkEnum(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			UnityEngine.Rect a4;
			checkValueType(l,4,out a4);
			UnityEngine.Rect a5;
			checkValueType(l,5,out a5);
			UnityEngine.Vector3[] a6;
			checkArray(l,6,out a6);
			UnityEngine.Vector2[] a7;
			checkArray(l,7,out a7);
			FairyGUI.FillUtils.FillRadial360(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.FillUtils");
		addMember(l,FillHorizontal_s);
		addMember(l,FillVertical_s);
		addMember(l,FillRadial90_s);
		addMember(l,FillRadial180_s);
		addMember(l,FillRadial360_s);
		createTypeMetatable(l,constructor, typeof(FairyGUI.FillUtils));
	}
}
