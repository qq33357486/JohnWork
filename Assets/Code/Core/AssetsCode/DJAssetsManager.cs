// ===============================================================================
// Project Name        :    DJAssetsManager.cs
// Class Description   :    资源管理器
// Author              :    John
// Create Time         :    2016年7月26日 星期二 农历六月廿三
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================


using UnityEngine;
using System.Collections.Generic;
using DJAssetsDefine;

public class DJAssetsManager : DJManagerBase<DJAssetsManager>
{
    /// <summary>
    /// 资源字典
    /// </summary>
    private Dictionary<int, DJAssetDataModel> AssetsDict
    {
        get
        {
            return DJAssetsDataManager.GetInstance().AssetsDict;
        }
    }
    /// <summary>
    /// 资源类型字典
    /// </summary>
    private Dictionary<AssetType, AssetsConfig> AssetTypeDict
    {
        get
        {
            return DJAssetsDataManager.GetInstance().AssetTypeDict;
        }
    }

    /// <summary>
    /// 通过资源ID，加载一份资源
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_id"></param>
    /// <returns></returns>
    public T Load<T>(int _id)
        where T : Object
    {
        //检查资源有效性
        if (AssetsDict.ContainsKey(_id) == false)
        {
            Debug.LogError("正在加载错误的资源，资源ID：" + _id);
            return default(T);
        }

        var _data = AssetsDict[_id];

        //检测资源的提交状态，只有在debug状态才能加载非确定的资源
        if (IsDebug == false)
        {
            if (_data.state != AssetState.Approved)
            {
                Debug.LogError("资源:" + _id + "非提交状态，请检测资源或切换至调试模式");
                return default(T);
            }
        }

        if (IsDebug == true)
        {
            //线上确保，调试阶段才检测有效性
            if (AssetTypeDict.ContainsKey(_data.type) == false)
            {
                Debug.LogError("找不到资源类型：" + _data.type);
                return default(T);
            }
        }

        //直接取得类型
        var _typeData = AssetTypeDict[_data.type];

        //配置路径
        string path = string.Format("{0}{1}", _typeData.path, _data.name);

        T t = Resources.Load<T>(path);

        if (IsDebug == true)
        {
            //通过资源检测流程，我们确保线上的资源一定是能够被加载的，所以只用在调试阶段判断。
            if (t == null)
            {
                Debug.LogError("没有读取到资源：" + path);
                return null;
            }

            Log("加载了资源：" + _id + ". path = " + path + ",加载成功");
        }
        return t;
    }
}
