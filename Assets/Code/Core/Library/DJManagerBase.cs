// ===============================================================================
// Project Name        :    DJManagerBase.cs
// Class Description   :    游戏内管理器的基础类
// Author              :    John
// Create Time         :    2016年7月26日 星期二 农历六月廿三
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================

using UnityEngine;

public class DJManagerBase<T> : MonoBehaviour
    where T : DJManagerBase<T>
{
    /// <summary>
    /// 管理器的公共实体父节点
    /// </summary>
    private static GameObject ManagerRoot;

    /// <summary>
    /// 根节点的名称
    /// </summary>
    private const string RootName = "9_ManagerRoot";

    /// <summary>
    /// 管理器的静态对象
    /// </summary>
    private static T mInstance;

    /// <summary>
    /// 管理器的名字(打日志用的)
    /// </summary>
    private string className;

    /// <summary>
    /// 是否调试状态
    /// 这个值非常的有必要，在后续开发中我们将它的威力展现出来
    /// </summary>
    public static bool IsDebug = true;

    /// <summary>
    /// 得到静态对象
    /// </summary>
    /// <returns></returns>
    public static T GetInstance()
    {
        if (mInstance != null)
        {
            return mInstance;
        }
        //创建并返回一个对象
        return CreateInstance();
    }

    /// <summary>
    /// 创建一个对象
    /// </summary>
    /// <returns></returns>
    private static T CreateInstance()
    {
        //判断是否有根节点
        if (ManagerRoot == null)
            ManagerRoot = GameObject.Find(RootName);
        if (ManagerRoot == null)
            CreateRoot();


        //得到管理器名字
        string name = typeof(T).Name;

        //找到老对象干掉,编译模式下
#if UNITY_EDITOR
        var old = GameObject.Find(name);
        if (old != null)
            DestroyImmediate(old);
#endif

        //创建对象
        GameObject manager = new GameObject(name);

        manager.transform.parent = ManagerRoot.transform;

        //添加脚本
        mInstance = manager.AddComponent<T>();

        //执行初始化函数(虽然有Start可以调用，但手动调用堆栈信息较为清晰)
        mInstance.Init();

        return mInstance;
    }

    /// <summary>
    /// 创建一个根节点
    /// </summary>
    /// <returns>节点对象</returns>
    private static void CreateRoot()
    {
        ManagerRoot = new GameObject();
        ManagerRoot.name = RootName;
        if (Application.isPlaying)
            DontDestroyOnLoad(ManagerRoot);
    }

    /// <summary>
    /// 初始化
    /// </summary>
    public virtual void Init()
    {

    }

    /// <summary>
    /// 该系统的常规日志
    /// </summary>
    /// <param name="_context"></param>
    public void Log(string _context)
    {
        if (IsDebug)
            Debug.Log(string.Format("{0}:{1}", this.GetType().Name, _context));
    }

    /// <summary>
    /// 该系统的错误日志
    /// </summary>
    /// <param name="_context"></param>
    public void LogError(string _context)
    {
        Debug.LogError(string.Format("{0}:{1}", this.GetType().Name, _context));
    }
}
