using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_DragDropManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.DragDropManager o;
			o=new FairyGUI.DragDropManager();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StartDrag(IntPtr l) {
		try {
			FairyGUI.DragDropManager self=(FairyGUI.DragDropManager)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Object a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.StartDrag(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Cancel(IntPtr l) {
		try {
			FairyGUI.DragDropManager self=(FairyGUI.DragDropManager)checkSelf(l);
			self.Cancel();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inst(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.DragDropManager.inst);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragAgent(IntPtr l) {
		try {
			FairyGUI.DragDropManager self=(FairyGUI.DragDropManager)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dragAgent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragging(IntPtr l) {
		try {
			FairyGUI.DragDropManager self=(FairyGUI.DragDropManager)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dragging);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.DragDropManager");
		addMember(l,StartDrag);
		addMember(l,Cancel);
		addMember(l,"inst",get_inst,null,false);
		addMember(l,"dragAgent",get_dragAgent,null,true);
		addMember(l,"dragging",get_dragging,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.DragDropManager));
	}
}
