using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WSA_Folder : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.WSA.Folder");
		addMember(l,0,"Installation");
		addMember(l,1,"Temporary");
		addMember(l,2,"Local");
		addMember(l,3,"Roaming");
		addMember(l,4,"CameraRoll");
		addMember(l,5,"DocumentsLibrary");
		addMember(l,6,"HomeGroup");
		addMember(l,7,"MediaServerDevices");
		addMember(l,8,"MusicLibrary");
		addMember(l,9,"PicturesLibrary");
		addMember(l,10,"Playlists");
		addMember(l,11,"RemovableDevices");
		addMember(l,12,"SavedPictures");
		addMember(l,13,"VideosLibrary");
		LuaDLL.lua_pop(l, 1);
	}
}
