using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_ToolSet : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConvertFromHtmlColor_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.Utils.ToolSet.ConvertFromHtmlColor(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ColorFromRGB_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.Utils.ToolSet.ColorFromRGB(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ColorFromRGBA_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.Utils.ToolSet.ColorFromRGBA(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CharToHex_s(IntPtr l) {
		try {
			System.Char a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.Utils.ToolSet.CharToHex(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Intersects_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rect a2;
			checkValueType(l,2,out a2);
			var ret=FairyGUI.Utils.ToolSet.Intersects(ref a1,ref a2);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a1);
			pushValue(l,a2);
			return 4;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Intersection_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rect a2;
			checkValueType(l,2,out a2);
			var ret=FairyGUI.Utils.ToolSet.Intersection(ref a1,ref a2);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a1);
			pushValue(l,a2);
			return 4;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Union_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rect a2;
			checkValueType(l,2,out a2);
			var ret=FairyGUI.Utils.ToolSet.Union(ref a1,ref a2);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a1);
			pushValue(l,a2);
			return 4;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FlipRect_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			FairyGUI.FlipType a2;
			checkEnum(l,2,out a2);
			FairyGUI.Utils.ToolSet.FlipRect(ref a1,a2);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FlipInnerRect_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Rect a3;
			checkValueType(l,3,out a3);
			FairyGUI.FlipType a4;
			checkEnum(l,4,out a4);
			FairyGUI.Utils.ToolSet.FlipInnerRect(a1,a2,ref a3,a4);
			pushValue(l,true);
			pushValue(l,a3);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int uvLerp_s(IntPtr l) {
		try {
			UnityEngine.Vector2[] a1;
			checkArray(l,1,out a1);
			UnityEngine.Vector2[] a2;
			checkArray(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			FairyGUI.Utils.ToolSet.uvLerp(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetParent_s(IntPtr l) {
		try {
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			UnityEngine.Transform a2;
			checkType(l,2,out a2);
			FairyGUI.Utils.ToolSet.SetParent(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SkewMatrix_s(IntPtr l) {
		try {
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			FairyGUI.Utils.ToolSet.SkewMatrix(ref a1,a2,a3);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsPointInTriangle_s(IntPtr l) {
		try {
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			UnityEngine.Vector2 a4;
			checkType(l,4,out a4);
			var ret=FairyGUI.Utils.ToolSet.IsPointInTriangle(ref a1,ref a2,ref a3,ref a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a1);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			return 6;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Utils.ToolSet");
		addMember(l,ConvertFromHtmlColor_s);
		addMember(l,ColorFromRGB_s);
		addMember(l,ColorFromRGBA_s);
		addMember(l,CharToHex_s);
		addMember(l,Intersects_s);
		addMember(l,Intersection_s);
		addMember(l,Union_s);
		addMember(l,FlipRect_s);
		addMember(l,FlipInnerRect_s);
		addMember(l,uvLerp_s);
		addMember(l,SetParent_s);
		addMember(l,SkewMatrix_s);
		addMember(l,IsPointInTriangle_s);
		createTypeMetatable(l,null, typeof(FairyGUI.Utils.ToolSet));
	}
}
