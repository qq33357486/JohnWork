using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GImage : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GImage o;
			o=new FairyGUI.GImage();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConstructFromResource(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
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
	static public int HandleControllerChanged(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
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
	static public int Setup_BeforeAdd(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
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
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
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
	static public int get_gearColor(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gearColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.color);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.color=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flip(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.flip);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flip(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			FairyGUI.FlipType v;
			checkEnum(l,2,out v);
			self.flip=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillMethod(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.fillMethod);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillMethod(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			FairyGUI.FillMethod v;
			checkEnum(l,2,out v);
			self.fillMethod=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillOrigin(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fillOrigin);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillOrigin(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.fillOrigin=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillClockwise(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fillClockwise);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillClockwise(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.fillClockwise=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillAmount(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fillAmount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillAmount(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.fillAmount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.texture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_texture(IntPtr l) {
		try {
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
			FairyGUI.NTexture v;
			checkType(l,2,out v);
			self.texture=v;
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
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
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
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
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
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
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
			FairyGUI.GImage self=(FairyGUI.GImage)checkSelf(l);
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
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GImage");
		addMember(l,ConstructFromResource);
		addMember(l,HandleControllerChanged);
		addMember(l,Setup_BeforeAdd);
		addMember(l,Setup_AfterAdd);
		addMember(l,"gearColor",get_gearColor,null,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"flip",get_flip,set_flip,true);
		addMember(l,"fillMethod",get_fillMethod,set_fillMethod,true);
		addMember(l,"fillOrigin",get_fillOrigin,set_fillOrigin,true);
		addMember(l,"fillClockwise",get_fillClockwise,set_fillClockwise,true);
		addMember(l,"fillAmount",get_fillAmount,set_fillAmount,true);
		addMember(l,"texture",get_texture,set_texture,true);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"shader",get_shader,set_shader,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GImage),typeof(FairyGUI.GObject));
	}
}
