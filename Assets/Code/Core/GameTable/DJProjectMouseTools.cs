//// ===============================================================================
// Project Name        :    DJProjectMouseTools.cs
// Class Description   :    Project窗口的鼠标工具栏
// Author              :    John
// Create Time         :    2016年7月26日 星期二 农历六月廿三
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================


using UnityEngine;
using UnityEditor;

public class DJProjectMouseTools : Editor
{
    /// <summary>
    /// 获取选中的路径
    /// </summary>
    [MenuItem("Assets/Project/CopyPath")]
    public static void GetSelectedPath()
    {
        Object obj = Selection.activeObject;
        string path = AssetDatabase.GetAssetPath(obj);

        if (path.Contains("Assets/Resources/"))
        {
            path = path.Substring("Assets/Resources/".Length);
        }

        if (path.Contains(".prefab"))
        {
            path = path.Substring(0, path.Length - ".prefab".Length);
        }
        var te = new TextEditor();
        te.text = path;
        te.OnFocus();
        te.Copy();
    }
}
