using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_UIPainter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetSortingOrder(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetSortingOrder(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateUI(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			self.CreateUI();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ApplyModifiedProperties(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.ApplyModifiedProperties(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnUpdateSource(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			System.Object[] a1;
			checkArray(l,2,out a1);
			self.OnUpdateSource(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EM_BeforeUpdate(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			self.EM_BeforeUpdate();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EM_Update(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			FairyGUI.UpdateContext a1;
			checkType(l,2,out a1);
			self.EM_Update(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EM_Reload(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			self.EM_Reload();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packageName(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.packageName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_packageName(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.packageName=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_componentName(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.componentName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_componentName(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.componentName=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingOrder(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sortingOrder);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingOrder(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.sortingOrder=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_container(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.container);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ui(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ui);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_EM_sortingOrder(IntPtr l) {
		try {
			FairyGUI.UIPainter self=(FairyGUI.UIPainter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.EM_sortingOrder);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.UIPainter");
		addMember(l,SetSortingOrder);
		addMember(l,CreateUI);
		addMember(l,ApplyModifiedProperties);
		addMember(l,OnUpdateSource);
		addMember(l,EM_BeforeUpdate);
		addMember(l,EM_Update);
		addMember(l,EM_Reload);
		addMember(l,"packageName",get_packageName,set_packageName,true);
		addMember(l,"componentName",get_componentName,set_componentName,true);
		addMember(l,"sortingOrder",get_sortingOrder,set_sortingOrder,true);
		addMember(l,"container",get_container,null,true);
		addMember(l,"ui",get_ui,null,true);
		addMember(l,"EM_sortingOrder",get_EM_sortingOrder,null,true);
		createTypeMetatable(l,null, typeof(FairyGUI.UIPainter),typeof(UnityEngine.MonoBehaviour));
	}
}
