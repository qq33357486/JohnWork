using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_DisplayObject : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.DisplayObject o;
			o=new FairyGUI.DisplayObject();
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int SetSize(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetSize(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetScale(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int EnterPaintingMode(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Nullable<FairyGUI.Margin> a2;
			checkNullable(l,3,out a2);
			self.EnterPaintingMode(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LeavePaintingMode(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.LeavePaintingMode(a1);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int GlobalToLocal(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			var ret=self.GlobalToLocal(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LocalToGlobal(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			var ret=self.LocalToGlobal(a1);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			var ret=self.WorldToLocal(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TransformPoint(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			FairyGUI.DisplayObject a2;
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			FairyGUI.DisplayObject a2;
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
	static public int RemoveFromParent(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			self.RemoveFromParent();
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			self.InvalidateBatchingState();
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int set_onPaint(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			FairyGUI.EventCallback0 v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onPaint=v;
			else if(op==1) self.onPaint+=v;
			else if(op==2) self.onPaint-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gOwner(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gOwner);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gOwner(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			FairyGUI.GObject v;
			checkType(l,2,out v);
			self.gOwner=v;
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.id);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_id(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			System.UInt32 v;
			checkType(l,2,out v);
			self.id=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_parent(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.parent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gameObject);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedTransform(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cachedTransform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphics(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.graphics);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_paintingGraphics(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.paintingGraphics);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onClick(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onRollOut);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onMouseWheel(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onMouseWheel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onAddedToStage(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onClickLink);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alpha(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int get_grayed(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int get_visible(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int get_x(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int get_width(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int get_scaleX(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int get_rotation(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int get_skew(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int get_perspective(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.perspective);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_perspective(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.perspective=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_focalLength(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.focalLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_focalLength(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.focalLength=v;
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int get_location(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.location);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_location(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.location=v;
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shader(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shader(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.shader=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderingOrder(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.renderingOrder);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderingOrder(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.renderingOrder=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layer(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.layer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layer(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.layer=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDisposed(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isDisposed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_topmost(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.topmost);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stage(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldSpaceContainer(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.worldSpaceContainer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchable(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public int get_paintingMode(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.paintingMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_filter(IntPtr l) {
		try {
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
			FairyGUI.DisplayObject self=(FairyGUI.DisplayObject)checkSelf(l);
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
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.DisplayObject");
		addMember(l,SetXY);
		addMember(l,SetPosition);
		addMember(l,SetSize);
		addMember(l,SetScale);
		addMember(l,EnterPaintingMode);
		addMember(l,LeavePaintingMode);
		addMember(l,GetBounds);
		addMember(l,GlobalToLocal);
		addMember(l,LocalToGlobal);
		addMember(l,WorldToLocal);
		addMember(l,TransformPoint);
		addMember(l,TransformRect);
		addMember(l,RemoveFromParent);
		addMember(l,InvalidateBatchingState);
		addMember(l,Update);
		addMember(l,Dispose);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"onPaint",null,set_onPaint,true);
		addMember(l,"gOwner",get_gOwner,set_gOwner,true);
		addMember(l,"id",get_id,set_id,true);
		addMember(l,"parent",get_parent,null,true);
		addMember(l,"gameObject",get_gameObject,null,true);
		addMember(l,"cachedTransform",get_cachedTransform,null,true);
		addMember(l,"graphics",get_graphics,null,true);
		addMember(l,"paintingGraphics",get_paintingGraphics,null,true);
		addMember(l,"onClick",get_onClick,null,true);
		addMember(l,"onRightClick",get_onRightClick,null,true);
		addMember(l,"onTouchBegin",get_onTouchBegin,null,true);
		addMember(l,"onTouchEnd",get_onTouchEnd,null,true);
		addMember(l,"onRollOver",get_onRollOver,null,true);
		addMember(l,"onRollOut",get_onRollOut,null,true);
		addMember(l,"onMouseWheel",get_onMouseWheel,null,true);
		addMember(l,"onAddedToStage",get_onAddedToStage,null,true);
		addMember(l,"onRemovedFromStage",get_onRemovedFromStage,null,true);
		addMember(l,"onKeyDown",get_onKeyDown,null,true);
		addMember(l,"onClickLink",get_onClickLink,null,true);
		addMember(l,"alpha",get_alpha,set_alpha,true);
		addMember(l,"grayed",get_grayed,set_grayed,true);
		addMember(l,"visible",get_visible,set_visible,true);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"z",get_z,set_z,true);
		addMember(l,"xy",get_xy,set_xy,true);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"scaleX",get_scaleX,set_scaleX,true);
		addMember(l,"scaleY",get_scaleY,set_scaleY,true);
		addMember(l,"scale",get_scale,set_scale,true);
		addMember(l,"rotation",get_rotation,set_rotation,true);
		addMember(l,"rotationX",get_rotationX,set_rotationX,true);
		addMember(l,"rotationY",get_rotationY,set_rotationY,true);
		addMember(l,"skew",get_skew,set_skew,true);
		addMember(l,"perspective",get_perspective,set_perspective,true);
		addMember(l,"focalLength",get_focalLength,set_focalLength,true);
		addMember(l,"pivot",get_pivot,set_pivot,true);
		addMember(l,"location",get_location,set_location,true);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"shader",get_shader,set_shader,true);
		addMember(l,"renderingOrder",get_renderingOrder,set_renderingOrder,true);
		addMember(l,"layer",get_layer,set_layer,true);
		addMember(l,"isDisposed",get_isDisposed,null,true);
		addMember(l,"topmost",get_topmost,null,true);
		addMember(l,"stage",get_stage,null,true);
		addMember(l,"worldSpaceContainer",get_worldSpaceContainer,null,true);
		addMember(l,"touchable",get_touchable,set_touchable,true);
		addMember(l,"paintingMode",get_paintingMode,null,true);
		addMember(l,"filter",get_filter,set_filter,true);
		addMember(l,"blendMode",get_blendMode,set_blendMode,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.DisplayObject),typeof(FairyGUI.EventDispatcher));
	}
}
