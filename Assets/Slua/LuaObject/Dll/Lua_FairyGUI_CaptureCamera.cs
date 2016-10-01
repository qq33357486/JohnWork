using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_CaptureCamera : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CheckMain_s(IntPtr l) {
		try {
			FairyGUI.CaptureCamera.CheckMain();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateRenderTexture_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			var ret=FairyGUI.CaptureCamera.CreateRenderTexture(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Capture_s(IntPtr l) {
		try {
			FairyGUI.DisplayObject a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			FairyGUI.CaptureCamera.Capture(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Name(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.CaptureCamera.Name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_LayerName(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.CaptureCamera.LayerName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_HiddenLayerName(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.CaptureCamera.HiddenLayerName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedTransform(IntPtr l) {
		try {
			FairyGUI.CaptureCamera self=(FairyGUI.CaptureCamera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cachedTransform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cachedTransform(IntPtr l) {
		try {
			FairyGUI.CaptureCamera self=(FairyGUI.CaptureCamera)checkSelf(l);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.cachedTransform=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedCamera(IntPtr l) {
		try {
			FairyGUI.CaptureCamera self=(FairyGUI.CaptureCamera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cachedCamera);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cachedCamera(IntPtr l) {
		try {
			FairyGUI.CaptureCamera self=(FairyGUI.CaptureCamera)checkSelf(l);
			UnityEngine.Camera v;
			checkType(l,2,out v);
			self.cachedCamera=v;
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
			pushValue(l,true);
			pushValue(l,FairyGUI.CaptureCamera.layer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hiddenLayer(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.CaptureCamera.hiddenLayer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.CaptureCamera");
		addMember(l,CheckMain_s);
		addMember(l,CreateRenderTexture_s);
		addMember(l,Capture_s);
		addMember(l,"Name",get_Name,null,false);
		addMember(l,"LayerName",get_LayerName,null,false);
		addMember(l,"HiddenLayerName",get_HiddenLayerName,null,false);
		addMember(l,"cachedTransform",get_cachedTransform,set_cachedTransform,true);
		addMember(l,"cachedCamera",get_cachedCamera,set_cachedCamera,true);
		addMember(l,"layer",get_layer,null,false);
		addMember(l,"hiddenLayer",get_hiddenLayer,null,false);
		createTypeMetatable(l,null, typeof(FairyGUI.CaptureCamera),typeof(UnityEngine.MonoBehaviour));
	}
}
