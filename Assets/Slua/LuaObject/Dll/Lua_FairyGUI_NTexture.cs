using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_NTexture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			FairyGUI.NTexture o;
			if(argc==2){
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				o=new FairyGUI.NTexture(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				o=new FairyGUI.NTexture(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Texture),typeof(UnityEngine.Rect))){
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				UnityEngine.Rect a2;
				checkValueType(l,3,out a2);
				o=new FairyGUI.NTexture(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(FairyGUI.NTexture),typeof(UnityEngine.Rect))){
				FairyGUI.NTexture a1;
				checkType(l,2,out a1);
				UnityEngine.Rect a2;
				checkValueType(l,3,out a2);
				o=new FairyGUI.NTexture(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DestroyMaterials(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			self.DestroyMaterials();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispose(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
				self.Dispose();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Dispose(a1);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DisposeEmpty_s(IntPtr l) {
		try {
			FairyGUI.NTexture.DisposeEmpty();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_refCount(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.refCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_refCount(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.refCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disposed(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.disposed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disposed(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.disposed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastActive(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lastActive);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lastActive(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.lastActive=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_storedODisk(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.storedODisk);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_storedODisk(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.storedODisk=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nativeTexture(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.nativeTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alphaTexture(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.alphaTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alphaTexture(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			FairyGUI.NTexture v;
			checkType(l,2,out v);
			self.alphaTexture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_root(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.root);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvRect(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uvRect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_materialManagers(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.materialManagers);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Empty(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.NTexture.Empty);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		try {
			FairyGUI.NTexture self=(FairyGUI.NTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.NTexture");
		addMember(l,DestroyMaterials);
		addMember(l,Dispose);
		addMember(l,DisposeEmpty_s);
		addMember(l,"refCount",get_refCount,set_refCount,true);
		addMember(l,"disposed",get_disposed,set_disposed,true);
		addMember(l,"lastActive",get_lastActive,set_lastActive,true);
		addMember(l,"storedODisk",get_storedODisk,set_storedODisk,true);
		addMember(l,"nativeTexture",get_nativeTexture,null,true);
		addMember(l,"alphaTexture",get_alphaTexture,set_alphaTexture,true);
		addMember(l,"root",get_root,null,true);
		addMember(l,"uvRect",get_uvRect,null,true);
		addMember(l,"materialManagers",get_materialManagers,null,true);
		addMember(l,"Empty",get_Empty,null,false);
		addMember(l,"width",get_width,null,true);
		addMember(l,"height",get_height,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.NTexture));
	}
}
