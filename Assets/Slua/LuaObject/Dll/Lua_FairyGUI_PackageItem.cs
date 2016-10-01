using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_PackageItem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.PackageItem o;
			o=new FairyGUI.PackageItem();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Load(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			var ret=self.Load();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_owner(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.owner);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_owner(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			FairyGUI.UIPackage v;
			checkType(l,2,out v);
			self.owner=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			FairyGUI.PackageItemType v;
			checkEnum(l,2,out v);
			self.type=v;
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
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
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
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			System.String v;
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
	static public int get_name(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
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
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
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
	static public int get_width(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
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
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			System.Int32 v;
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
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
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
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			System.Int32 v;
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
	static public int get_file(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.file);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_file(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.file=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_decoded(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.decoded);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_decoded(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.decoded=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_exported(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.exported);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_exported(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.exported=v;
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
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
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
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
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
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
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
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.scaleByTile=v;
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
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
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
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
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
	static public int get_interval(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.interval);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_interval(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.interval=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_repeatDelay(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.repeatDelay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_repeatDelay(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.repeatDelay=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_swing(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.swing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_swing(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.swing=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frames(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frames);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frames(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			FairyGUI.MovieClip.Frame[] v;
			checkArray(l,2,out v);
			self.frames=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_componentData(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.componentData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_componentData(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			FairyGUI.Utils.XML v;
			checkType(l,2,out v);
			self.componentData=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bitmapFont(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bitmapFont);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bitmapFont(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			FairyGUI.BitmapFont v;
			checkType(l,2,out v);
			self.bitmapFont=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_audioClip(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.audioClip);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_audioClip(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			UnityEngine.AudioClip v;
			checkType(l,2,out v);
			self.audioClip=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_binary(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.binary);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_binary(IntPtr l) {
		try {
			FairyGUI.PackageItem self=(FairyGUI.PackageItem)checkSelf(l);
			System.Byte[] v;
			checkArray(l,2,out v);
			self.binary=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.PackageItem");
		addMember(l,Load);
		addMember(l,"owner",get_owner,set_owner,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"id",get_id,set_id,true);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"file",get_file,set_file,true);
		addMember(l,"decoded",get_decoded,set_decoded,true);
		addMember(l,"exported",get_exported,set_exported,true);
		addMember(l,"scale9Grid",get_scale9Grid,set_scale9Grid,true);
		addMember(l,"scaleByTile",get_scaleByTile,set_scaleByTile,true);
		addMember(l,"texture",get_texture,set_texture,true);
		addMember(l,"interval",get_interval,set_interval,true);
		addMember(l,"repeatDelay",get_repeatDelay,set_repeatDelay,true);
		addMember(l,"swing",get_swing,set_swing,true);
		addMember(l,"frames",get_frames,set_frames,true);
		addMember(l,"componentData",get_componentData,set_componentData,true);
		addMember(l,"bitmapFont",get_bitmapFont,set_bitmapFont,true);
		addMember(l,"audioClip",get_audioClip,set_audioClip,true);
		addMember(l,"binary",get_binary,set_binary,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.PackageItem));
	}
}
