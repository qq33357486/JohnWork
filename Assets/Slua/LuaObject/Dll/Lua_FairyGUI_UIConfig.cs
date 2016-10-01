using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_UIConfig : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Load(IntPtr l) {
		try {
			FairyGUI.UIConfig self=(FairyGUI.UIConfig)checkSelf(l);
			self.Load();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ApplyModifiedProperties(IntPtr l) {
		try {
			FairyGUI.UIConfig self=(FairyGUI.UIConfig)checkSelf(l);
			self.ApplyModifiedProperties();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearResourceRefs_s(IntPtr l) {
		try {
			FairyGUI.UIConfig.ClearResourceRefs();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultFont(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.defaultFont);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultFont(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.defaultFont=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderingTextBrighterOnDesktop(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.renderingTextBrighterOnDesktop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderingTextBrighterOnDesktop(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.renderingTextBrighterOnDesktop=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_windowModalWaiting(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.windowModalWaiting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_windowModalWaiting(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.windowModalWaiting=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_globalModalWaiting(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.globalModalWaiting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_globalModalWaiting(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.globalModalWaiting=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modalLayerColor(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.modalLayerColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_modalLayerColor(IntPtr l) {
		try {
			UnityEngine.Color v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.modalLayerColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_buttonSound(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.buttonSound);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_buttonSound(IntPtr l) {
		try {
			UnityEngine.AudioClip v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.buttonSound=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_buttonSoundVolumeScale(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.buttonSoundVolumeScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_buttonSoundVolumeScale(IntPtr l) {
		try {
			System.Single v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.buttonSoundVolumeScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalScrollBar(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.horizontalScrollBar);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalScrollBar(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.horizontalScrollBar=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalScrollBar(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.verticalScrollBar);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalScrollBar(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.verticalScrollBar=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultScrollSpeed(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.defaultScrollSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultScrollSpeed(IntPtr l) {
		try {
			System.Single v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.defaultScrollSpeed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultScrollBarDisplay(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)FairyGUI.UIConfig.defaultScrollBarDisplay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultScrollBarDisplay(IntPtr l) {
		try {
			FairyGUI.ScrollBarDisplayType v;
			checkEnum(l,2,out v);
			FairyGUI.UIConfig.defaultScrollBarDisplay=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultScrollTouchEffect(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.defaultScrollTouchEffect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultScrollTouchEffect(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.defaultScrollTouchEffect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultScrollBounceEffect(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.defaultScrollBounceEffect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultScrollBounceEffect(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.defaultScrollBounceEffect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_popupMenu(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.popupMenu);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_popupMenu(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.popupMenu=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_popupMenu_seperator(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.popupMenu_seperator);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_popupMenu_seperator(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.popupMenu_seperator=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loaderErrorSign(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.loaderErrorSign);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loaderErrorSign(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.loaderErrorSign=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tooltipsWin(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.tooltipsWin);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tooltipsWin(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.tooltipsWin=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultComboBoxVisibleItemCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.defaultComboBoxVisibleItemCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultComboBoxVisibleItemCount(IntPtr l) {
		try {
			System.Int32 v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.defaultComboBoxVisibleItemCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchScrollSensitivity(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.touchScrollSensitivity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_touchScrollSensitivity(IntPtr l) {
		try {
			System.Int32 v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.touchScrollSensitivity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchDragSensitivity(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.touchDragSensitivity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_touchDragSensitivity(IntPtr l) {
		try {
			System.Int32 v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.touchDragSensitivity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clickDragSensitivity(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.clickDragSensitivity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clickDragSensitivity(IntPtr l) {
		try {
			System.Int32 v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.clickDragSensitivity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_allowSoftnessOnTopOrLeftSide(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.allowSoftnessOnTopOrLeftSide);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_allowSoftnessOnTopOrLeftSide(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.allowSoftnessOnTopOrLeftSide=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bringWindowToFrontOnClick(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.bringWindowToFrontOnClick);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bringWindowToFrontOnClick(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.bringWindowToFrontOnClick=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputCaretSize(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.inputCaretSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inputCaretSize(IntPtr l) {
		try {
			System.Int32 v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.inputCaretSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputHighlightColor(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.UIConfig.inputHighlightColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inputHighlightColor(IntPtr l) {
		try {
			UnityEngine.Color v;
			checkType(l,2,out v);
			FairyGUI.UIConfig.inputHighlightColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Items(IntPtr l) {
		try {
			FairyGUI.UIConfig self=(FairyGUI.UIConfig)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Items);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_Items(IntPtr l) {
		try {
			FairyGUI.UIConfig self=(FairyGUI.UIConfig)checkSelf(l);
			System.Collections.Generic.List<FairyGUI.UIConfig.ConfigValue> v;
			checkType(l,2,out v);
			self.Items=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_PreloadPackages(IntPtr l) {
		try {
			FairyGUI.UIConfig self=(FairyGUI.UIConfig)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.PreloadPackages);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_PreloadPackages(IntPtr l) {
		try {
			FairyGUI.UIConfig self=(FairyGUI.UIConfig)checkSelf(l);
			System.Collections.Generic.List<System.String> v;
			checkType(l,2,out v);
			self.PreloadPackages=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.UIConfig");
		addMember(l,Load);
		addMember(l,ApplyModifiedProperties);
		addMember(l,ClearResourceRefs_s);
		addMember(l,"defaultFont",get_defaultFont,set_defaultFont,false);
		addMember(l,"renderingTextBrighterOnDesktop",get_renderingTextBrighterOnDesktop,set_renderingTextBrighterOnDesktop,false);
		addMember(l,"windowModalWaiting",get_windowModalWaiting,set_windowModalWaiting,false);
		addMember(l,"globalModalWaiting",get_globalModalWaiting,set_globalModalWaiting,false);
		addMember(l,"modalLayerColor",get_modalLayerColor,set_modalLayerColor,false);
		addMember(l,"buttonSound",get_buttonSound,set_buttonSound,false);
		addMember(l,"buttonSoundVolumeScale",get_buttonSoundVolumeScale,set_buttonSoundVolumeScale,false);
		addMember(l,"horizontalScrollBar",get_horizontalScrollBar,set_horizontalScrollBar,false);
		addMember(l,"verticalScrollBar",get_verticalScrollBar,set_verticalScrollBar,false);
		addMember(l,"defaultScrollSpeed",get_defaultScrollSpeed,set_defaultScrollSpeed,false);
		addMember(l,"defaultScrollBarDisplay",get_defaultScrollBarDisplay,set_defaultScrollBarDisplay,false);
		addMember(l,"defaultScrollTouchEffect",get_defaultScrollTouchEffect,set_defaultScrollTouchEffect,false);
		addMember(l,"defaultScrollBounceEffect",get_defaultScrollBounceEffect,set_defaultScrollBounceEffect,false);
		addMember(l,"popupMenu",get_popupMenu,set_popupMenu,false);
		addMember(l,"popupMenu_seperator",get_popupMenu_seperator,set_popupMenu_seperator,false);
		addMember(l,"loaderErrorSign",get_loaderErrorSign,set_loaderErrorSign,false);
		addMember(l,"tooltipsWin",get_tooltipsWin,set_tooltipsWin,false);
		addMember(l,"defaultComboBoxVisibleItemCount",get_defaultComboBoxVisibleItemCount,set_defaultComboBoxVisibleItemCount,false);
		addMember(l,"touchScrollSensitivity",get_touchScrollSensitivity,set_touchScrollSensitivity,false);
		addMember(l,"touchDragSensitivity",get_touchDragSensitivity,set_touchDragSensitivity,false);
		addMember(l,"clickDragSensitivity",get_clickDragSensitivity,set_clickDragSensitivity,false);
		addMember(l,"allowSoftnessOnTopOrLeftSide",get_allowSoftnessOnTopOrLeftSide,set_allowSoftnessOnTopOrLeftSide,false);
		addMember(l,"bringWindowToFrontOnClick",get_bringWindowToFrontOnClick,set_bringWindowToFrontOnClick,false);
		addMember(l,"inputCaretSize",get_inputCaretSize,set_inputCaretSize,false);
		addMember(l,"inputHighlightColor",get_inputHighlightColor,set_inputHighlightColor,false);
		addMember(l,"Items",get_Items,set_Items,true);
		addMember(l,"PreloadPackages",get_PreloadPackages,set_PreloadPackages,true);
		createTypeMetatable(l,null, typeof(FairyGUI.UIConfig),typeof(UnityEngine.MonoBehaviour));
	}
}
