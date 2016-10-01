//// ===============================================================================
// Project Name        :    DJDebugTollsEditor.cs
// Class Description   :    游戏内调试工具
// Author              :    John
// Create Time         :    2016年8月31日 星期三 农历七月廿九
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================

using UnityEngine;
using System.Collections.Generic;
using UnityEditor;
using behaviac;
using System;

[CustomEditor(typeof(DJDebugTools))]
public class DJDebugTollsEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("AI加载"))
        {
            behaviac.Config.IsLogging = false;
            var agent = GameObject.FindObjectOfType<DJTest>();
            if (agent != null)
            {
                Agent.RegisterInstanceName<DJTest>("DJTest");
                Agent.BindInstance(agent);
                string path = Application.dataPath + "/Resources/behaviac/exported/DJTest";
                UnityEngine.Debug.Log("path: " + path);
                var result = agent.btload(path, true);
                if (result)
                {
                    agent.btsetcurrent(path);
                    agent.isInit = result;
                }
                else
                {
                    behaviac.Debug.Log("没有加载到数据");
                }
            }

            DJLuaManager.GetInstance();
        }

        if (GUILayout.Button("Do sth"))
        {
            behaviac.Config.IsLogging = true;

            behaviac.Workspace.Instance.FilePath = Application.dataPath;
            behaviac.Workspace.Instance.FileFormat = behaviac.Workspace.EFileFormat.EFF_xml;

            //register names
            behaviac.Agent.RegisterInstanceName<DJTest>("DJTest");
            behaviac.Workspace.Instance.ExportMetas("Code/Behaviac/xml/DJTest.xml");

            behaviac.Debug.Log("Behaviac meta data export over.");
            behaviac.Agent.SetIdMask(0xffffffff);
        }

        if (GUILayout.Button("重新加载Lua脚本"))
        {
            DJLuaManager.GetInstance().UnstallLuaScripts();
        }

        if (GUILayout.Button("读取资源"))
        {
            var tx = Resources.Load("") as TextAsset;

        }
    }
}
