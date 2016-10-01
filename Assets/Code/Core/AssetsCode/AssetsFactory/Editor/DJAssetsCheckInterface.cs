//// ===============================================================================
// Project Name        :    DJAssetsCheckBase.cs
// Class Description   :    资源监测的基本类
// Author              :    John
// Create Time         :    2016年7月26日 星期二 农历六月廿三
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================


using UnityEngine;
using DJAssetsDefine;
using System.Collections.Generic;

public class DJAssetsCheckBase
{
    /// <summary>
    /// 编辑器下的信息
    /// </summary>
    public virtual List<string> EditorInfos { get; set; }

    /// <summary>
    /// 物品id
    /// </summary>
    public int id;


    /// <summary>
    /// 我的资源
    /// </summary>
    protected virtual Object mAsset { get; set; }

    /// <summary>
    /// 加载资源
    /// </summary>
    /// <returns></returns>
    public virtual bool LoadAsset(int _id)
    { return true; }

    /// <summary>
    /// 加载资源
    /// </summary>
    /// <param name="_model"></param>
    /// <returns></returns>
    public virtual bool LoadAsset(DJAssetDataModel _model)
    { return true; }

    /// <summary>
    /// 检测资源
    /// </summary>
    /// <returns></returns>
    public virtual bool CheckAsset()
    {
        return true;
    }

    /// <summary>
    /// 打印资源信息
    /// </summary>
    public virtual void PrintInfo()
    {
    }

    /// <summary>
    /// 绘制操作界面的GUI
    /// </summary>
    public virtual void DrawEditorTestGUI() { }

    /// <summary>
    /// 退出，用来清理检测时创建的临时资源
    /// </summary>
    public virtual void Quit() { }

    /// <summary>
    /// 初始化,用来准备检测资源用的环境
    /// </summary>
    public virtual void Init() { }
}
