using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WSA_Tile : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Update(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.Update(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				System.String a4;
				checkType(l,5,out a4);
				self.Update(a1,a2,a3,a4);
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
	static public int PeriodicUpdate(IntPtr l) {
		try {
			UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.PeriodicUpdate(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StopPeriodicUpdate(IntPtr l) {
		try {
			UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
			self.StopPeriodicUpdate();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateBadgeImage(IntPtr l) {
		try {
			UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.UpdateBadgeImage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateBadgeNumber(IntPtr l) {
		try {
			UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.UpdateBadgeNumber(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveBadge(IntPtr l) {
		try {
			UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
			self.RemoveBadge();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PeriodicBadgeUpdate(IntPtr l) {
		try {
			UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.PeriodicBadgeUpdate(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StopPeriodicBadgeUpdate(IntPtr l) {
		try {
			UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
			self.StopPeriodicBadgeUpdate();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Delete(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
				self.Delete();
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rect))){
				UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
				UnityEngine.Rect a1;
				checkValueType(l,2,out a1);
				self.Delete(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector2))){
				UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				self.Delete(a1);
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
	static public int GetTemplate_s(IntPtr l) {
		try {
			UnityEngine.WSA.TileTemplate a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.WSA.Tile.GetTemplate(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Exists_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.WSA.Tile.Exists(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateOrUpdateSecondary_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.WSA.SecondaryTileData a1;
				checkValueType(l,1,out a1);
				var ret=UnityEngine.WSA.Tile.CreateOrUpdateSecondary(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.WSA.SecondaryTileData),typeof(UnityEngine.Rect))){
				UnityEngine.WSA.SecondaryTileData a1;
				checkValueType(l,1,out a1);
				UnityEngine.Rect a2;
				checkValueType(l,2,out a2);
				var ret=UnityEngine.WSA.Tile.CreateOrUpdateSecondary(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.WSA.SecondaryTileData),typeof(UnityEngine.Vector2))){
				UnityEngine.WSA.SecondaryTileData a1;
				checkValueType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.WSA.Tile.CreateOrUpdateSecondary(a1,a2);
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
	static public int GetSecondary_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.WSA.Tile.GetSecondary(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSecondaries_s(IntPtr l) {
		try {
			var ret=UnityEngine.WSA.Tile.GetSecondaries();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DeleteSecondary_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.WSA.Tile.DeleteSecondary(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(UnityEngine.Rect))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkValueType(l,2,out a2);
				UnityEngine.WSA.Tile.DeleteSecondary(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(UnityEngine.Vector2))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.WSA.Tile.DeleteSecondary(a1,a2);
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
	static public int get_main(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.WSA.Tile.main);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_id(IntPtr l) {
		try {
			UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.id);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasUserConsent(IntPtr l) {
		try {
			UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasUserConsent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_exists(IntPtr l) {
		try {
			UnityEngine.WSA.Tile self=(UnityEngine.WSA.Tile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.exists);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WSA.Tile");
		addMember(l,Update);
		addMember(l,PeriodicUpdate);
		addMember(l,StopPeriodicUpdate);
		addMember(l,UpdateBadgeImage);
		addMember(l,UpdateBadgeNumber);
		addMember(l,RemoveBadge);
		addMember(l,PeriodicBadgeUpdate);
		addMember(l,StopPeriodicBadgeUpdate);
		addMember(l,Delete);
		addMember(l,GetTemplate_s);
		addMember(l,Exists_s);
		addMember(l,CreateOrUpdateSecondary_s);
		addMember(l,GetSecondary_s);
		addMember(l,GetSecondaries_s);
		addMember(l,DeleteSecondary_s);
		addMember(l,"main",get_main,null,false);
		addMember(l,"id",get_id,null,true);
		addMember(l,"hasUserConsent",get_hasUserConsent,null,true);
		addMember(l,"exists",get_exists,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.WSA.Tile));
	}
}
