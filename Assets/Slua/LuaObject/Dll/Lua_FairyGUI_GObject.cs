using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GObject : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GObject o;
			o=new FairyGUI.GObject();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetXY(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetXY(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPosition(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.SetPosition(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Center(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				self.Center();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Center(a1);
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
	static public int SetSize(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetSize(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				self.SetSize(a1,a2,a3);
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
	static public int SetScale(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetScale(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPivot(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetPivot(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				self.SetPivot(a1,a2,a3);
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
	static public int RequestFocus(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			self.RequestFocus();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int InvalidateBatchingState(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			self.InvalidateBatchingState();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HandleControllerChanged(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			FairyGUI.Controller a1;
			checkType(l,2,out a1);
			self.HandleControllerChanged(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddRelation(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				FairyGUI.RelationType a2;
				checkEnum(l,3,out a2);
				self.AddRelation(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				FairyGUI.RelationType a2;
				checkEnum(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				self.AddRelation(a1,a2,a3);
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
	static public int RemoveRelation(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			FairyGUI.RelationType a2;
			checkEnum(l,3,out a2);
			self.RemoveRelation(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveFromParent(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			self.RemoveFromParent();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StartDrag(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				self.StartDrag();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.StartDrag(a1);
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
	static public int StopDrag(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			self.StopDrag();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LocalToGlobal(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Rect))){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				UnityEngine.Rect a1;
				checkValueType(l,2,out a1);
				var ret=self.LocalToGlobal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector2))){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				var ret=self.LocalToGlobal(a1);
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
	static public int GlobalToLocal(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Rect))){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				UnityEngine.Rect a1;
				checkValueType(l,2,out a1);
				var ret=self.GlobalToLocal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector2))){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				var ret=self.GlobalToLocal(a1);
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
	static public int LocalToRoot(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			FairyGUI.GRoot a2;
			checkType(l,3,out a2);
			var ret=self.LocalToRoot(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RootToLocal(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			FairyGUI.GRoot a2;
			checkType(l,3,out a2);
			var ret=self.RootToLocal(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WorldToLocal(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				var ret=self.WorldToLocal(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Camera a2;
				checkType(l,3,out a2);
				var ret=self.WorldToLocal(a1,a2);
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
	static public int TransformPoint(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			FairyGUI.GObject a2;
			checkType(l,3,out a2);
			var ret=self.TransformPoint(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TransformRect(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			FairyGUI.GObject a2;
			checkType(l,3,out a2);
			var ret=self.TransformRect(a1,a2);
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
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConstructFromResource(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			FairyGUI.PackageItem a1;
			checkType(l,2,out a1);
			self.ConstructFromResource(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Setup_BeforeAdd(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.Setup_BeforeAdd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Setup_AfterAdd(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.Setup_AfterAdd(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TweenMove(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.TweenMove(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TweenMoveX(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.TweenMoveX(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TweenMoveY(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.TweenMoveY(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TweenScale(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.TweenScale(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TweenScaleX(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.TweenScaleX(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TweenScaleY(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.TweenScaleY(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TweenResize(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.TweenResize(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TweenFade(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.TweenFade(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TweenRotate(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.TweenRotate(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.name=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_data(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.data);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_data(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			System.Object v;
			checkType(l,2,out v);
			self.data=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_group(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.group);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_group(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			FairyGUI.GGroup v;
			checkType(l,2,out v);
			self.group=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragBounds(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dragBounds);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dragBounds(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			Rect v;
			checkValueType(l,2,out v);
			self.dragBounds=v;
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
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.id);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sourceWidth(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sourceWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sourceHeight(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sourceHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_initWidth(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.initWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_initHeight(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.initHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relations(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.relations);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_parent(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.parent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_displayObject(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.displayObject);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gearDisplay(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gearDisplay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gearXY(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gearXY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gearSize(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gearSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gearLook(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gearLook);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onClick(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onClick);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onRightClick(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onRightClick);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onTouchBegin(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onTouchBegin);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onTouchEnd(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onTouchEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onRollOver(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onRollOver);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onRollOut(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onRollOut);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onAddedToStage(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onAddedToStage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onRemovedFromStage(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onRemovedFromStage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onKeyDown(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onKeyDown);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onClickLink(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onClickLink);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onPositionChanged(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onPositionChanged);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onSizeChanged(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onSizeChanged);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDragStart(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onDragStart);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDragEnd(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onDragEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_x(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.x);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_x(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.x=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.y);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_y(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.y=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_z(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.z);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_z(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.z=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_xy(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.xy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_xy(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.xy=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.position=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelSnapping(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pixelSnapping);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelSnapping(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.pixelSnapping=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.width=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.height=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.size);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.size=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_actualWidth(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.actualWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_actualHeight(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.actualHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scaleX(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scaleX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scaleX(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.scaleX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scaleY(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scaleY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scaleY(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.scaleY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scale(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scale(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.scale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_skew(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.skew);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_skew(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.skew=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivotX(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pivotX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pivotX(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.pivotX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivotY(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pivotY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pivotY(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.pivotY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivot(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pivot);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pivot(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.pivot=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchable(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.touchable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_touchable(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.touchable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_grayed(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.grayed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_grayed(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.grayed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotation(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.rotation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationX(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rotationX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotationX(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.rotationX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationY(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rotationY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotationY(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.rotationY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alpha(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.alpha);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alpha(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.alpha=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_visible(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.visible);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_visible(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.visible=v;
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
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
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
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			int v;
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
	static public int get_focusable(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.focusable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_focusable(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.focusable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_focused(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.focused);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tooltips(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tooltips);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tooltips(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.tooltips=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_filter(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.filter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_filter(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			FairyGUI.IFilter v;
			checkType(l,2,out v);
			self.filter=v;
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
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
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
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
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
	static public int get_inContainer(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.inContainer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onStage(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onStage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resourceURL(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.resourceURL);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_root(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.root);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.text);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.text=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_draggable(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.draggable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_draggable(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.draggable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragging(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dragging);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asImage(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asImage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asCom(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asCom);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asButton(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asButton);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asLabel(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asLabel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asProgress(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asProgress);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asSlider(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asSlider);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asComboBox(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asComboBox);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asTextField(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asTextField);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asRichTextField(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asRichTextField);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asTextInput(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asTextInput);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asLoader(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asLoader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asList(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asGraph(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asGraph);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asGroup(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asGroup);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asMovieClip(IntPtr l) {
		try {
			FairyGUI.GObject self=(FairyGUI.GObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.asMovieClip);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GObject");
		addMember(l,SetXY);
		addMember(l,SetPosition);
		addMember(l,Center);
		addMember(l,SetSize);
		addMember(l,SetScale);
		addMember(l,SetPivot);
		addMember(l,RequestFocus);
		addMember(l,InvalidateBatchingState);
		addMember(l,HandleControllerChanged);
		addMember(l,AddRelation);
		addMember(l,RemoveRelation);
		addMember(l,RemoveFromParent);
		addMember(l,StartDrag);
		addMember(l,StopDrag);
		addMember(l,LocalToGlobal);
		addMember(l,GlobalToLocal);
		addMember(l,LocalToRoot);
		addMember(l,RootToLocal);
		addMember(l,WorldToLocal);
		addMember(l,TransformPoint);
		addMember(l,TransformRect);
		addMember(l,Dispose);
		addMember(l,ConstructFromResource);
		addMember(l,Setup_BeforeAdd);
		addMember(l,Setup_AfterAdd);
		addMember(l,TweenMove);
		addMember(l,TweenMoveX);
		addMember(l,TweenMoveY);
		addMember(l,TweenScale);
		addMember(l,TweenScaleX);
		addMember(l,TweenScaleY);
		addMember(l,TweenResize);
		addMember(l,TweenFade);
		addMember(l,TweenRotate);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"data",get_data,set_data,true);
		addMember(l,"group",get_group,set_group,true);
		addMember(l,"dragBounds",get_dragBounds,set_dragBounds,true);
		addMember(l,"id",get_id,null,true);
		addMember(l,"sourceWidth",get_sourceWidth,null,true);
		addMember(l,"sourceHeight",get_sourceHeight,null,true);
		addMember(l,"initWidth",get_initWidth,null,true);
		addMember(l,"initHeight",get_initHeight,null,true);
		addMember(l,"relations",get_relations,null,true);
		addMember(l,"parent",get_parent,null,true);
		addMember(l,"displayObject",get_displayObject,null,true);
		addMember(l,"gearDisplay",get_gearDisplay,null,true);
		addMember(l,"gearXY",get_gearXY,null,true);
		addMember(l,"gearSize",get_gearSize,null,true);
		addMember(l,"gearLook",get_gearLook,null,true);
		addMember(l,"onClick",get_onClick,null,true);
		addMember(l,"onRightClick",get_onRightClick,null,true);
		addMember(l,"onTouchBegin",get_onTouchBegin,null,true);
		addMember(l,"onTouchEnd",get_onTouchEnd,null,true);
		addMember(l,"onRollOver",get_onRollOver,null,true);
		addMember(l,"onRollOut",get_onRollOut,null,true);
		addMember(l,"onAddedToStage",get_onAddedToStage,null,true);
		addMember(l,"onRemovedFromStage",get_onRemovedFromStage,null,true);
		addMember(l,"onKeyDown",get_onKeyDown,null,true);
		addMember(l,"onClickLink",get_onClickLink,null,true);
		addMember(l,"onPositionChanged",get_onPositionChanged,null,true);
		addMember(l,"onSizeChanged",get_onSizeChanged,null,true);
		addMember(l,"onDragStart",get_onDragStart,null,true);
		addMember(l,"onDragEnd",get_onDragEnd,null,true);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"z",get_z,set_z,true);
		addMember(l,"xy",get_xy,set_xy,true);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"pixelSnapping",get_pixelSnapping,set_pixelSnapping,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"actualWidth",get_actualWidth,null,true);
		addMember(l,"actualHeight",get_actualHeight,null,true);
		addMember(l,"scaleX",get_scaleX,set_scaleX,true);
		addMember(l,"scaleY",get_scaleY,set_scaleY,true);
		addMember(l,"scale",get_scale,set_scale,true);
		addMember(l,"skew",get_skew,set_skew,true);
		addMember(l,"pivotX",get_pivotX,set_pivotX,true);
		addMember(l,"pivotY",get_pivotY,set_pivotY,true);
		addMember(l,"pivot",get_pivot,set_pivot,true);
		addMember(l,"touchable",get_touchable,set_touchable,true);
		addMember(l,"grayed",get_grayed,set_grayed,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"rotation",get_rotation,set_rotation,true);
		addMember(l,"rotationX",get_rotationX,set_rotationX,true);
		addMember(l,"rotationY",get_rotationY,set_rotationY,true);
		addMember(l,"alpha",get_alpha,set_alpha,true);
		addMember(l,"visible",get_visible,set_visible,true);
		addMember(l,"sortingOrder",get_sortingOrder,set_sortingOrder,true);
		addMember(l,"focusable",get_focusable,set_focusable,true);
		addMember(l,"focused",get_focused,null,true);
		addMember(l,"tooltips",get_tooltips,set_tooltips,true);
		addMember(l,"filter",get_filter,set_filter,true);
		addMember(l,"blendMode",get_blendMode,set_blendMode,true);
		addMember(l,"inContainer",get_inContainer,null,true);
		addMember(l,"onStage",get_onStage,null,true);
		addMember(l,"resourceURL",get_resourceURL,null,true);
		addMember(l,"root",get_root,null,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"draggable",get_draggable,set_draggable,true);
		addMember(l,"dragging",get_dragging,null,true);
		addMember(l,"asImage",get_asImage,null,true);
		addMember(l,"asCom",get_asCom,null,true);
		addMember(l,"asButton",get_asButton,null,true);
		addMember(l,"asLabel",get_asLabel,null,true);
		addMember(l,"asProgress",get_asProgress,null,true);
		addMember(l,"asSlider",get_asSlider,null,true);
		addMember(l,"asComboBox",get_asComboBox,null,true);
		addMember(l,"asTextField",get_asTextField,null,true);
		addMember(l,"asRichTextField",get_asRichTextField,null,true);
		addMember(l,"asTextInput",get_asTextInput,null,true);
		addMember(l,"asLoader",get_asLoader,null,true);
		addMember(l,"asList",get_asList,null,true);
		addMember(l,"asGraph",get_asGraph,null,true);
		addMember(l,"asGroup",get_asGroup,null,true);
		addMember(l,"asMovieClip",get_asMovieClip,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GObject),typeof(FairyGUI.EventDispatcher));
	}
}
