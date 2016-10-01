using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_TextField : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.TextField o;
			o=new FairyGUI.TextField();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBounds(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			FairyGUI.DisplayObject a1;
			checkType(l,2,out a1);
			var ret=self.GetBounds(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReplaceSelection(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.ReplaceSelection(a1);
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
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
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
	static public int GetHtmlElements(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			var ret=self.GetHtmlElements();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onFocusIn(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onFocusIn);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onFocusOut(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onFocusOut);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onChanged(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onChanged);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_richTextField(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.richTextField);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textFormat(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textFormat);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textFormat(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			FairyGUI.TextFormat v;
			checkType(l,2,out v);
			self.textFormat=v;
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
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
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
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
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
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
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
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
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
	static public int get_input(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.input);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_input(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.input=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyboardType(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.keyboardType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyboardType(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.keyboardType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_restrict(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.restrict);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_restrict(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.restrict=v;
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
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
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
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
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
	static public int get_htmlText(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.htmlText);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_htmlText(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.htmlText=v;
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
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
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
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
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
	static public int get_wordWrap(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.wordWrap);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wordWrap(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.wordWrap=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_singleLine(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.singleLine);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_singleLine(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.singleLine=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_displayAsPassword(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.displayAsPassword);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_displayAsPassword(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.displayAsPassword=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxLength(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxLength(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.maxLength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stroke(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stroke);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stroke(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.stroke=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_strokeColor(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.strokeColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_strokeColor(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.strokeColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowOffset(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shadowOffset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowOffset(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.shadowOffset=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textWidth(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textHeight(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_caretPosition(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.caretPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_caretPosition(IntPtr l) {
		try {
			FairyGUI.TextField self=(FairyGUI.TextField)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.caretPosition=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.TextField");
		addMember(l,GetBounds);
		addMember(l,ReplaceSelection);
		addMember(l,Update);
		addMember(l,GetHtmlElements);
		addMember(l,"onFocusIn",get_onFocusIn,null,true);
		addMember(l,"onFocusOut",get_onFocusOut,null,true);
		addMember(l,"onChanged",get_onChanged,null,true);
		addMember(l,"richTextField",get_richTextField,null,true);
		addMember(l,"textFormat",get_textFormat,set_textFormat,true);
		addMember(l,"align",get_align,set_align,true);
		addMember(l,"verticalAlign",get_verticalAlign,set_verticalAlign,true);
		addMember(l,"input",get_input,set_input,true);
		addMember(l,"keyboardType",get_keyboardType,set_keyboardType,true);
		addMember(l,"restrict",get_restrict,set_restrict,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"htmlText",get_htmlText,set_htmlText,true);
		addMember(l,"autoSize",get_autoSize,set_autoSize,true);
		addMember(l,"wordWrap",get_wordWrap,set_wordWrap,true);
		addMember(l,"singleLine",get_singleLine,set_singleLine,true);
		addMember(l,"displayAsPassword",get_displayAsPassword,set_displayAsPassword,true);
		addMember(l,"maxLength",get_maxLength,set_maxLength,true);
		addMember(l,"stroke",get_stroke,set_stroke,true);
		addMember(l,"strokeColor",get_strokeColor,set_strokeColor,true);
		addMember(l,"shadowOffset",get_shadowOffset,set_shadowOffset,true);
		addMember(l,"textWidth",get_textWidth,null,true);
		addMember(l,"textHeight",get_textHeight,null,true);
		addMember(l,"caretPosition",get_caretPosition,set_caretPosition,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.TextField),typeof(FairyGUI.DisplayObject));
	}
}
