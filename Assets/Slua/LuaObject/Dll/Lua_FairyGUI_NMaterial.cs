using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_NMaterial : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.NMaterial o;
			UnityEngine.Shader a1;
			checkType(l,2,out a1);
			o=new FairyGUI.NMaterial(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frameId(IntPtr l) {
		try {
			FairyGUI.NMaterial self=(FairyGUI.NMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frameId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frameId(IntPtr l) {
		try {
			FairyGUI.NMaterial self=(FairyGUI.NMaterial)checkSelf(l);
			System.UInt32 v;
			checkType(l,2,out v);
			self.frameId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipId(IntPtr l) {
		try {
			FairyGUI.NMaterial self=(FairyGUI.NMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clipId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipId(IntPtr l) {
		try {
			FairyGUI.NMaterial self=(FairyGUI.NMaterial)checkSelf(l);
			System.UInt32 v;
			checkType(l,2,out v);
			self.clipId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stencilSet(IntPtr l) {
		try {
			FairyGUI.NMaterial self=(FairyGUI.NMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stencilSet);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stencilSet(IntPtr l) {
		try {
			FairyGUI.NMaterial self=(FairyGUI.NMaterial)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.stencilSet=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blendMode(IntPtr l) {
		try {
			FairyGUI.NMaterial self=(FairyGUI.NMaterial)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.blendMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_blendMode(IntPtr l) {
		try {
			FairyGUI.NMaterial self=(FairyGUI.NMaterial)checkSelf(l);
			FairyGUI.BlendMode v;
			checkEnum(l,2,out v);
			self.blendMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_combined(IntPtr l) {
		try {
			FairyGUI.NMaterial self=(FairyGUI.NMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.combined);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_combined(IntPtr l) {
		try {
			FairyGUI.NMaterial self=(FairyGUI.NMaterial)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.combined=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		try {
			FairyGUI.NMaterial self=(FairyGUI.NMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.material);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		try {
			FairyGUI.NMaterial self=(FairyGUI.NMaterial)checkSelf(l);
			UnityEngine.Material v;
			checkType(l,2,out v);
			self.material=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.NMaterial");
		addMember(l,"frameId",get_frameId,set_frameId,true);
		addMember(l,"clipId",get_clipId,set_clipId,true);
		addMember(l,"stencilSet",get_stencilSet,set_stencilSet,true);
		addMember(l,"blendMode",get_blendMode,set_blendMode,true);
		addMember(l,"combined",get_combined,set_combined,true);
		addMember(l,"material",get_material,set_material,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.NMaterial));
	}
}
