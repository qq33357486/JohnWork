using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_GButton : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.GButton o;
			o=new FairyGUI.GButton();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FireClick(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.FireClick(a1);
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
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
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
	static public int ConstructFromXML(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			FairyGUI.Utils.XML a1;
			checkType(l,2,out a1);
			self.ConstructFromXML(a1);
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
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
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
	static public int get_UP(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.GButton.UP);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DOWN(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.GButton.DOWN);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_OVER(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.GButton.OVER);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_SELECTED_OVER(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.GButton.SELECTED_OVER);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DISABLED(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.GButton.DISABLED);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_SELECTED_DISABLED(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.GButton.SELECTED_DISABLED);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sound(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sound);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sound(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			UnityEngine.AudioClip v;
			checkType(l,2,out v);
			self.sound=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_soundVolumeScale(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.soundVolumeScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_soundVolumeScale(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.soundVolumeScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_changeStateOnClick(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.changeStateOnClick);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_changeStateOnClick(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.changeStateOnClick=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linkedPopup(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.linkedPopup);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_linkedPopup(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			FairyGUI.GObject v;
			checkType(l,2,out v);
			self.linkedPopup=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pageOption(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pageOption);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onChanged(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onChanged);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_icon(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.icon);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_icon(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.icon=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_title(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.title);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_title(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.title=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.text);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.text=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectedIcon(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.selectedIcon);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectedIcon(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.selectedIcon=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectedTitle(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.selectedTitle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectedTitle(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.selectedTitle=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_titleColor(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.titleColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_titleColor(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.titleColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selected(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.selected);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selected(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.selected=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mode(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mode(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			FairyGUI.ButtonMode v;
			checkEnum(l,2,out v);
			self.mode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relatedController(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.relatedController);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_relatedController(IntPtr l) {
		try {
			FairyGUI.GButton self=(FairyGUI.GButton)checkSelf(l);
			FairyGUI.Controller v;
			checkType(l,2,out v);
			self.relatedController=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.GButton");
		addMember(l,FireClick);
		addMember(l,HandleControllerChanged);
		addMember(l,ConstructFromXML);
		addMember(l,Setup_AfterAdd);
		addMember(l,"UP",get_UP,null,false);
		addMember(l,"DOWN",get_DOWN,null,false);
		addMember(l,"OVER",get_OVER,null,false);
		addMember(l,"SELECTED_OVER",get_SELECTED_OVER,null,false);
		addMember(l,"DISABLED",get_DISABLED,null,false);
		addMember(l,"SELECTED_DISABLED",get_SELECTED_DISABLED,null,false);
		addMember(l,"sound",get_sound,set_sound,true);
		addMember(l,"soundVolumeScale",get_soundVolumeScale,set_soundVolumeScale,true);
		addMember(l,"changeStateOnClick",get_changeStateOnClick,set_changeStateOnClick,true);
		addMember(l,"linkedPopup",get_linkedPopup,set_linkedPopup,true);
		addMember(l,"pageOption",get_pageOption,null,true);
		addMember(l,"onChanged",get_onChanged,null,true);
		addMember(l,"icon",get_icon,set_icon,true);
		addMember(l,"title",get_title,set_title,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"selectedIcon",get_selectedIcon,set_selectedIcon,true);
		addMember(l,"selectedTitle",get_selectedTitle,set_selectedTitle,true);
		addMember(l,"titleColor",get_titleColor,set_titleColor,true);
		addMember(l,"selected",get_selected,set_selected,true);
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"relatedController",get_relatedController,set_relatedController,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.GButton),typeof(FairyGUI.GComponent));
	}
}
