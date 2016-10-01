//// ===============================================================================
// Project Name        :    DJTableManagerEditor.cs
// Class Description   :    开发环境中的资源表管理器
// Author              :    John
// Create Time         :    2016年8月7日 星期日 农历七月初五
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================


using UnityEngine;
using UnityEditor;
using System.IO;

public class DJTableManagerEditor : DJManagerBase<DJTableManagerEditor>
{
    /// <summary>
    /// 资源表路径
    /// </summary>
    private const string path = "/DJAsset/Table/Dev";

    /// <summary>
    /// 创建表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public void CreateTable<T>()
        where T : DJTableBase
    {
        T sd = ScriptableObject.CreateInstance<T>();

        sd.Init();

        //检测是否有path目录，
        Debug.Log(Application.dataPath);
        Directory.CreateDirectory(Application.dataPath + path);

        //这里采用+连接字符串因为需要path目录
        string p = "Assets/" + path + "/" + typeof(T).Name + ".asset";

        EditorUtility.SetDirty(sd);

        AssetDatabase.CreateAsset(sd, p);

    }
}