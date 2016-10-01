//// ===============================================================================
// Project Name        :    DJLuaManager.cs
// Class Description   :    撸啊管理器
// Author              :    John
// Create Time         :    2016年8月25日 星期四 农历七月廿三
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================

using SLua;
using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System;
using LuaInterface;

public class DJLuaManager : DJManagerBase<DJLuaManager>
{
    /// <summary>
    /// lua服务
    /// </summary>
    public LuaSvr mLuaSvr
    {
        get
        {
            return mluasvr;
        }
    }

    /// <summary>
    /// 被加载的lua字典
    /// 按设计思想来说，把Lua方法全部当作静态
    /// </summary>
    private Dictionary<string, LuaTable> luaDict = new Dictionary<string, LuaTable>();

    /// <summary>
    /// 存储用的
    /// </summary>
    private LuaSvr mluasvr;

    /// <summary>
    /// 未初始化前，等待加载的脚本
    /// </summary>
    private string waitLoadLua;

    /// <summary>
    /// 
    /// </summary>
    public override void Init()
    {
        if (mluasvr != null)
            return;
        IsDebug = false;

        //初始化Lua服务
        mluasvr = new LuaSvr();
        mluasvr.init(null, () =>
        {
            Log("初始化完成");
            RsLoad("DJLua/CustomImport");
            //初始化等待初始化的脚本
            if (string.IsNullOrEmpty(waitLoadLua) == false)
            {
                RsLoad(waitLoadLua);
                waitLoadLua = "";
            }
        });
    }

    ////添加LuaState初始化时的回调函数特性函数
    //[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    //static int init(IntPtr L)
    //{
    //    //设置初始化LuaObject对象
    //    LuaObject.init(L);
    //    return 0;
    //}

    /// <summary>
    /// 执行某个脚本的某个函数
    /// </summary>
    /// <param name="_classPath">脚本</param>
    /// <param name="_funcName">函数</param>
    public void ExecuteFunc(string _classPath, string _funcName)
    {
        var self = RsLoad(_classPath);
        if (self == null) return;
        var func = (LuaFunction)self[_funcName];
        if (func == null)
        {
            Debug.LogError("调用了不存在的函数，脚本名：" + _classPath + "函数名：" + _funcName);
            return;
        }
        func.call(self);
    }

    /// <summary>
    /// 执行某个脚本的函数( 带参数 )
    /// </summary>
    /// <param name="_className"></param>
    /// <param name="_funcName"></param>
    /// <param name="_args"></param>
    public void ExecuteFunc(string _className, string _funcName, params object[] _args)
    {
        var self = RsLoad(string.Format("DJLua/{0}", _className));
        if (self == null) return;
        var func = (LuaFunction)self[_funcName];
        if (func == null)
        {
            Debug.LogError("调用了不存在的函数，脚本名：" + _className + "函数名：" + _funcName);
            return;
        }
        func.call(self, _args);
    }

    /// <summary>
    /// 移除脚本，移除后，会重新加载，这样就可以热更新了。
    /// 平时用缓存里的，性能就没那么差了
    /// </summary>
    public void UnstallLuaScripts()
    {
        luaDict.Clear();
    }

    /// <summary>
    /// 卸载指定脚本
    /// </summary>
    /// <param name="_name">脚本目录+名字</param>
    public void UnstallLuaScript(string _name)
    {
        if (luaDict.ContainsKey(_name))
            luaDict.Remove(_name);
    }

    /// <summary>
    /// 从resouce目录加载Lua脚本，并初始化
    /// </summary>
    /// <param name="_rsPath">Resouce下的目录</param>
    /// <param name="_forceReading">是否强制读取</param>
    public SLua.LuaTable RsLoad(string _rsPath)
    {
        Log("加载：" + _rsPath);

        if (mluasvr.inited == false)
        {
            Log("还未初始化，等待初始化后加载：" + _rsPath);
            waitLoadLua = _rsPath;
            return null;
        }

        if (luaDict.ContainsKey(_rsPath))
            return luaDict[_rsPath];

        //设置执行脚本
        //LuaState ls_state = new LuaState();

        //设置脚本启动代理
        LuaState.loaderDelegate = ((string fn) =>
        {
            //获取Lua文件执行目录
            string file_path = Directory.GetCurrentDirectory() + "/Assets/Resources/" + fn;

            file_path = file_path.Replace('/', '\\');
            file_path = file_path.Replace('.', '\\');


            Log("准备加载脚本：" + file_path);

            var file = File.ReadAllBytes(file_path + ".lua");

            if (file == null)
                LogError("加载Lua脚本失败，不存在的Lua脚本");
            else
                Log("加载脚本成功.文件大小：" + file.Length);

            return file;
        });

        //通过刚才设置的代理方法加载，就会从Res目录下读取带.lua的文件了
        var self = (LuaTable)mluasvr.start(_rsPath);
        if (self != null)
        {
            luaDict.Add(_rsPath, self);
            return self;
        }

        LogError("脚本初始化错误,脚本：" + _rsPath);

        return null;
    }
}
