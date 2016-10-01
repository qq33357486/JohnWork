//// ===============================================================================
// Project Name        :    DJAssetsCheckToolsEditor.cs
// Class Description   :    审查工具的Editor绘制类
// Author              :    John
// Create Time         :    2016年8月14日 星期日 农历七月十二
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================

using UnityEngine;
using System.Collections;
using UnityEditor;
using DJAssetsEditorDefine;
using System.Collections.Generic;
using DJAssetsDefine;
using System.Reflection;

[CustomEditor(typeof(DJAssetsCheckTools))]
public class DJAssetsCheckToolsEditor : Editor
{
    /// <summary>
    /// 界面数据
    /// </summary>
    CheckEditorData Data;

    /// <summary>
    /// 顶端文字
    /// </summary>
    string TopTips = "";

    /// <summary>
    /// 错误的资源列表
    /// </summary>
    private List<DJAssetsCheckBase> ErrorList = new List<DJAssetsCheckBase>();

    /// <summary>
    /// 是否初始化
    /// </summary>
    private bool isInit = false;

    /// <summary>
    /// 资源检测类型，
    /// </summary>
    private CheckType tempCheckType = CheckType.None;

    #region 人工检测用到的变量

    /// <summary>
    /// 当前的检测单元
    /// </summary>
    private DJAssetsCheckBase currentCheckUnit;

    /// <summary>
    /// 当前配置
    /// </summary>
    public DJAssetDataModel currentConfig
    {
        get { return Data.SubmitAssetsList[Data.CheckingIndex]; }
    }

    #endregion

    void Init()
    {
        //编辑器数据
        Data = (target as DJAssetsCheckTools).Data;

        //初始化表
        DJAssetsDataManager.GetInstance().LoadData();

        isInit = true;
    }

    public override void OnInspectorGUI()
    {
        if (isInit == false) Init();

        if (Data == null)
            Init();

        EditorGUILayout.LabelField("Tips:" + TopTips);


        // switch语法看起来标准，但个人觉得代码阅读性不如下面没有注释的

        //switch (Data.mCheckType)
        //{
        //    case CheckType.None:
        //        TopTips = "请选择检查类型";

        //        var checkType = EditorGUILayout.EnumPopup("检测类型:", tempCheckType);
        //        tempCheckType = (CheckType)checkType;
        //        if (tempCheckType != Data.mCheckType)
        //        {
        //            if (GUILayout.Button("开始检测"))
        //            {
        //                ChangeState(tempCheckType);
        //            }
        //            return;
        //        }
        //        break;
        //    case CheckType.AutoCheck:
        //        OnAutoCheckGUI();
        //        break;
        //    case CheckType.TypeCheck:
        //        if (Data.mTypeCheckState == TypeCheckState.Proc)
        //            OnManualCheckGUI_Proc();
        //        else
        //            OnManualCheckGUI_Result();
        //        break;
        //}

        //选择检测类型的首页面绘制
        if (Data.mCheckType == CheckType.None)
        {
            TopTips = "请选择检查类型";

            var checkType = EditorGUILayout.EnumPopup("检测类型:", tempCheckType);
            tempCheckType = (CheckType)checkType;
            if (tempCheckType != Data.mCheckType)
            {
                if (GUILayout.Button("开始检测"))
                {
                    ChangeState(tempCheckType);
                }
            }
            return;
        }

        //自动检测页面
        if (Data.mCheckType == CheckType.AutoCheck)
        {
            OnAutoCheckGUI();
            return;
        }

        //人工检测页面
        if (Data.mCheckType == CheckType.TypeCheck)
        {
            if (Data.SubmitAssetsList.Count == 0)
            {
                EditorGUILayout.LabelField("没有状态为Submit的资源需要人工检测");
                if (GUILayout.Button("返回"))
                {
                    ChangeState(CheckType.None);
                }
                return;
            }

            //人工检测过程有2个界面，区分开来绘制代码比较清晰
            if (Data.mTypeCheckState == TypeCheckState.Proc)
                OnManualCheckGUI_Proc();
            else
                OnManualCheckGUI_Result();
            return;
        }
    }

    #region 审查类型切换

    void ChangeState(CheckType _type)
    {
        switch (_type)
        {
            case CheckType.None:
                ToNoneSate();
                break;
            case CheckType.TypeCheck:
                ToTypeCheckState();
                break;
            case CheckType.AutoCheck:
                ToAutoCheckState();
                break;
        }
        Data.mCheckType = _type;
        tempCheckType = Data.mCheckType;
    }

    void ToNoneSate()
    {

    }

    void ToTypeCheckState()
    {
        //得到所有已经提交资源的列表
        Data.SubmitAssetsList = DJAssetsDataManager.GetInstance().GetAssetsByState(AssetState.Submit);
        //清除索引
        Data.CheckingIndex = 0;
        //初始化状态
        Data.mTypeCheckState = TypeCheckState.Proc;
    }

    /// <summary>
    /// 得改成异步的啊
    /// </summary>
    void ToAutoCheckState()
    {
        //锁定编辑窗口
        //代码偷自：http://www.xuanyusong.com/archives/3796
        var type = typeof(EditorWindow).Assembly.GetType("UnityEditor.InspectorWindow");
        var window = EditorWindow.GetWindow(type);
        MethodInfo info = type.GetMethod("FlipLocked", BindingFlags.NonPublic | BindingFlags.Instance);
        info.Invoke(window, null);

        var allAssets = DJAssetsDataManager.GetInstance().AssetsDict;
        Data.CheckingIndex = 0;
        Data.CheckingkeyList.Clear();
        ErrorList.Clear();
        foreach (var _key in allAssets.Keys)
        {
            Data.CheckingkeyList.Add(_key);
        }
    }

    #endregion

    #region 手动审查

    /// <summary>
    /// 人工检测结果页面
    /// </summary>
    void OnManualCheckGUI_Result()
    {

        //打印成功检测的清单
        EditorGUILayout.LabelField("检测成功的资源清单，共" + Data.PassList.Count + "个");
        for (int i = 0; i < Data.PassList.Count; i++)
        {
            var _config = Data.PassList[i];
            EditorGUILayout.LabelField(i + ": " + _config.id + " " + _config.type + " " + _config.name);
        }

        EditorGUILayout.Space();

        //打印检测失败的清单
        EditorGUILayout.LabelField("检测失败的资源清单，共" + Data.RefuseList.Count + "个");
        for (int j = 0; j < Data.RefuseList.Count; j++)
        {
            var _config = Data.RefuseList[j];
            EditorGUILayout.LabelField(j + ": " + _config.id + " " + _config.type + " " + _config.name);
        }

        //功能
        if (GUILayout.Button("复制失败清单"))
        {
            string errorListStr = "";
            for (int i = 0; i < Data.RefuseList.Count; i++)
            {
                var _config = Data.RefuseList[i];
                errorListStr += _config.id + " " + _config.type + " " + _config.name + "\n";
            }

            var te = new TextEditor();
            te.text = errorListStr;
            te.OnFocus();
            te.Copy();
        }

        if (GUILayout.Button("保存审查结果并退出"))
        {
            if (currentCheckUnit != null)
                currentCheckUnit.Quit();

            //保存没有通过的
            for (int j = 0; j < Data.RefuseList.Count; j++)
            {
                var _config = Data.RefuseList[j];
                DJAssetsDataManager.GetInstance().SetAssetState(_config.id, AssetState.Designing);
            }

            //保存通过审核的
            for (int i = 0; i < Data.PassList.Count; i++)
            {
                var _config = Data.PassList[i];
                DJAssetsDataManager.GetInstance().SetAssetState(_config.id, AssetState.Approved);
            }

            //退回普通模式中
            ChangeState(CheckType.None);
        }
    }

    /// <summary>
    /// 人工检测过程页面
    /// </summary>
    void OnManualCheckGUI_Proc()
    {
        //得到检测单元
        if (currentCheckUnit == null)
        {
            currentCheckUnit = DJAssetsCheckFactory.GetCheckUnit(currentConfig.type);
            currentCheckUnit.Init();
            currentCheckUnit.LoadAsset(currentConfig.id);//如果加载失败，应该有一些提示，但是这里就先不提示了
        }

        EditorGUILayout.Space();

        currentCheckUnit.DrawEditorTestGUI();

        EditorGUILayout.Space();

        EditorGUILayout.BeginHorizontal();

        if (Data.CheckingIndex > 0 && GUILayout.Button("上一个")) ToLast();


        if (Data.CheckingIndex < Data.SubmitAssetsList.Count - 1 && GUILayout.Button("下一个")) ToNext();

        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space();

        if (GUILayout.Button("通过检测"))
        {
            TopTips = "操作：通过检查";
            //加入成功队列
            if (Data.PassList.Contains(currentConfig) == false)
                Data.PassList.Add(currentConfig);
            if (Data.RefuseList.Contains(currentConfig) == true)
                Data.RefuseList.Remove(currentConfig);
            ToNext();
        }

        if (GUILayout.Button("没通过"))
        {
            TopTips = "操作：没有通过检查";
            //加入失败队列
            if (Data.RefuseList.Contains(currentConfig) == false)
                Data.RefuseList.Add(currentConfig);
            if (Data.PassList.Contains(currentConfig) == true)
                Data.PassList.Remove(currentConfig);
            ToNext();
        }

        EditorGUILayout.Space();

        if (GUILayout.Button("结束检查"))
        {
            Data.mTypeCheckState = TypeCheckState.PrintResult;
        }
    }

    /// <summary>
    /// 到上一个
    /// </summary>
    private void ToLast()
    {
        if (Data.CheckingIndex == 0)
        {
            TopTips = "当前是第一个资源";
            return;
        }
        Data.CheckingIndex--;
        currentCheckUnit.Quit();
        currentCheckUnit = DJAssetsCheckFactory.GetCheckUnit(currentConfig.type);
    }

    /// <summary>
    /// 到下一个
    /// </summary>
    private void ToNext()
    {
        if (Data.CheckingIndex == Data.SubmitAssetsList.Count - 1)
        {
            TopTips = "已经是最后一个资源了";
            return;
        }
        Data.CheckingIndex++;
        currentCheckUnit.Quit();
        currentCheckUnit = DJAssetsCheckFactory.GetCheckUnit(currentConfig.type);
    }

    #endregion

    #region 自动审查

    void OnAutoCheckGUI()
    {
        EditorGUILayout.LabelField("检测结束前，请不要取消锁定");
        if (Data.CheckingIndex < Data.CheckingkeyList.Count)
        {
            TopTips = "自动检测进度：(" + Data.CheckingIndex + "/" + Data.CheckingkeyList.Count + ")";

            //循环所有资源，并进行检查
            var allAssets = DJAssetsDataManager.GetInstance().AssetsDict;
            var _config = allAssets[Data.CheckingkeyList[Data.CheckingIndex]];

            //设计中的资源就不检测了
            if (_config.state == DJAssetsDefine.AssetState.Designing)
            {
                Data.CheckingIndex += 1;
                return;
            }

            var testUnit = DJAssetsCheckFactory.GetCheckUnit(_config.type);
            //得到对应的检测脚本

            if (testUnit == null)
            {
                //这里就不写出所有类型的测试脚本了
                Data.CheckingIndex += 1;
                return;
            }

            if (testUnit.LoadAsset(_config.id) == false ||
                testUnit.CheckAsset() == false)
            {
                ErrorList.Add(testUnit);
                Data.CheckingIndex += 1;
                return;
            }

            Data.CheckingIndex += 1;


            return;
        }

        if (ErrorList.Count > 0)
        {
            EditorGUILayout.BeginScrollView(new Vector2(300, 1200));
            //执行到这里检测已经完毕了，就打印结果
            for (int i = 0; i < ErrorList.Count; i++)
            {
                var _data = ErrorList[i];
                for (int j = 0; j < _data.EditorInfos.Count; j++)
                {
                    EditorGUILayout.LabelField(_data.EditorInfos[j]);
                }
                EditorGUILayout.Space();
            }
            EditorGUILayout.EndScrollView();
            TopTips = "共有" + ErrorList.Count + "份资源没有通过自动检查.注意，当退出检测模式时，未通过的资源会被设置为错误状态。";
        }
        else
        {
            TopTips = "所有资源通过检查";
        }


        if (ErrorList.Count > 0)
        {
            //方便将错误列表转发给各个负责人
            if (GUILayout.Button("将错误列表复制到剪切板中"))
            {
                string errorListStr = "";
                for (int i = 0; i < ErrorList.Count; i++)
                {
                    var _config = DJAssetsDataManager.GetInstance().AssetsDict[ErrorList[i].id];
                    errorListStr += _config.id + " " + _config.type + " " + _config.name + "\n";
                }

                var te = new TextEditor();
                te.text = errorListStr;
                te.OnFocus();
                te.Copy();
            }
        }


        if (GUILayout.Button("退出检查模式"))
        {
            for (int i = 0; i < ErrorList.Count; i++)
            {
                var _data = ErrorList[i];
                DJAssetsDataManager.GetInstance().SetAssetState(_data.id, AssetState.Error);
            }
            ChangeState(CheckType.None);
        }

    }

    #endregion


}

