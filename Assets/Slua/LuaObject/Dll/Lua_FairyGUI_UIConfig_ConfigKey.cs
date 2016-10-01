using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_UIConfig_ConfigKey : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"FairyGUI.UIConfig.ConfigKey");
		addMember(l,0,"DefaultFont");
		addMember(l,1,"ButtonSound");
		addMember(l,2,"ButtonSoundVolumeScale");
		addMember(l,3,"HorizontalScrollBar");
		addMember(l,4,"VerticalScrollBar");
		addMember(l,5,"DefaultScrollSpeed");
		addMember(l,6,"DefaultScrollBarDisplay");
		addMember(l,7,"DefaultScrollTouchEffect");
		addMember(l,8,"DefaultScrollBounceEffect");
		addMember(l,9,"TouchScrollSensitivity");
		addMember(l,10,"WindowModalWaiting");
		addMember(l,11,"GlobalModalWaiting");
		addMember(l,12,"PopupMenu");
		addMember(l,13,"PopupMenu_seperator");
		addMember(l,14,"LoaderErrorSign");
		addMember(l,15,"TooltipsWin");
		addMember(l,16,"DefaultComboBoxVisibleItemCount");
		addMember(l,17,"TouchDragSensitivity");
		addMember(l,18,"ClickDragSensitivity");
		addMember(l,19,"ModalLayerColor");
		addMember(l,20,"RenderingTextBrighterOnDesktop");
		addMember(l,21,"AllowSoftnessOnTopOrLeftSide");
		addMember(l,22,"InputCaretSize");
		addMember(l,23,"InputHighlightColor");
		addMember(l,100,"PleaseSelect");
		LuaDLL.lua_pop(l, 1);
	}
}
