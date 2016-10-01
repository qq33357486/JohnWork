//// ===============================================================================
// Project Name        :    DJAssetsEditorDefine.cs
// Class Description   :    资源管理器的编辑器定义类
// Author              :    John
// Create Time         :    2016年8月14日 星期日 农历七月十二
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================


using UnityEngine;
using System.Collections.Generic;
using DJAssetsDefine;


namespace DJAssetsEditorDefine
{
    /// <summary>
    /// 资源检测类型
    /// </summary>
    public enum CheckType
    {
        /// <summary>
        /// 未选择
        /// </summary>
        None,
        /// <summary>
        /// 自动审查所以资源
        /// </summary>
        AutoCheck,

        /// <summary>
        /// 人工审查某类资源
        /// </summary>
        TypeCheck
    }

    /// <summary>
    /// 手动检查的检查过程
    /// </summary>
    public enum TypeCheckState
    {
        /// <summary>
        /// 检查过程
        /// </summary>
        Proc,

        /// <summary>
        /// 打印结果
        /// </summary>
        PrintResult,
    }

    /// <summary>
    /// 资源检测的数据类
    /// </summary>
    public class CheckEditorData
    {
        /// <summary>
        /// 审查方式
        /// </summary>
        public CheckType mCheckType = CheckType.None;

        /// <summary>
        /// 审查资源类型.(只有再审查方式为类型审查时候才有用)
        /// </summary>
        public AssetType mAssetType = AssetType.None;

        #region 自动检测用的变量

        /// <summary>
        /// 当前检索到了哪个资源
        /// </summary>
        public int CheckingIndex;

        /// <summary>
        /// 检测中资源的key列表
        /// </summary>
        public List<int> CheckingkeyList = new List<int>();

        #endregion

        #region 手动检测用的变量

        /// <summary>
        /// 手动检查状态
        /// </summary>
        public TypeCheckState mTypeCheckState;

        /// <summary>
        /// 所有已经提交的资源列表
        /// </summary>
        public List<DJAssetDataModel> SubmitAssetsList;

        /// <summary>
        /// 通过列表
        /// </summary>
        public List<DJAssetDataModel> PassList = new List<DJAssetDataModel>();

        /// <summary>
        /// 拒绝列表
        /// </summary>
        public List<DJAssetDataModel> RefuseList = new List<DJAssetDataModel>();

        #endregion
    }
}
