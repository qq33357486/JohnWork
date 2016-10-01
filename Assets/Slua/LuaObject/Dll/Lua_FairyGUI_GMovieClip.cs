using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GMovieClip : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GMovieClip o;
			o=new FairyGUI.GMovieClip();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPlaySettings(IntPtr l) {
		try {
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetPlaySettings(a1,a2,a3,a4);
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
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
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
	static public int ConstructFromResource(IntPtr l) {
		try {
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
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
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
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
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
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
	static public int get_onPlayEnd(IntPtr l) {
		try {
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onPlayEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gearAnimation(IntPtr l) {
		try {
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gearAnimation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gearColor(IntPtr l) {
		try {
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gearColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playing(IntPtr l) {
		try {
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.playing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playing(IntPtr l) {
		try {
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.playing=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frame(IntPtr l) {
		try {
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frame);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frame(IntPtr l) {
		try {
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.frame=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		try {
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
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
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
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
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
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
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
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
	static public int get_material(IntPtr l) {
		try {
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
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
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
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
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
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
			FairyGUI.GMovieClip self=(FairyGUI.GMovieClip)checkSelf(l);
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
		getTypeTable(l,"FairyGUI.GMovieClip");
		addMember(l,SetPlaySettings);
		addMember(l,HandleControllerChanged);
		addMember(l,ConstructFromResource);
		addMember(l,Setup_BeforeAdd);
		addMember(l,Setup_AfterAdd);
		addMember(l,"onPlayEnd",get_onPlayEnd,null,true);
		addMember(l,"gearAnimation",get_gearAnimation,null,true);
		addMember(l,"gearColor",get_gearColor,null,true);
		addMember(l,"playing",get_playing,set_playing,true);
		addMember(l,"frame",get_frame,set_frame,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"flip",get_flip,set_flip,true);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"shader",get_shader,set_shader,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GMovieClip),typeof(FairyGUI.GObject));
	}
}
