//// ===============================================================================
// Project Name        :    DJAssetsDefine.cs
// Class Description   :    资源管理器的定义文件
// Author              :    John
// Create Time         :    2016年7月26日 星期二 农历六月廿三
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================

using System;

namespace DJAssetsDefine
{
    /// <summary>
    /// 资源表模板
    /// </summary>
    [Serializable]
    public class DJAssetDataModel
    {
        /// <summary>
        /// 资源编号
        /// </summary>
        public int id;

        /// <summary>
        /// 资源名字
        /// </summary>
        public string name;

        /// <summary>
        /// 资源类型
        /// </summary>
        public AssetType type;

        /// <summary>
        /// 说明
        /// </summary>
        public string des;

        /// <summary>
        /// 资源的md5验证码
        /// </summary>
        public string md5;

        /// <summary>
        /// 资源状态
        /// </summary>
        public AssetState state;
    }

    /// <summary>
    /// 资源类型
    /// </summary>
    [Serializable]
    public enum AssetType
    {
        /// <summary>
        /// 未赋值
        /// </summary>
        None = 0,
        /// <summary>
        /// 音频资源
        /// </summary>
        Audio = 1,
        /// <summary>
        /// 角色资源
        /// </summary>
        Charactor = 2,
        /// <summary>
        /// 动画资源
        /// </summary>
        Animation = 3,
        /// <summary>
        /// 场景资源
        /// </summary>
        Secene = 4,
        /// <summary>
        /// Unity本身的表文件
        /// </summary>
        UnityTable = 5
    }

    /// <summary>
    /// 资源状态
    /// </summary>
    public enum AssetState
    {
        /// <summary>
        /// 设计中
        /// </summary>
        Designing = 1,

        /// <summary>
        /// 已提交
        /// </summary>
        Submit = 2,

        /// <summary>
        /// 审核通过
        /// </summary>
        Approved = 3,

        /// <summary>
        /// 错误
        /// </summary>
        Error
    }

    /// <summary>
    /// 资源配置类
    /// </summary>
    [Serializable]
    public class AssetsConfig
    {
        /// <summary>
        /// 资源类型
        /// </summary>
        public AssetType type;

        /// <summary>
        /// 资源路径
        /// </summary>
        public string path;

        /// <summary>
        /// 后缀
        /// (无法通过类型校验的文件用后缀来校验)
        /// (理论上，所有的资源都可以通过类型校验)
        /// </summary>
        public string suffix;
    }
}
