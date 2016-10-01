using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_UIObjectFactory : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.UIObjectFactory o;
			o=new FairyGUI.UIObjectFactory();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPackageItemExtension_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Type a2;
			checkType(l,2,out a2);
			FairyGUI.UIObjectFactory.SetPackageItemExtension(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLoaderExtension_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			FairyGUI.UIObjectFactory.SetLoaderExtension(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int NewObject_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				var ret=FairyGUI.UIObjectFactory.NewObject(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(FairyGUI.PackageItem))){
				FairyGUI.PackageItem a1;
				checkType(l,1,out a1);
				var ret=FairyGUI.UIObjectFactory.NewObject(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.UIObjectFactory");
		addMember(l,SetPackageItemExtension_s);
		addMember(l,SetLoaderExtension_s);
		addMember(l,NewObject_s);
		createTypeMetatable(l,constructor, typeof(FairyGUI.UIObjectFactory));
	}
}
