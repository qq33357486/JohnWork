using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Image : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			FairyGUI.Image o;
			if(argc==1){
				o=new FairyGUI.Image();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				FairyGUI.NTexture a1;
				checkType(l,2,out a1);
				o=new FairyGUI.Image(a1);
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
	static public int SetNativeSize(IntPtr l) {
		try {
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
			self.SetNativeSize();
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
	static public int PrintTo(IntPtr l) {
		try {
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			UnityEngine.Rect a2;
			checkValueType(l,3,out a2);
			self.PrintTo(a1,a2);
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
	static public int get_color(IntPtr l) {
		try {
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
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
	static public int get_scale9Grid(IntPtr l) {
		try {
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scale9Grid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scale9Grid(IntPtr l) {
		try {
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
			Rect v;
			checkValueType(l,2,out v);
			self.scale9Grid=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scaleByTile(IntPtr l) {
		try {
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scaleByTile);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scaleByTile(IntPtr l) {
		try {
			FairyGUI.Image self=(FairyGUI.Image)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.scaleByTile=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Image");
		addMember(l,SetNativeSize);
		addMember(l,Update);
		addMember(l,PrintTo);
		addMember(l,"texture",get_texture,set_texture,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"flip",get_flip,set_flip,true);
		addMember(l,"fillMethod",get_fillMethod,set_fillMethod,true);
		addMember(l,"fillOrigin",get_fillOrigin,set_fillOrigin,true);
		addMember(l,"fillClockwise",get_fillClockwise,set_fillClockwise,true);
		addMember(l,"fillAmount",get_fillAmount,set_fillAmount,true);
		addMember(l,"scale9Grid",get_scale9Grid,set_scale9Grid,true);
		addMember(l,"scaleByTile",get_scaleByTile,set_scaleByTile,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Image),typeof(FairyGUI.DisplayObject));
	}
}
