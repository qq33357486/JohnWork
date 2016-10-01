using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_UpdateContext : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.UpdateContext o;
			o=new FairyGUI.UpdateContext();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Begin(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			self.Begin();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int End(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			self.End();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EnterClipping(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			System.UInt32 a1;
			checkType(l,2,out a1);
			System.Nullable<UnityEngine.Rect> a2;
			checkNullable(l,3,out a2);
			System.Nullable<UnityEngine.Vector4> a3;
			checkNullable(l,4,out a3);
			self.EnterClipping(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LeaveClipping(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			self.LeaveClipping();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipped(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clipped);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipped(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.clipped=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipInfo(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clipInfo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipInfo(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			FairyGUI.UpdateContext.ClipInfo v;
			checkValueType(l,2,out v);
			self.clipInfo=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_counter(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.counter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_counter(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.counter=v;
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
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
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
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			System.Int32 v;
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
	static public int get_batchingDepth(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.batchingDepth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_batchingDepth(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.batchingDepth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rectMaskDepth(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rectMaskDepth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rectMaskDepth(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.rectMaskDepth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stencilReferenceValue(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stencilReferenceValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stencilReferenceValue(IntPtr l) {
		try {
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.stencilReferenceValue=v;
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
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
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
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			System.Single v;
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
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
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
			FairyGUI.UpdateContext self=(FairyGUI.UpdateContext)checkSelf(l);
			System.Boolean v;
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
	static public int get_frameId(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UpdateContext.frameId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frameId(IntPtr l) {
		try {
			System.UInt32 v;
			checkType(l,2,out v);
			FairyGUI.UpdateContext.frameId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_OnBegin(IntPtr l) {
		try {
			FairyGUI.EventCallback0 v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) FairyGUI.UpdateContext.OnBegin=v;
			else if(op==1) FairyGUI.UpdateContext.OnBegin+=v;
			else if(op==2) FairyGUI.UpdateContext.OnBegin-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_OnEnd(IntPtr l) {
		try {
			FairyGUI.EventCallback0 v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) FairyGUI.UpdateContext.OnEnd=v;
			else if(op==1) FairyGUI.UpdateContext.OnEnd+=v;
			else if(op==2) FairyGUI.UpdateContext.OnEnd-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.UpdateContext");
		addMember(l,Begin);
		addMember(l,End);
		addMember(l,EnterClipping);
		addMember(l,LeaveClipping);
		addMember(l,"clipped",get_clipped,set_clipped,true);
		addMember(l,"clipInfo",get_clipInfo,set_clipInfo,true);
		addMember(l,"counter",get_counter,set_counter,true);
		addMember(l,"renderingOrder",get_renderingOrder,set_renderingOrder,true);
		addMember(l,"batchingDepth",get_batchingDepth,set_batchingDepth,true);
		addMember(l,"rectMaskDepth",get_rectMaskDepth,set_rectMaskDepth,true);
		addMember(l,"stencilReferenceValue",get_stencilReferenceValue,set_stencilReferenceValue,true);
		addMember(l,"alpha",get_alpha,set_alpha,true);
		addMember(l,"grayed",get_grayed,set_grayed,true);
		addMember(l,"frameId",get_frameId,set_frameId,false);
		addMember(l,"OnBegin",null,set_OnBegin,false);
		addMember(l,"OnEnd",null,set_OnEnd,false);
		createTypeMetatable(l,constructor, typeof(FairyGUI.UpdateContext));
	}
}
