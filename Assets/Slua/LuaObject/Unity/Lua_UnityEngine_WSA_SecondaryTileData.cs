using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WSA_SecondaryTileData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData o;
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			o=new UnityEngine.WSA.SecondaryTileData(a1,a2);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_arguments(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.arguments);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_arguments(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.arguments=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_backgroundColorSet(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.backgroundColorSet);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_backgroundColorSet(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.backgroundColorSet=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_displayName(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.displayName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_displayName(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.displayName=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_foregroundText(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.foregroundText);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_foregroundText(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			UnityEngine.WSA.TileForegroundText v;
			checkEnum(l,2,out v);
			self.foregroundText=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lockScreenBadgeLogo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lockScreenBadgeLogo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lockScreenBadgeLogo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.lockScreenBadgeLogo=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lockScreenDisplayBadgeAndTileText(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lockScreenDisplayBadgeAndTileText);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lockScreenDisplayBadgeAndTileText(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.lockScreenDisplayBadgeAndTileText=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_phoneticName(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.phoneticName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_phoneticName(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.phoneticName=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_roamingEnabled(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.roamingEnabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_roamingEnabled(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.roamingEnabled=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_showNameOnSquare150x150Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.showNameOnSquare150x150Logo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_showNameOnSquare150x150Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.showNameOnSquare150x150Logo=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_showNameOnSquare310x310Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.showNameOnSquare310x310Logo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_showNameOnSquare310x310Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.showNameOnSquare310x310Logo=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_showNameOnWide310x150Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.showNameOnWide310x150Logo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_showNameOnWide310x150Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.showNameOnWide310x150Logo=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_square150x150Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.square150x150Logo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_square150x150Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.square150x150Logo=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_square30x30Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.square30x30Logo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_square30x30Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.square30x30Logo=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_square310x310Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.square310x310Logo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_square310x310Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.square310x310Logo=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_square70x70Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.square70x70Logo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_square70x70Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.square70x70Logo=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tileId(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.tileId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tileId(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.tileId=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wide310x150Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.wide310x150Logo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wide310x150Logo(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			System.String v;
			checkType(l,2,out v);
			self.wide310x150Logo=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_backgroundColor(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.backgroundColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_backgroundColor(IntPtr l) {
		try {
			UnityEngine.WSA.SecondaryTileData self;
			checkValueType(l,1,out self);
			UnityEngine.Color32 v;
			checkValueType(l,2,out v);
			self.backgroundColor=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WSA.SecondaryTileData");
		addMember(l,"arguments",get_arguments,set_arguments,true);
		addMember(l,"backgroundColorSet",get_backgroundColorSet,set_backgroundColorSet,true);
		addMember(l,"displayName",get_displayName,set_displayName,true);
		addMember(l,"foregroundText",get_foregroundText,set_foregroundText,true);
		addMember(l,"lockScreenBadgeLogo",get_lockScreenBadgeLogo,set_lockScreenBadgeLogo,true);
		addMember(l,"lockScreenDisplayBadgeAndTileText",get_lockScreenDisplayBadgeAndTileText,set_lockScreenDisplayBadgeAndTileText,true);
		addMember(l,"phoneticName",get_phoneticName,set_phoneticName,true);
		addMember(l,"roamingEnabled",get_roamingEnabled,set_roamingEnabled,true);
		addMember(l,"showNameOnSquare150x150Logo",get_showNameOnSquare150x150Logo,set_showNameOnSquare150x150Logo,true);
		addMember(l,"showNameOnSquare310x310Logo",get_showNameOnSquare310x310Logo,set_showNameOnSquare310x310Logo,true);
		addMember(l,"showNameOnWide310x150Logo",get_showNameOnWide310x150Logo,set_showNameOnWide310x150Logo,true);
		addMember(l,"square150x150Logo",get_square150x150Logo,set_square150x150Logo,true);
		addMember(l,"square30x30Logo",get_square30x30Logo,set_square30x30Logo,true);
		addMember(l,"square310x310Logo",get_square310x310Logo,set_square310x310Logo,true);
		addMember(l,"square70x70Logo",get_square70x70Logo,set_square70x70Logo,true);
		addMember(l,"tileId",get_tileId,set_tileId,true);
		addMember(l,"wide310x150Logo",get_wide310x150Logo,set_wide310x150Logo,true);
		addMember(l,"backgroundColor",get_backgroundColor,set_backgroundColor,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.WSA.SecondaryTileData),typeof(System.ValueType));
	}
}
