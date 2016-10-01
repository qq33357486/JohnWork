using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_StageCamera : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ApplyModifiedProperties(IntPtr l) {
		try {
			FairyGUI.StageCamera self=(FairyGUI.StageCamera)checkSelf(l);
			self.ApplyModifiedProperties();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CheckMainCamera_s(IntPtr l) {
		try {
			FairyGUI.StageCamera.CheckMainCamera();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CheckCaptureCamera_s(IntPtr l) {
		try {
			FairyGUI.StageCamera.CheckCaptureCamera();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateCamera_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=FairyGUI.StageCamera.CreateCamera(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Name(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.StageCamera.Name);
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
			pushValue(l,FairyGUI.StageCamera.LayerName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_constantSize(IntPtr l) {
		try {
			FairyGUI.StageCamera self=(FairyGUI.StageCamera)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.constantSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_constantSize(IntPtr l) {
		try {
			FairyGUI.StageCamera self=(FairyGUI.StageCamera)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.constantSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedTransform(IntPtr l) {
		try {
			FairyGUI.StageCamera self=(FairyGUI.StageCamera)checkSelf(l);
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
			FairyGUI.StageCamera self=(FairyGUI.StageCamera)checkSelf(l);
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
			FairyGUI.StageCamera self=(FairyGUI.StageCamera)checkSelf(l);
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
			FairyGUI.StageCamera self=(FairyGUI.StageCamera)checkSelf(l);
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
	static public int get_main(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.StageCamera.main);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_main(IntPtr l) {
		try {
			UnityEngine.Camera v;
			checkType(l,2,out v);
			FairyGUI.StageCamera.main=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_screenSizeVer(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.StageCamera.screenSizeVer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_screenSizeVer(IntPtr l) {
		try {
			System.Int32 v;
			checkType(l,2,out v);
			FairyGUI.StageCamera.screenSizeVer=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DefaultCameraSize(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.StageCamera.DefaultCameraSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_DefaultCameraSize(IntPtr l) {
		try {
			System.Single v;
			checkType(l,2,out v);
			FairyGUI.StageCamera.DefaultCameraSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_UnitsPerPixel(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.StageCamera.UnitsPerPixel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_UnitsPerPixel(IntPtr l) {
		try {
			System.Single v;
			checkType(l,2,out v);
			FairyGUI.StageCamera.UnitsPerPixel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.StageCamera");
		addMember(l,ApplyModifiedProperties);
		addMember(l,CheckMainCamera_s);
		addMember(l,CheckCaptureCamera_s);
		addMember(l,CreateCamera_s);
		addMember(l,"Name",get_Name,null,false);
		addMember(l,"LayerName",get_LayerName,null,false);
		addMember(l,"constantSize",get_constantSize,set_constantSize,true);
		addMember(l,"cachedTransform",get_cachedTransform,set_cachedTransform,true);
		addMember(l,"cachedCamera",get_cachedCamera,set_cachedCamera,true);
		addMember(l,"main",get_main,set_main,false);
		addMember(l,"screenSizeVer",get_screenSizeVer,set_screenSizeVer,false);
		addMember(l,"DefaultCameraSize",get_DefaultCameraSize,set_DefaultCameraSize,false);
		addMember(l,"UnitsPerPixel",get_UnitsPerPixel,set_UnitsPerPixel,false);
		createTypeMetatable(l,null, typeof(FairyGUI.StageCamera),typeof(UnityEngine.MonoBehaviour));
	}
}
