//// ===============================================================================
// Project Name        :    DJAssetsDataManager.cs
// Class Description   :    资源数据管理器
// Author              :    John
// Create Time         :    2016年7月26日 星期二 农历六月廿三
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================

using System.Collections.Generic;
using DJAssetsDefine;
using UnityEngine;

public class DJAssetsDataManager : DJManagerBase<DJAssetsDataManager>
{
    /// <summary>
    /// 资源字典
    /// </summary>
    public Dictionary<int, DJAssetDataModel> AssetsDict = new Dictionary<int, DJAssetDataModel>();

    /// <summary>
    /// 资源类型字典
    /// </summary>
    public Dictionary<AssetType, AssetsConfig> AssetTypeDict = new Dictionary<AssetType, AssetsConfig>();

    /// <summary>
    /// 所有资源的起点，所以硬编码
    /// </summary>
    private const string TablePath_Resource = "DJAsset/Table/Dev/DJResourceTable";

    /// <summary>
    /// 资源类型
    /// </summary>
    private const string TablePath_AssetType = "DJAsset/Table/Dev/DJAssetTypeTable";

    /// <summary>
    /// 资源表
    /// </summary>
    private DJResourceTable assetsTable;

    /// <summary>
    /// 加载资源
    /// </summary>
    public void LoadData()
    {
        var typeTable = Resources.Load<DJAssetTypeTable>(TablePath_AssetType);
        if (typeTable == null)
        {
            Debug.LogError("没有读取到表：" + TablePath_AssetType);
            return;
        }
        if (typeTable.Datas.Count == 0)
        {
            Debug.LogError("表数据为0." + TablePath_AssetType);
            return;
        }

        assetsTable = Resources.Load<DJResourceTable>(TablePath_Resource);
        if (assetsTable == null)
        {
            Debug.LogError("没有读取到表：" + TablePath_Resource);
            return;
        }
        if (assetsTable.Datas.Count == 0)
        {
            Debug.LogError("表数据为0." + TablePath_Resource);
            return;
        }

        //将表里的内容存入字典
        fillTypeDict(0, typeTable.Datas);

        //然后是资源表
        fillAssetsDict(0, assetsTable.Datas);
    }

    /// <summary>
    /// 填充类型资源表
    /// </summary>
    /// <param name="_index">索引</param>
    /// <param name="_datas">数据队列</param>
    private void fillTypeDict(int _index, List<AssetsConfig> _datas)
    {
        if (_index >= _datas.Count)
            return;
        var _data = _datas[_index];
        if (AssetTypeDict.ContainsKey(_data.type) == true)
        {
            //如果有资源了，报错
            Debug.LogError("资源类型表中有2条记录指向同一种资源：" + _data.type);
            return;
        }
        AssetTypeDict.Add(_data.type, _data);
        if (IsDebug)//再判断一次是避免非调试状态下拼接字符串
        {
            Log("加载了资源类型表，index:" + _index + "类型" + _data.type);
        }
        fillTypeDict(_index + 1, _datas);
    }

    /// <summary>
    /// 填充资源表
    /// </summary>
    /// <param name="_index">索引</param>
    /// <param name="_datas">数据队列</param>
    private void fillAssetsDict(int _index, List<DJAssetDataModel> _datas)
    {
        if (_index >= _datas.Count)
            return;
        var _data = _datas[_index];
        if (AssetsDict.ContainsKey(_data.id) == true)
        {
            //如果有资源了，报错
            Debug.LogError("资源表中有2条记录指向同一种资源：" + _data.type);
            return;
        }

        AssetsDict.Add(_data.id, _data);

        if (IsDebug)//再判断一次是避免非调试状态下拼接字符串
        {
            Log("加载了资源表，index:" + _index + "类型" + _data.type + "名称" + _data.name);
        }
        fillAssetsDict(_index + 1, _datas);
    }

    /// <summary>
    /// 得到该参数1状态的所有资源配置
    /// </summary>
    /// <param name="_state">资源状态</param>
    public List<DJAssetDataModel> GetAssetsByState(AssetState _state)
    {
        List<DJAssetDataModel> aseetsList = new List<DJAssetDataModel>();
        foreach (var _tempConfig in AssetsDict.Values)
        {
            if (_tempConfig.state == _state)
                aseetsList.Add(_tempConfig);
        }
        return aseetsList;
    }

#if UNITY_EDITOR
    /// <summary>
    /// 改变资源状态，只有在编辑器状态才可以使用
    /// </summary>
    /// <param name="_id"></param>
    /// <param name="_state"></param>
    public void SetAssetState(int _id, AssetState _state)
    {
        if (assetsTable == null)
            return;

        AssetsDict[_id].state = _state;
        //for (int i = 0; i < assetsTable.Datas.Count; i++)
        //{
        //    if (assetsTable.Datas[i].id == _id)
        //    {
        //        assetsTable.Datas[i].state = _state;
        //        break;
        //    }
        //}


        UnityEditor.EditorUtility.SetDirty(assetsTable);

    }
#endif

}
