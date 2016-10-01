using UnityEngine;

public class TestUI : MonoBehaviour
{
    public bool Once = false;

    void Start()
    {
        //初始化
        DJLuaManager.GetInstance().Init();
    }

    void Update()
    {
        if (Once == true && DJLuaManager.GetInstance().mLuaSvr.inited == true)
        {
            DJLuaManager.GetInstance().UnstallLuaScripts();
            var table = DJLuaManager.GetInstance().RsLoad("DJLua/TestUI");
            Once = false;
        }
    }
}
