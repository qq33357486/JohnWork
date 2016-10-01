//// ===============================================================================
// Project Name        :    DJAssetCheckUnit_Audio.cs
// Class Description   :    资源检测单元_音频
// Author              :    John
// Create Time         :    2016年8月14日 星期日 农历七月十二
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================


using UnityEngine;
using DJAssetsDefine;
using System.Collections.Generic;

public class DJAssetCheckUnit_Audiu : DJAssetsCheckBase
{

    /// <summary>
    /// 存储：我的资源
    /// </summary>
    private AudioClip myAsset;

    /// <summary>
    /// 存储：编辑器信息
    /// </summary>
    private List<string> myEditorInfos = new List<string>();

    /// <summary>
    /// 接口：编辑器信息
    /// </summary>
    public override List<string> EditorInfos
    {
        get
        {
            return myEditorInfos;
        }
        set
        {
            myEditorInfos = value;
        }
    }

    #region 非接口声明

    AudioSource audioSource;

    #endregion

    /// <summary>
    /// 自动检测
    /// </summary>
    /// <returns></returns>
    public override bool CheckAsset()
    {
        bool isPass = true;
        //音频赫兹
        if (myAsset.frequency > 44100)
        {
            myEditorInfos.Add("[Error]赫兹超标，当前赫兹：" + myAsset.frequency);
            isPass = false;
        }

        //加载类型
        //音频质量
        //压缩格式
        //音频长度
        //等等

        if (isPass == true)
        {
            myEditorInfos.Add("自动审核通过");
        }

        return isPass;
    }

    /// <summary>
    /// 初始化
    /// </summary>
    public override void Init()
    {
        if (audioSource == null)
        {
            var obj = new GameObject();
            audioSource = obj.AddComponent<AudioSource>();
            obj.AddComponent<AudioListener>();
        }
        else
        {
            if (audioSource.isPlaying == true)
                audioSource.Stop();
        }
    }

    /// <summary>
    /// 退出
    /// </summary>
    public override void Quit()
    {
        if (audioSource != null)
            GameObject.DestroyImmediate(audioSource.gameObject);
    }

    /// <summary>
    /// 绘制人工测试界面
    /// </summary>
    public override void DrawEditorTestGUI()
    {
        if (GUILayout.Button("播放2d"))
        {
            if (audioSource.isPlaying == true)
                audioSource.Stop();
            audioSource.clip = myAsset;
            audioSource.Play();
        }

        if (GUILayout.Button("播放3d"))
        {
            //1. 区分AudioListener 与 AudioSource
            //2. 让AudioSource 围绕着 AudioListener，从近到远，从远到近播放
        }

        if (GUILayout.Button("停止播放"))
        {
            if (audioSource.isPlaying == true)
                audioSource.Stop();
        }
    }

    public override bool LoadAsset(DJAssetDataModel _model)
    {
        //懒得实现了
        return true;
    }

    public override bool LoadAsset(int _id)
    {
        id = _id;
        myEditorInfos.Add("资源id：" + _id + " 名称：" + DJAssetsDataManager.GetInstance().AssetsDict[_id].name);
        myAsset = DJAssetsManager.GetInstance().Load<AudioClip>(_id);
        bool isPass = true;
        if (myAsset == null)
        {
            myEditorInfos.Add("[Error]路径失效或类型错误");
            isPass = false;
        }
        return isPass;
    }

    public override void PrintInfo()
    {

    }
}
