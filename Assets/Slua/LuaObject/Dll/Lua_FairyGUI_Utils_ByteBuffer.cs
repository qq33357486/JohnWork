using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_Utils_ByteBuffer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer o;
			System.Byte[] a1;
			checkArray(l,2,out a1);
			o=new FairyGUI.Utils.ByteBuffer(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SkipBytes(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.SkipBytes(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadByte(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			var ret=self.ReadByte();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadBytes(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
				System.Byte[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				var ret=self.ReadBytes(ref a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a1);
				return 3;
			}
			else if(argc==5){
				FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
				System.Byte[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				var ret=self.ReadBytes(ref a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a1);
				return 3;
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
	static public int ReadInt(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			var ret=self.ReadInt();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadUint(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			var ret=self.ReadUint();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadFloat(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			var ret=self.ReadFloat();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadLong(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			var ret=self.ReadLong();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadDouble(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			var ret=self.ReadDouble();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadShort(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			var ret=self.ReadShort();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadUshort(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			var ret=self.ReadUshort();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadChar(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			var ret=self.ReadChar();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadBool(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			var ret=self.ReadBool();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadString(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
				var ret=self.ReadString();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.ReadString(a1);
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
	static public int get_endian(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.endian);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_endian(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			FairyGUI.Utils.ByteBuffer.Endian v;
			checkEnum(l,2,out v);
			self.endian=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_length(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.length);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.position=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bytesAvailable(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bytesAvailable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_buffer(IntPtr l) {
		try {
			FairyGUI.Utils.ByteBuffer self=(FairyGUI.Utils.ByteBuffer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.buffer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.Utils.ByteBuffer");
		addMember(l,SkipBytes);
		addMember(l,ReadByte);
		addMember(l,ReadBytes);
		addMember(l,ReadInt);
		addMember(l,ReadUint);
		addMember(l,ReadFloat);
		addMember(l,ReadLong);
		addMember(l,ReadDouble);
		addMember(l,ReadShort);
		addMember(l,ReadUshort);
		addMember(l,ReadChar);
		addMember(l,ReadBool);
		addMember(l,ReadString);
		addMember(l,"endian",get_endian,set_endian,true);
		addMember(l,"length",get_length,null,true);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"bytesAvailable",get_bytesAvailable,null,true);
		addMember(l,"buffer",get_buffer,null,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.Utils.ByteBuffer));
	}
}
