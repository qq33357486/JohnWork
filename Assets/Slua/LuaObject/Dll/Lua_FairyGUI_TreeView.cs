using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_TreeView : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.TreeView o;
			FairyGUI.GList a1;
			checkType(l,2,out a1);
			o=new FairyGUI.TreeView(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSelectedNode(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			var ret=self.GetSelectedNode();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSelection(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			var ret=self.GetSelection();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddSelection(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			FairyGUI.TreeNode a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.AddSelection(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveSelection(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			FairyGUI.TreeNode a1;
			checkType(l,2,out a1);
			self.RemoveSelection(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearSelection(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			self.ClearSelection();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNodeIndex(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			FairyGUI.TreeNode a1;
			checkType(l,2,out a1);
			var ret=self.GetNodeIndex(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateNode(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			FairyGUI.TreeNode a1;
			checkType(l,2,out a1);
			self.UpdateNode(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateNodes(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			System.Collections.Generic.List<FairyGUI.TreeNode> a1;
			checkType(l,2,out a1);
			self.UpdateNodes(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ExpandAll(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			FairyGUI.TreeNode a1;
			checkType(l,2,out a1);
			self.ExpandAll(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CollapseAll(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			FairyGUI.TreeNode a1;
			checkType(l,2,out a1);
			self.CollapseAll(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_indent(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.indent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_indent(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.indent=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_treeNodeCreateCell(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			FairyGUI.TreeView.TreeNodeCreateCellDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.treeNodeCreateCell=v;
			else if(op==1) self.treeNodeCreateCell+=v;
			else if(op==2) self.treeNodeCreateCell-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_treeNodeRender(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			FairyGUI.TreeView.TreeNodeRenderDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.treeNodeRender=v;
			else if(op==1) self.treeNodeRender+=v;
			else if(op==2) self.treeNodeRender-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_treeNodeWillExpand(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			FairyGUI.TreeView.TreeNodeWillExpandDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.treeNodeWillExpand=v;
			else if(op==1) self.treeNodeWillExpand+=v;
			else if(op==2) self.treeNodeWillExpand-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_list(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.list);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_root(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.root);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onClickNode(IntPtr l) {
		try {
			FairyGUI.TreeView self=(FairyGUI.TreeView)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onClickNode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.TreeView");
		addMember(l,GetSelectedNode);
		addMember(l,GetSelection);
		addMember(l,AddSelection);
		addMember(l,RemoveSelection);
		addMember(l,ClearSelection);
		addMember(l,GetNodeIndex);
		addMember(l,UpdateNode);
		addMember(l,UpdateNodes);
		addMember(l,ExpandAll);
		addMember(l,CollapseAll);
		addMember(l,"indent",get_indent,set_indent,true);
		addMember(l,"treeNodeCreateCell",null,set_treeNodeCreateCell,true);
		addMember(l,"treeNodeRender",null,set_treeNodeRender,true);
		addMember(l,"treeNodeWillExpand",null,set_treeNodeWillExpand,true);
		addMember(l,"list",get_list,null,true);
		addMember(l,"root",get_root,null,true);
		addMember(l,"onClickNode",get_onClickNode,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.TreeView),typeof(FairyGUI.EventDispatcher));
	}
}
