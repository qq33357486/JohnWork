using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_TransitionItem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.TransitionItem o;
			o=new FairyGUI.TransitionItem();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int __Shake(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			self.__Shake(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.time);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.time=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetId(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.targetId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetId(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.targetId=v;
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
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
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
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			FairyGUI.TransitionActionType v;
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
	static public int get_duration(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.duration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_duration(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.duration=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.value);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			FairyGUI.TransitionValue v;
			checkType(l,2,out v);
			self.value=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startValue(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startValue(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			FairyGUI.TransitionValue v;
			checkType(l,2,out v);
			self.startValue=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_endValue(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.endValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_endValue(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			FairyGUI.TransitionValue v;
			checkType(l,2,out v);
			self.endValue=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_easeType(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.easeType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_easeType(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			DG.Tweening.Ease v;
			checkEnum(l,2,out v);
			self.easeType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_repeat(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.repeat);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_repeat(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.repeat=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yoyo(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.yoyo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_yoyo(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.yoyo=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tween(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tween);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tween(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.tween=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_label(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.label);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_label(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.label=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_label2(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.label2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_label2(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.label2=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hook(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			FairyGUI.TransitionHook v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.hook=v;
			else if(op==1) self.hook+=v;
			else if(op==2) self.hook-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hook2(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			FairyGUI.TransitionHook v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.hook2=v;
			else if(op==1) self.hook2+=v;
			else if(op==2) self.hook2-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tweener(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tweener);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tweener(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			DG.Tweening.Tween v;
			checkType(l,2,out v);
			self.tweener=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_completed(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.completed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_completed(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.completed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.target);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		try {
			FairyGUI.TransitionItem self=(FairyGUI.TransitionItem)checkSelf(l);
			FairyGUI.GObject v;
			checkType(l,2,out v);
			self.target=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.TransitionItem");
		addMember(l,__Shake);
		addMember(l,"time",get_time,set_time,true);
		addMember(l,"targetId",get_targetId,set_targetId,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"duration",get_duration,set_duration,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"startValue",get_startValue,set_startValue,true);
		addMember(l,"endValue",get_endValue,set_endValue,true);
		addMember(l,"easeType",get_easeType,set_easeType,true);
		addMember(l,"repeat",get_repeat,set_repeat,true);
		addMember(l,"yoyo",get_yoyo,set_yoyo,true);
		addMember(l,"tween",get_tween,set_tween,true);
		addMember(l,"label",get_label,set_label,true);
		addMember(l,"label2",get_label2,set_label2,true);
		addMember(l,"hook",null,set_hook,true);
		addMember(l,"hook2",null,set_hook2,true);
		addMember(l,"tweener",get_tweener,set_tweener,true);
		addMember(l,"completed",get_completed,set_completed,true);
		addMember(l,"target",get_target,set_target,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.TransitionItem));
	}
}
