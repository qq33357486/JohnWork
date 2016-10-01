//// ===============================================================================
// Project Name        :    DJTableTools.cs
// Class Description   :    游戏内表管理工具
// Author              :    John
// Create Time         :    2016年7月26日 星期二 农历六月廿三
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================

using UnityEngine;using UnityEditor;[CustomEditor(typeof(DJTableTools))]public class DJTableToolsEditor : Editor{    public override void OnInspectorGUI()    {        base.OnInspectorGUI();        if (GUILayout.Button("创建新的表"))
        {
            DJTableManagerEditor.GetInstance().CreateTable<DJAssetTypeTable>();
            DJTableManagerEditor.GetInstance().CreateTable<DJResourceTable>();
        }    }}