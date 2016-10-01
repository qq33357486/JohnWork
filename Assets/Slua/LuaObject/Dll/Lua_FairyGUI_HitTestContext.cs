using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_HitTestContext : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.HitTestContext o;
			o=new FairyGUI.HitTestContext();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRaycastHitFromCache_s(IntPtr l) {
		try {
			UnityEngine.Camera a1;
			checkType(l,1,out a1);
			UnityEngine.RaycastHit a2;
			var ret=FairyGUI.HitTestContext.GetRaycastHitFromCache(a1,out a2);
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
	static public int CacheRaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Camera a1;
			checkType(l,1,out a1);
			UnityEngine.RaycastHit a2;
			checkValueType(l,2,out a2);
			FairyGUI.HitTestContext.CacheRaycastHit(a1,ref a2);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearRaycastHitCache_s(IntPtr l) {
		try {
			FairyGUI.HitTestContext.ClearRaycastHitCache();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_screenPoint(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.HitTestContext.screenPoint);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_screenPoint(IntPtr l) {
		try {
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			FairyGUI.HitTestContext.screenPoint=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldPoint(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.HitTestContext.worldPoint);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldPoint(IntPtr l) {
		try {
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			FairyGUI.HitTestContext.worldPoint=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_direction(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.HitTestContext.direction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_direction(IntPtr l) {
		try {
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			FairyGUI.HitTestContext.direction=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_forTouch(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.HitTestContext.forTouch);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_forTouch(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			FairyGUI.HitTestContext.forTouch=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.HitTestContext");
		addMember(l,GetRaycastHitFromCache_s);
		addMember(l,CacheRaycastHit_s);
		addMember(l,ClearRaycastHitCache_s);
		addMember(l,"screenPoint",get_screenPoint,set_screenPoint,false);
		addMember(l,"worldPoint",get_worldPoint,set_worldPoint,false);
		addMember(l,"direction",get_direction,set_direction,false);
		addMember(l,"forTouch",get_forTouch,set_forTouch,false);
		createTypeMetatable(l,constructor, typeof(FairyGUI.HitTestContext));
	}
}
