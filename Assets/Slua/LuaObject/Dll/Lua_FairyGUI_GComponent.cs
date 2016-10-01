using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GComponent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GComponent o;
			o=new FairyGUI.GComponent();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispose(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			self.Dispose();
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
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
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
	static public int AddChild(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			FairyGUI.GObject a1;
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
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			FairyGUI.GObject a1;
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
	static public int RemoveChild(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
				FairyGUI.GObject a1;
				checkType(l,2,out a1);
				var ret=self.RemoveChild(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
				FairyGUI.GObject a1;
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
				FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.RemoveChildAt(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
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
				FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
				self.RemoveChildren();
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
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
	static public int GetChildAt(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
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
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
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
	static public int GetVisibleChild(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetVisibleChild(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetChildInGroup(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			FairyGUI.GGroup a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			var ret=self.GetChildInGroup(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetChildren(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			var ret=self.GetChildren();
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
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			FairyGUI.GObject a1;
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
	static public int SetChildIndex(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			FairyGUI.GObject a1;
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
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			FairyGUI.GObject a2;
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
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
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
	static public int AddController(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			FairyGUI.Controller a1;
			checkType(l,2,out a1);
			self.AddController(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetControllerAt(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetControllerAt(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetController(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetController(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveController(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			FairyGUI.Controller a1;
			checkType(l,2,out a1);
			self.RemoveController(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTransitionAt(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetTransitionAt(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTransition(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetTransition(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsChildInView(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			FairyGUI.GObject a1;
			checkType(l,2,out a1);
			var ret=self.IsChildInView(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetFirstChildInView(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			var ret=self.GetFirstChildInView();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetBoundsChangedFlag(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			self.SetBoundsChangedFlag();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EnsureBoundsCorrect(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			self.EnsureBoundsCorrect();
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
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
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
	static public int ConstructFromXML(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.ConstructFromXML(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rootContainer(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rootContainer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_container(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.container);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollPane(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scrollPane);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDrop(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onDrop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fairyBatching(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
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
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_opaque(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
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
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			bool v;
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
	static public int get_margin(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.margin);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_margin(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			FairyGUI.Margin v;
			checkValueType(l,2,out v);
			self.margin=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_childrenRenderOrder(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.childrenRenderOrder);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_childrenRenderOrder(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			FairyGUI.ChildrenRenderOrder v;
			checkEnum(l,2,out v);
			self.childrenRenderOrder=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_apexIndex(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.apexIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_apexIndex(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.apexIndex=v;
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
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.numChildren);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Controllers(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Controllers);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipSoftness(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
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
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.clipSoftness=v;
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
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
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
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
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
	static public int get_viewWidth(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.viewWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_viewWidth(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.viewWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_viewHeight(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.viewHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_viewHeight(IntPtr l) {
		try {
			FairyGUI.GComponent self=(FairyGUI.GComponent)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.viewHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GComponent");
		addMember(l,Dispose);
		addMember(l,InvalidateBatchingState);
		addMember(l,AddChild);
		addMember(l,AddChildAt);
		addMember(l,RemoveChild);
		addMember(l,RemoveChildAt);
		addMember(l,RemoveChildren);
		addMember(l,GetChildAt);
		addMember(l,GetChild);
		addMember(l,GetVisibleChild);
		addMember(l,GetChildInGroup);
		addMember(l,GetChildren);
		addMember(l,GetChildIndex);
		addMember(l,SetChildIndex);
		addMember(l,SwapChildren);
		addMember(l,SwapChildrenAt);
		addMember(l,AddController);
		addMember(l,GetControllerAt);
		addMember(l,GetController);
		addMember(l,RemoveController);
		addMember(l,GetTransitionAt);
		addMember(l,GetTransition);
		addMember(l,IsChildInView);
		addMember(l,GetFirstChildInView);
		addMember(l,SetBoundsChangedFlag);
		addMember(l,EnsureBoundsCorrect);
		addMember(l,ConstructFromResource);
		addMember(l,ConstructFromXML);
		addMember(l,"rootContainer",get_rootContainer,null,true);
		addMember(l,"container",get_container,null,true);
		addMember(l,"scrollPane",get_scrollPane,null,true);
		addMember(l,"onDrop",get_onDrop,null,true);
		addMember(l,"fairyBatching",get_fairyBatching,set_fairyBatching,true);
		addMember(l,"opaque",get_opaque,set_opaque,true);
		addMember(l,"margin",get_margin,set_margin,true);
		addMember(l,"childrenRenderOrder",get_childrenRenderOrder,set_childrenRenderOrder,true);
		addMember(l,"apexIndex",get_apexIndex,set_apexIndex,true);
		addMember(l,"numChildren",get_numChildren,null,true);
		addMember(l,"Controllers",get_Controllers,null,true);
		addMember(l,"clipSoftness",get_clipSoftness,set_clipSoftness,true);
		addMember(l,"mask",get_mask,set_mask,true);
		addMember(l,"viewWidth",get_viewWidth,set_viewWidth,true);
		addMember(l,"viewHeight",get_viewHeight,set_viewHeight,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GComponent),typeof(FairyGUI.GObject));
	}
}
