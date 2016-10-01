using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WSA_Toast : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Show(IntPtr l) {
		try {
			UnityEngine.WSA.Toast self=(UnityEngine.WSA.Toast)checkSelf(l);
			self.Show();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Hide(IntPtr l) {
		try {
			UnityEngine.WSA.Toast self=(UnityEngine.WSA.Toast)checkSelf(l);
			self.Hide();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTemplate_s(IntPtr l) {
		try {
			UnityEngine.WSA.ToastTemplate a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.WSA.Toast.GetTemplate(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Create_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.WSA.Toast.Create(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.WSA.Toast.Create(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
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
	static public int get_arguments(IntPtr l) {
		try {
			UnityEngine.WSA.Toast self=(UnityEngine.WSA.Toast)checkSelf(l);
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
			UnityEngine.WSA.Toast self=(UnityEngine.WSA.Toast)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.arguments=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activated(IntPtr l) {
		try {
			UnityEngine.WSA.Toast self=(UnityEngine.WSA.Toast)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.activated);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dismissed(IntPtr l) {
		try {
			UnityEngine.WSA.Toast self=(UnityEngine.WSA.Toast)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dismissed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dismissedByUser(IntPtr l) {
		try {
			UnityEngine.WSA.Toast self=(UnityEngine.WSA.Toast)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dismissedByUser);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WSA.Toast");
		addMember(l,Show);
		addMember(l,Hide);
		addMember(l,GetTemplate_s);
		addMember(l,Create_s);
		addMember(l,"arguments",get_arguments,set_arguments,true);
		addMember(l,"activated",get_activated,null,true);
		addMember(l,"dismissed",get_dismissed,null,true);
		addMember(l,"dismissedByUser",get_dismissedByUser,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.WSA.Toast));
	}
}
