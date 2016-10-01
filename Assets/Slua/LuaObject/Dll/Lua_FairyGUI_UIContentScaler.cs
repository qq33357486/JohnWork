using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_UIContentScaler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ApplyModifiedProperties(IntPtr l) {
		try {
			FairyGUI.UIContentScaler self=(FairyGUI.UIContentScaler)checkSelf(l);
			self.ApplyModifiedProperties();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ApplyChange(IntPtr l) {
		try {
			FairyGUI.UIContentScaler self=(FairyGUI.UIContentScaler)checkSelf(l);
			self.ApplyChange();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scaleMode(IntPtr l) {
		try {
			FairyGUI.UIContentScaler self=(FairyGUI.UIContentScaler)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.scaleMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scaleMode(IntPtr l) {
		try {
			FairyGUI.UIContentScaler self=(FairyGUI.UIContentScaler)checkSelf(l);
			FairyGUI.UIContentScaler.ScaleMode v;
			checkEnum(l,2,out v);
			self.scaleMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_screenMatchMode(IntPtr l) {
		try {
			FairyGUI.UIContentScaler self=(FairyGUI.UIContentScaler)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.screenMatchMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_screenMatchMode(IntPtr l) {
		try {
			FairyGUI.UIContentScaler self=(FairyGUI.UIContentScaler)checkSelf(l);
			FairyGUI.UIContentScaler.ScreenMatchMode v;
			checkEnum(l,2,out v);
			self.screenMatchMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_designResolutionX(IntPtr l) {
		try {
			FairyGUI.UIContentScaler self=(FairyGUI.UIContentScaler)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.designResolutionX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_designResolutionX(IntPtr l) {
		try {
			FairyGUI.UIContentScaler self=(FairyGUI.UIContentScaler)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.designResolutionX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_designResolutionY(IntPtr l) {
		try {
			FairyGUI.UIContentScaler self=(FairyGUI.UIContentScaler)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.designResolutionY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_designResolutionY(IntPtr l) {
		try {
			FairyGUI.UIContentScaler self=(FairyGUI.UIContentScaler)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.designResolutionY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scaleFactor(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIContentScaler.scaleFactor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scaleFactor(IntPtr l) {
		try {
			System.Single v;
			checkType(l,2,out v);
			FairyGUI.UIContentScaler.scaleFactor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.UIContentScaler");
		addMember(l,ApplyModifiedProperties);
		addMember(l,ApplyChange);
		addMember(l,"scaleMode",get_scaleMode,set_scaleMode,true);
		addMember(l,"screenMatchMode",get_screenMatchMode,set_screenMatchMode,true);
		addMember(l,"designResolutionX",get_designResolutionX,set_designResolutionX,true);
		addMember(l,"designResolutionY",get_designResolutionY,set_designResolutionY,true);
		addMember(l,"scaleFactor",get_scaleFactor,set_scaleFactor,false);
		createTypeMetatable(l,null, typeof(FairyGUI.UIContentScaler),typeof(UnityEngine.MonoBehaviour));
	}
}
