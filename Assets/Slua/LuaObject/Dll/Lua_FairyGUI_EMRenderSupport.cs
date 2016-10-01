using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_EMRenderSupport : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.EMRenderSupport o;
			o=new FairyGUI.EMRenderSupport();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add_s(IntPtr l) {
		try {
			FairyGUI.EMRenderTarget a1;
			checkType(l,1,out a1);
			FairyGUI.EMRenderSupport.Add(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Remove_s(IntPtr l) {
		try {
			FairyGUI.EMRenderTarget a1;
			checkType(l,1,out a1);
			FairyGUI.EMRenderSupport.Remove(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Update_s(IntPtr l) {
		try {
			FairyGUI.EMRenderSupport.Update();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Reload_s(IntPtr l) {
		try {
			FairyGUI.EMRenderSupport.Reload();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orderChanged(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.EMRenderSupport.orderChanged);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orderChanged(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			FairyGUI.EMRenderSupport.orderChanged=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packageListReady(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.EMRenderSupport.packageListReady);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasTarget(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.EMRenderSupport.hasTarget);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.EMRenderSupport");
		addMember(l,Add_s);
		addMember(l,Remove_s);
		addMember(l,Update_s);
		addMember(l,Reload_s);
		addMember(l,"orderChanged",get_orderChanged,set_orderChanged,false);
		addMember(l,"packageListReady",get_packageListReady,null,false);
		addMember(l,"hasTarget",get_hasTarget,null,false);
		createTypeMetatable(l,constructor, typeof(FairyGUI.EMRenderSupport));
	}
}
