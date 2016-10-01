using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_FairyGUI_NGraphics : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			FairyGUI.NGraphics o;
			UnityEngine.GameObject a1;
			checkType(l,2,out a1);
			o=new FairyGUI.NGraphics(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetShaderAndTexture(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			FairyGUI.NTexture a2;
			checkType(l,3,out a2);
			self.SetShaderAndTexture(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetStencilEraserOrder(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.SetStencilEraserOrder(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispose(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateMaterial(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			FairyGUI.UpdateContext a1;
			checkType(l,2,out a1);
			self.UpdateMaterial(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Alloc(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.Alloc(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateMesh(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			self.UpdateMesh();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetOneQuadMesh(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			UnityEngine.Rect a2;
			checkValueType(l,3,out a2);
			UnityEngine.Color a3;
			checkType(l,4,out a3);
			self.SetOneQuadMesh(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawRect(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Color a3;
			checkType(l,4,out a3);
			UnityEngine.Color a4;
			checkType(l,5,out a4);
			self.DrawRect(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawEllipse(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			self.DrawEllipse(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawPolygon(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			UnityEngine.Vector2[] a1;
			checkArray(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			self.DrawPolygon(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Fill(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			FairyGUI.FillMethod a1;
			checkEnum(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			UnityEngine.Rect a5;
			checkValueType(l,6,out a5);
			UnityEngine.Rect a6;
			checkValueType(l,7,out a6);
			self.Fill(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FillVerts(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Rect a2;
			checkValueType(l,3,out a2);
			self.FillVerts(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FillUV(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Rect a2;
			checkValueType(l,3,out a2);
			self.FillUV(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FillColors(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			self.FillColors(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FillTriangles(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
				self.FillTriangles();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
				System.Int32[] a1;
				checkArray(l,2,out a1);
				self.FillTriangles(a1);
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
	static public int ClearMesh(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			self.ClearMesh();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Tint(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			self.Tint(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FillVertsOfQuad_s(IntPtr l) {
		try {
			UnityEngine.Vector3[] a1;
			checkArray(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Rect a3;
			checkValueType(l,3,out a3);
			FairyGUI.NGraphics.FillVertsOfQuad(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FillUVOfQuad_s(IntPtr l) {
		try {
			UnityEngine.Vector2[] a1;
			checkArray(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Rect a3;
			checkValueType(l,3,out a3);
			FairyGUI.NGraphics.FillUVOfQuad(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_grayed(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.grayed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_grayed(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.grayed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blendMode(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.blendMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_blendMode(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			FairyGUI.BlendMode v;
			checkEnum(l,2,out v);
			self.blendMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maskFrameId(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maskFrameId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maskFrameId(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			System.UInt32 v;
			checkType(l,2,out v);
			self.maskFrameId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertexMatrix(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vertexMatrix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_vertexMatrix(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			Matrix4x4 v;
			checkValueType(l,2,out v);
			self.vertexMatrix=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cameraPosition(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cameraPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cameraPosition(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			Vector3 v;
			checkValueType(l,2,out v);
			self.cameraPosition=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_TRIANGLES(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.NGraphics.TRIANGLES);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_TRIANGLES(IntPtr l) {
		try {
			System.Int32[] v;
			checkArray(l,2,out v);
			FairyGUI.NGraphics.TRIANGLES=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_TRIANGLES_9_GRID(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.NGraphics.TRIANGLES_9_GRID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_TRIANGLES_9_GRID(IntPtr l) {
		try {
			System.Int32[] v;
			checkArray(l,2,out v);
			FairyGUI.NGraphics.TRIANGLES_9_GRID=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_TRIANGLES_4_GRID(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,FairyGUI.NGraphics.TRIANGLES_4_GRID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_TRIANGLES_4_GRID(IntPtr l) {
		try {
			System.Int32[] v;
			checkArray(l,2,out v);
			FairyGUI.NGraphics.TRIANGLES_4_GRID=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertices(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vertices);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uv(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uv);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colors(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.colors);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_triangles(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.triangles);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertCount(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vertCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_meshFilter(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.meshFilter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_meshRenderer(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.meshRenderer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gameObject);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.texture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_texture(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			FairyGUI.NTexture v;
			checkType(l,2,out v);
			self.texture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shader(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shader(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.shader=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.material);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			UnityEngine.Material v;
			checkType(l,2,out v);
			self.material=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_materialKeywords(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.materialKeywords);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_materialKeywords(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.materialKeywords=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingOrder(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sortingOrder);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingOrder(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.sortingOrder=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alpha(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.alpha);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alpha(IntPtr l) {
		try {
			FairyGUI.NGraphics self=(FairyGUI.NGraphics)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.alpha=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"FairyGUI.NGraphics");
		addMember(l,SetShaderAndTexture);
		addMember(l,SetStencilEraserOrder);
		addMember(l,Dispose);
		addMember(l,UpdateMaterial);
		addMember(l,Alloc);
		addMember(l,UpdateMesh);
		addMember(l,SetOneQuadMesh);
		addMember(l,DrawRect);
		addMember(l,DrawEllipse);
		addMember(l,DrawPolygon);
		addMember(l,Fill);
		addMember(l,FillVerts);
		addMember(l,FillUV);
		addMember(l,FillColors);
		addMember(l,FillTriangles);
		addMember(l,ClearMesh);
		addMember(l,Tint);
		addMember(l,FillVertsOfQuad_s);
		addMember(l,FillUVOfQuad_s);
		addMember(l,"grayed",get_grayed,set_grayed,true);
		addMember(l,"blendMode",get_blendMode,set_blendMode,true);
		addMember(l,"maskFrameId",get_maskFrameId,set_maskFrameId,true);
		addMember(l,"vertexMatrix",get_vertexMatrix,set_vertexMatrix,true);
		addMember(l,"cameraPosition",get_cameraPosition,set_cameraPosition,true);
		addMember(l,"TRIANGLES",get_TRIANGLES,set_TRIANGLES,false);
		addMember(l,"TRIANGLES_9_GRID",get_TRIANGLES_9_GRID,set_TRIANGLES_9_GRID,false);
		addMember(l,"TRIANGLES_4_GRID",get_TRIANGLES_4_GRID,set_TRIANGLES_4_GRID,false);
		addMember(l,"vertices",get_vertices,null,true);
		addMember(l,"uv",get_uv,null,true);
		addMember(l,"colors",get_colors,null,true);
		addMember(l,"triangles",get_triangles,null,true);
		addMember(l,"vertCount",get_vertCount,null,true);
		addMember(l,"meshFilter",get_meshFilter,null,true);
		addMember(l,"meshRenderer",get_meshRenderer,null,true);
		addMember(l,"gameObject",get_gameObject,null,true);
		addMember(l,"texture",get_texture,set_texture,true);
		addMember(l,"shader",get_shader,set_shader,true);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"materialKeywords",get_materialKeywords,set_materialKeywords,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"sortingOrder",get_sortingOrder,set_sortingOrder,true);
		addMember(l,"alpha",get_alpha,set_alpha,true);
		createTypeMetatable(l,constructor, typeof(FairyGUI.NGraphics));
	}
}
