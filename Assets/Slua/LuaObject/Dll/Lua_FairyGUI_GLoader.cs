using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GLoader : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GLoader o;
			o=new FairyGUI.GLoader();
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			self.Dispose();
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
	static public int get_showErrorSign(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.showErrorSign);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_showErrorSign(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.showErrorSign=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gearAnimation(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gearColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_url(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.url);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_url(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.url=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_align(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.align);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_align(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			FairyGUI.AlignType v;
			checkEnum(l,2,out v);
			self.align=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalAlign(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.verticalAlign);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalAlign(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			FairyGUI.VertAlignType v;
			checkEnum(l,2,out v);
			self.verticalAlign=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fill(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.fill);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fill(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			FairyGUI.FillType v;
			checkEnum(l,2,out v);
			self.fill=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoSize(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoSize(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playing(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
	static public int get_material(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
	static public int get_color(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
	static public int get_fillMethod(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
	static public int get_image(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.image);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_movieClip(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.movieClip);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
	static public int get_filter(IntPtr l) {
		try {
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
			FairyGUI.GLoader self=(FairyGUI.GLoader)checkSelf(l);
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
		getTypeTable(l,"FairyGUI.GLoader");
		addMember(l,Dispose);
		addMember(l,HandleControllerChanged);
		addMember(l,Setup_BeforeAdd);
		addMember(l,Setup_AfterAdd);
		addMember(l,"showErrorSign",get_showErrorSign,set_showErrorSign,true);
		addMember(l,"gearAnimation",get_gearAnimation,null,true);
		addMember(l,"gearColor",get_gearColor,null,true);
		addMember(l,"url",get_url,set_url,true);
		addMember(l,"align",get_align,set_align,true);
		addMember(l,"verticalAlign",get_verticalAlign,set_verticalAlign,true);
		addMember(l,"fill",get_fill,set_fill,true);
		addMember(l,"autoSize",get_autoSize,set_autoSize,true);
		addMember(l,"playing",get_playing,set_playing,true);
		addMember(l,"frame",get_frame,set_frame,true);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"shader",get_shader,set_shader,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"fillMethod",get_fillMethod,set_fillMethod,true);
		addMember(l,"fillOrigin",get_fillOrigin,set_fillOrigin,true);
		addMember(l,"fillClockwise",get_fillClockwise,set_fillClockwise,true);
		addMember(l,"fillAmount",get_fillAmount,set_fillAmount,true);
		addMember(l,"image",get_image,null,true);
		addMember(l,"movieClip",get_movieClip,null,true);
		addMember(l,"texture",get_texture,set_texture,true);
		addMember(l,"filter",get_filter,set_filter,true);
		addMember(l,"blendMode",get_blendMode,set_blendMode,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GLoader),typeof(FairyGUI.GObject));
	}
}
