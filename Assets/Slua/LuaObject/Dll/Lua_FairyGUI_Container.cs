using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Container : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			FairyGUI.Container o;
			if(argc==1){
				o=new FairyGUI.Container();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				o=new FairyGUI.Container(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.GameObject))){
				UnityEngine.GameObject a1;
				checkType(l,2,out a1);
				o=new FairyGUI.Container(a1);
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
	static public int AddChild(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			FairyGUI.DisplayObject a1;
			checkType(l,2,out a1);
			var ret=self.AddChild(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddChildAt(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			FairyGUI.DisplayObject a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.AddChildAt(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Contains(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			FairyGUI.DisplayObject a1;
			checkType(l,2,out a1);
			var ret=self.Contains(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetChildAt(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetChildAt(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetChild(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetChild(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetChildIndex(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			FairyGUI.DisplayObject a1;
			checkType(l,2,out a1);
			var ret=self.GetChildIndex(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveChild(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
				FairyGUI.DisplayObject a1;
				checkType(l,2,out a1);
				var ret=self.RemoveChild(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
				FairyGUI.DisplayObject a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.RemoveChild(a1,a2);
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
	static public int RemoveChildAt(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.RemoveChildAt(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.RemoveChildAt(a1,a2);
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
	static public int RemoveChildren(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
				self.RemoveChildren();
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				self.RemoveChildren(a1,a2,a3);
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
	static public int SetChildIndex(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			FairyGUI.DisplayObject a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetChildIndex(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SwapChildren(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			FairyGUI.DisplayObject a1;
			checkType(l,2,out a1);
			FairyGUI.DisplayObject a2;
			checkType(l,3,out a2);
			self.SwapChildren(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SwapChildrenAt(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SwapChildrenAt(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ChangeChildrenOrder(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			System.Collections.Generic.List<System.Int32> a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<FairyGUI.DisplayObject> a2;
			checkType(l,3,out a2);
			self.ChangeChildrenOrder(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBounds(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			FairyGUI.DisplayObject a1;
			checkType(l,2,out a1);
			var ret=self.GetBounds(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRenderCamera(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			var ret=self.GetRenderCamera();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HitTest(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			var ret=self.HitTest(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetHitTestLocalPoint(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			var ret=self.GetHitTestLocalPoint();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsAncestorOf(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			FairyGUI.DisplayObject a1;
			checkType(l,2,out a1);
			var ret=self.IsAncestorOf(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int InvalidateBatchingState(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.InvalidateBatchingState(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetChildrenLayer(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.SetChildrenLayer(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Update(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			FairyGUI.UpdateContext a1;
			checkType(l,2,out a1);
			self.Update(a1);
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
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderMode(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.renderMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderMode(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			UnityEngine.RenderMode v;
			checkEnum(l,2,out v);
			self.renderMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderCamera(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.renderCamera);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderCamera(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			UnityEngine.Camera v;
			checkType(l,2,out v);
			self.renderCamera=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_opaque(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.opaque);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_opaque(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.opaque=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipSoftness(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clipSoftness);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipSoftness(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			Vector4 v;
			checkValueType(l,2,out v);
			self.clipSoftness=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hitArea(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hitArea);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hitArea(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			FairyGUI.IHitTest v;
			checkType(l,2,out v);
			self.hitArea=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchChildren(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.touchChildren);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_touchChildren(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.touchChildren=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUpdate(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			FairyGUI.EventCallback0 v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onUpdate=v;
			else if(op==1) self.onUpdate+=v;
			else if(op==2) self.onUpdate-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_numChildren(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.numChildren);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipRect(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clipRect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipRect(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			Rect v;
			checkValueType(l,2,out v);
			self.clipRect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mask(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mask(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			FairyGUI.DisplayObject v;
			checkType(l,2,out v);
			self.mask=v;
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
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
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
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
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
	static public int get_fairyBatching(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fairyBatching);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fairyBatching(IntPtr l) {
		try {
			FairyGUI.Container self=(FairyGUI.Container)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.fairyBatching=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Container");
		addMember(l,AddChild);
		addMember(l,AddChildAt);
		addMember(l,Contains);
		addMember(l,GetChildAt);
		addMember(l,GetChild);
		addMember(l,GetChildIndex);
		addMember(l,RemoveChild);
		addMember(l,RemoveChildAt);
		addMember(l,RemoveChildren);
		addMember(l,SetChildIndex);
		addMember(l,SwapChildren);
		addMember(l,SwapChildrenAt);
		addMember(l,ChangeChildrenOrder);
		addMember(l,GetBounds);
		addMember(l,GetRenderCamera);
		addMember(l,HitTest);
		addMember(l,GetHitTestLocalPoint);
		addMember(l,IsAncestorOf);
		addMember(l,InvalidateBatchingState);
		addMember(l,SetChildrenLayer);
		addMember(l,Update);
		addMember(l,Dispose);
		addMember(l,"renderMode",get_renderMode,set_renderMode,true);
		addMember(l,"renderCamera",get_renderCamera,set_renderCamera,true);
		addMember(l,"opaque",get_opaque,set_opaque,true);
		addMember(l,"clipSoftness",get_clipSoftness,set_clipSoftness,true);
		addMember(l,"hitArea",get_hitArea,set_hitArea,true);
		addMember(l,"touchChildren",get_touchChildren,set_touchChildren,true);
		addMember(l,"onUpdate",null,set_onUpdate,true);
		addMember(l,"numChildren",get_numChildren,null,true);
		addMember(l,"clipRect",get_clipRect,set_clipRect,true);
		addMember(l,"mask",get_mask,set_mask,true);
		addMember(l,"touchable",get_touchable,set_touchable,true);
		addMember(l,"fairyBatching",get_fairyBatching,set_fairyBatching,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Container),typeof(FairyGUI.DisplayObject));
	}
}
