using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_StageEngine : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ObjectTotal(IntPtr l) {
		try {
			FairyGUI.StageEngine self=(FairyGUI.StageEngine)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ObjectTotal);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ObjectTotal(IntPtr l) {
		try {
			FairyGUI.StageEngine self=(FairyGUI.StageEngine)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.ObjectTotal=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ObjectOnStage(IntPtr l) {
		try {
			FairyGUI.StageEngine self=(FairyGUI.StageEngine)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ObjectOnStage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ObjectOnStage(IntPtr l) {
		try {
			FairyGUI.StageEngine self=(FairyGUI.StageEngine)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.ObjectOnStage=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.StageEngine");
		addMember(l,"ObjectTotal",get_ObjectTotal,set_ObjectTotal,true);
		addMember(l,"ObjectOnStage",get_ObjectOnStage,set_ObjectOnStage,true);
		createTypeMetatable(l,null, typeof(FairyGUI.StageEngine),typeof(UnityEngine.MonoBehaviour));
	}
}
