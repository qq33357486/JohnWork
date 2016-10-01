using UnityEngine;
using System.Collections;

public class Behavior3JSTest : MonoBehaviour
{

    public bool 加载 = true;
    public string loadFunction;
    //"/DJLua/Behavior3Js/main"
    public bool 运行一次 = false;
    public string runFunction;
    //testbt
    public bool 循环执行 = false;
    public string loopFunction;

    void Update()
    {
        if (加载 == true)
        {
            加载 = false;
            DoSomething();
        }

        if (运行一次 == true)
        {
            runOnce();
            运行一次 = false;
        }

        if (循环执行 == true)
        {
            runex();
        }
    }

    void DoSomething()
    {
        DJLuaManager.GetInstance().UnstallLuaScripts();
        DJLuaManager.GetInstance().RsLoad(loadFunction);

    }

    void runOnce()
    {
        DJLuaManager.GetInstance().ExecuteFunc(loadFunction, runFunction);
    }

    void runex()
    {
        DJLuaManager.GetInstance().ExecuteFunc(loadFunction, loopFunction);
    }
}
