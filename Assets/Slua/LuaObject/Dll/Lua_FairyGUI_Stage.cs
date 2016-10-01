using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Stage : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Stage o;
			o=new FairyGUI.Stage();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTouchPosition(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetTouchPosition(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAllTouch(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			System.Int32[] a1;
			checkArray(l,2,out a1);
			var ret=self.GetAllTouch(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetInputState(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			self.ResetInputState();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CancelClick(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.CancelClick(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EnableSound(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			self.EnableSound();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DisableSound(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			self.DisableSound();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PlayOneShotSound(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
				UnityEngine.AudioClip a1;
				checkType(l,2,out a1);
				self.PlayOneShotSound(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
				UnityEngine.AudioClip a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.PlayOneShotSound(a1,a2);
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
	static public int SetCustomInput(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.RaycastHit),typeof(bool))){
				FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
				UnityEngine.RaycastHit a1;
				checkValueType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.SetCustomInput(ref a1,a2);
				pushValue(l,true);
				pushValue(l,a1);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector2),typeof(bool))){
				FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.SetCustomInput(a1,a2);
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
	static public int SortWorldSpacePanelsByZOrder(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.SortWorldSpacePanelsByZOrder(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MonitorTexture(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			FairyGUI.NTexture a1;
			checkType(l,2,out a1);
			self.MonitorTexture(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Instantiate_s(IntPtr l) {
		try {
			FairyGUI.Stage.Instantiate();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchScreen(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Stage.touchScreen);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stageHeight(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stageHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stageWidth(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stageWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_soundVolume(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.soundVolume);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_soundVolume(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.soundVolume=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onStageResized(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onStageResized);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onCopy(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onCopy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onPaste(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onPaste);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onTouchMove(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onTouchMove);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inst(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Stage.inst);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchTarget(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.touchTarget);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isTouchOnUI(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.Stage.isTouchOnUI);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_focus(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.focus);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_focus(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			FairyGUI.DisplayObject v;
			checkType(l,2,out v);
			self.focus=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchPosition(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.touchPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchCount(IntPtr l) {
		try {
			FairyGUI.Stage self=(FairyGUI.Stage)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.touchCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Stage");
		addMember(l,GetTouchPosition);
		addMember(l,GetAllTouch);
		addMember(l,ResetInputState);
		addMember(l,CancelClick);
		addMember(l,EnableSound);
		addMember(l,DisableSound);
		addMember(l,PlayOneShotSound);
		addMember(l,SetCustomInput);
		addMember(l,SortWorldSpacePanelsByZOrder);
		addMember(l,MonitorTexture);
		addMember(l,Instantiate_s);
		addMember(l,"touchScreen",get_touchScreen,null,false);
		addMember(l,"stageHeight",get_stageHeight,null,true);
		addMember(l,"stageWidth",get_stageWidth,null,true);
		addMember(l,"soundVolume",get_soundVolume,set_soundVolume,true);
		addMember(l,"onStageResized",get_onStageResized,null,true);
		addMember(l,"onCopy",get_onCopy,null,true);
		addMember(l,"onPaste",get_onPaste,null,true);
		addMember(l,"onTouchMove",get_onTouchMove,null,true);
		addMember(l,"inst",get_inst,null,false);
		addMember(l,"touchTarget",get_touchTarget,null,true);
		addMember(l,"isTouchOnUI",get_isTouchOnUI,null,false);
		addMember(l,"focus",get_focus,set_focus,true);
		addMember(l,"touchPosition",get_touchPosition,null,true);
		addMember(l,"touchCount",get_touchCount,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Stage),typeof(FairyGUI.Container));
	}
}
