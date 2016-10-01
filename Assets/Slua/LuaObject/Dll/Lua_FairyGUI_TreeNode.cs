using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_TreeNode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.TreeNode o;
			System.Boolean a1;
			checkType(l,2,out a1);
			o=new FairyGUI.TreeNode(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddChild(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			FairyGUI.TreeNode a1;
			checkType(l,2,out a1);
			var ret=self.AddChild(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddChildAt(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			FairyGUI.TreeNode a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.AddChildAt(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveChild(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			FairyGUI.TreeNode a1;
			checkType(l,2,out a1);
			var ret=self.RemoveChild(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveChildAt(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.RemoveChildAt(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveChildren(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.RemoveChildren(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetChildAt(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetChildAt(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetChildIndex(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			FairyGUI.TreeNode a1;
			checkType(l,2,out a1);
			var ret=self.GetChildIndex(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPrevSibling(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			var ret=self.GetPrevSibling();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNextSibling(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			var ret=self.GetNextSibling();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetChildIndex(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			FairyGUI.TreeNode a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetChildIndex(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SwapChildren(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			FairyGUI.TreeNode a1;
			checkType(l,2,out a1);
			FairyGUI.TreeNode a2;
			checkType(l,3,out a2);
			self.SwapChildren(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SwapChildrenAt(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SwapChildrenAt(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_data(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.data);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_data(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			System.Object v;
			checkType(l,2,out v);
			self.data=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_parent(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.parent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tree(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tree);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cell(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cell);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_level(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.level);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_expanded(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.expanded);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_expanded(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.expanded=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isFolder(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isFolder);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.text);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_numChildren(IntPtr l) {
		try {
			FairyGUI.TreeNode self=(FairyGUI.TreeNode)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.numChildren);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.TreeNode");
		addMember(l,AddChild);
		addMember(l,AddChildAt);
		addMember(l,RemoveChild);
		addMember(l,RemoveChildAt);
		addMember(l,RemoveChildren);
		addMember(l,GetChildAt);
		addMember(l,GetChildIndex);
		addMember(l,GetPrevSibling);
		addMember(l,GetNextSibling);
		addMember(l,SetChildIndex);
		addMember(l,SwapChildren);
		addMember(l,SwapChildrenAt);
		addMember(l,"data",get_data,set_data,true);
		addMember(l,"parent",get_parent,null,true);
		addMember(l,"tree",get_tree,null,true);
		addMember(l,"cell",get_cell,null,true);
		addMember(l,"level",get_level,null,true);
		addMember(l,"expanded",get_expanded,set_expanded,true);
		addMember(l,"isFolder",get_isFolder,null,true);
		addMember(l,"text",get_text,null,true);
		addMember(l,"numChildren",get_numChildren,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.TreeNode));
	}
}
