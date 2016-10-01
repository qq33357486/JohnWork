using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_MovieClip : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.MovieClip o;
			o=new FairyGUI.MovieClip();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetData(IntPtr l) {
		try {
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
			FairyGUI.NTexture a1;
			checkType(l,2,out a1);
			FairyGUI.MovieClip.Frame[] a2;
			checkArray(l,3,out a2);
			UnityEngine.Rect a3;
			checkValueType(l,4,out a3);
			self.SetData(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try {
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
			self.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPlaySettings(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
				self.SetPlaySettings();
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
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
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Update(IntPtr l) {
		try {
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
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
	static public int get_interval(IntPtr l) {
		try {
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
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
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
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
	static public int get_swing(IntPtr l) {
		try {
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
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
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
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
	static public int get_repeatDelay(IntPtr l) {
		try {
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
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
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
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
	static public int get_frameCount(IntPtr l) {
		try {
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frameCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frames(IntPtr l) {
		try {
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frames);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playState(IntPtr l) {
		try {
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.playState);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onPlayEnd(IntPtr l) {
		try {
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onPlayEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playing(IntPtr l) {
		try {
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
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
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
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
	static public int get_currentFrame(IntPtr l) {
		try {
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currentFrame);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_currentFrame(IntPtr l) {
		try {
			FairyGUI.MovieClip self=(FairyGUI.MovieClip)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.currentFrame=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.MovieClip");
		addMember(l,SetData);
		addMember(l,Clear);
		addMember(l,SetPlaySettings);
		addMember(l,Update);
		addMember(l,"interval",get_interval,set_interval,true);
		addMember(l,"swing",get_swing,set_swing,true);
		addMember(l,"repeatDelay",get_repeatDelay,set_repeatDelay,true);
		addMember(l,"frameCount",get_frameCount,null,true);
		addMember(l,"frames",get_frames,null,true);
		addMember(l,"playState",get_playState,null,true);
		addMember(l,"onPlayEnd",get_onPlayEnd,null,true);
		addMember(l,"playing",get_playing,set_playing,true);
		addMember(l,"currentFrame",get_currentFrame,set_currentFrame,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.MovieClip),typeof(FairyGUI.Image));
	}
}
