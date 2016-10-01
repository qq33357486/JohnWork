using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_UIPackage : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.UIPackage o;
			o=new FairyGUI.UIPackage();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPixelHitTestData(IntPtr l) {
		try {
			FairyGUI.UIPackage self=(FairyGUI.UIPackage)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetPixelHitTestData(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateObject(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.UIPackage self=(FairyGUI.UIPackage)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.CreateObject(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.UIPackage self=(FairyGUI.UIPackage)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Type a2;
				checkType(l,3,out a2);
				var ret=self.CreateObject(a1,a2);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetItemAsset(IntPtr l) {
		try {
			FairyGUI.UIPackage self=(FairyGUI.UIPackage)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetItemAsset(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetItems(IntPtr l) {
		try {
			FairyGUI.UIPackage self=(FairyGUI.UIPackage)checkSelf(l);
			var ret=self.GetItems();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetItem(IntPtr l) {
		try {
			FairyGUI.UIPackage self=(FairyGUI.UIPackage)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetItem(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetItemByName(IntPtr l) {
		try {
			FairyGUI.UIPackage self=(FairyGUI.UIPackage)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetItemByName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetById_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.UIPackage.GetById(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetByName_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.UIPackage.GetByName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddPackage_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				var ret=FairyGUI.UIPackage.AddPackage(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.AssetBundle))){
				UnityEngine.AssetBundle a1;
				checkType(l,1,out a1);
				var ret=FairyGUI.UIPackage.AddPackage(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(FairyGUI.UIPackage.LoadResource))){
				System.String a1;
				checkType(l,1,out a1);
				FairyGUI.UIPackage.LoadResource a2;
				LuaDelegation.checkDelegate(l,2,out a2);
				var ret=FairyGUI.UIPackage.AddPackage(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(UnityEngine.AssetBundle))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.AssetBundle a2;
				checkType(l,2,out a2);
				var ret=FairyGUI.UIPackage.AddPackage(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.AssetBundle),typeof(UnityEngine.AssetBundle))){
				UnityEngine.AssetBundle a1;
				checkType(l,1,out a1);
				UnityEngine.AssetBundle a2;
				checkType(l,2,out a2);
				var ret=FairyGUI.UIPackage.AddPackage(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.AssetBundle),typeof(UnityEngine.AssetBundle),typeof(string))){
				UnityEngine.AssetBundle a1;
				checkType(l,1,out a1);
				UnityEngine.AssetBundle a2;
				checkType(l,2,out a2);
				System.String a3;
				checkType(l,3,out a3);
				var ret=FairyGUI.UIPackage.AddPackage(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(UnityEngine.AssetBundle),typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.AssetBundle a2;
				checkType(l,2,out a2);
				System.String a3;
				checkType(l,3,out a3);
				var ret=FairyGUI.UIPackage.AddPackage(a1,a2,a3);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemovePackage_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				FairyGUI.UIPackage.RemovePackage(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				FairyGUI.UIPackage.RemovePackage(a1,a2);
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
	static public int RemoveAllPackages_s(IntPtr l) {
		try {
			FairyGUI.UIPackage.RemoveAllPackages();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPackages_s(IntPtr l) {
		try {
			var ret=FairyGUI.UIPackage.GetPackages();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateObject_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				var ret=FairyGUI.UIPackage.CreateObject(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.String a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				System.Type a3;
				checkType(l,3,out a3);
				var ret=FairyGUI.UIPackage.CreateObject(a1,a2,a3);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateObjectFromURL_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				var ret=FairyGUI.UIPackage.CreateObjectFromURL(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Type a2;
				checkType(l,2,out a2);
				var ret=FairyGUI.UIPackage.CreateObjectFromURL(a1,a2);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetItemAsset_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=FairyGUI.UIPackage.GetItemAsset(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetItemAssetByURL_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.UIPackage.GetItemAssetByURL(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetItemURL_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=FairyGUI.UIPackage.GetItemURL(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetItemByURL_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=FairyGUI.UIPackage.GetItemByURL(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetStringsSource_s(IntPtr l) {
		try {
			FairyGUI.Utils.XML a1;
			checkType(l,1,out a1);
			FairyGUI.UIPackage.SetStringsSource(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_id(IntPtr l) {
		try {
			FairyGUI.UIPackage self=(FairyGUI.UIPackage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.id);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		try {
			FairyGUI.UIPackage self=(FairyGUI.UIPackage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_assetPath(IntPtr l) {
		try {
			FairyGUI.UIPackage self=(FairyGUI.UIPackage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.assetPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_customId(IntPtr l) {
		try {
			FairyGUI.UIPackage self=(FairyGUI.UIPackage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.customId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_customId(IntPtr l) {
		try {
			FairyGUI.UIPackage self=(FairyGUI.UIPackage)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.customId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.UIPackage");
		addMember(l,GetPixelHitTestData);
		addMember(l,CreateObject);
		addMember(l,GetItemAsset);
		addMember(l,GetItems);
		addMember(l,GetItem);
		addMember(l,GetItemByName);
		addMember(l,GetById_s);
		addMember(l,GetByName_s);
		addMember(l,AddPackage_s);
		addMember(l,RemovePackage_s);
		addMember(l,RemoveAllPackages_s);
		addMember(l,GetPackages_s);
		addMember(l,CreateObject_s);
		addMember(l,CreateObjectFromURL_s);
		addMember(l,GetItemAsset_s);
		addMember(l,GetItemAssetByURL_s);
		addMember(l,GetItemURL_s);
		addMember(l,GetItemByURL_s);
		addMember(l,SetStringsSource_s);
		addMember(l,"id",get_id,null,true);
		addMember(l,"name",get_name,null,true);
		addMember(l,"assetPath",get_assetPath,null,true);
		addMember(l,"customId",get_customId,set_customId,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.UIPackage));
	}
}
