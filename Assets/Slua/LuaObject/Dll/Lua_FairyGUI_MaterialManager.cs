using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_MaterialManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.MaterialManager o;
			FairyGUI.NTexture a1;
			checkType(l,2,out a1);
			o=new FairyGUI.MaterialManager(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMaterial(IntPtr l) {
		try {
			FairyGUI.MaterialManager self=(FairyGUI.MaterialManager)checkSelf(l);
			FairyGUI.NGraphics a1;
			checkType(l,2,out a1);
			FairyGUI.UpdateContext a2;
			checkType(l,3,out a2);
			var ret=self.GetMaterial(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateMaterial(IntPtr l) {
		try {
			FairyGUI.MaterialManager self=(FairyGUI.MaterialManager)checkSelf(l);
			var ret=self.CreateMaterial();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispose(IntPtr l) {
		try {
			FairyGUI.MaterialManager self=(FairyGUI.MaterialManager)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Release(IntPtr l) {
		try {
			FairyGUI.MaterialManager self=(FairyGUI.MaterialManager)checkSelf(l);
			self.Release();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInstance_s(IntPtr l) {
		try {
			FairyGUI.NTexture a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.String[] a3;
			checkArray(l,3,out a3);
			var ret=FairyGUI.MaterialManager.GetInstance(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		try {
			FairyGUI.MaterialManager self=(FairyGUI.MaterialManager)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.texture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shaderName(IntPtr l) {
		try {
			FairyGUI.MaterialManager self=(FairyGUI.MaterialManager)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shaderName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.MaterialManager");
		addMember(l,GetMaterial);
		addMember(l,CreateMaterial);
		addMember(l,Dispose);
		addMember(l,Release);
		addMember(l,GetInstance_s);
		addMember(l,"texture",get_texture,null,true);
		addMember(l,"shaderName",get_shaderName,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.MaterialManager));
	}
}
