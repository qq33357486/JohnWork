//// ===============================================================================
// Project Name        :    DJTest.cs
// Class Description   :    测试的行为树节点
// Author              :    John
// Create Time         :    2016年8月31日 星期三 农历七月廿九
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================


[behaviac.TypeMetaInfo()]
public class DJTest : behaviac.Agent
{
    /// <summary>
    /// 是否初始化
    /// </summary>
    public bool isInit = false;

    [behaviac.MemberMetaInfo()]
    public int hp = 100;

    /// <summary>
    /// 是否死亡
    /// </summary>
    [behaviac.MemberMetaInfo()]
    public bool isDead = false;

    /// <summary>
    /// 改变血量
    /// </summary>
    /// <param name="_hp"></param>
    [behaviac.MethodMetaInfo()]
    public void ChangeHp(int _hp)
    {
        hp += _hp;
        if (hp <= 0)
        {
            Dead();
        }
        UnityEngine.Debug.Log("当前血量: " + hp);
    }

    /// <summary>
    /// 复活
    /// </summary>
    [behaviac.MethodMetaInfo()]
    public void ReBorn()
    {
        UnityEngine.Debug.Log("我死了");
        isDead = false;
        hp = 100;
    }

    /// <summary>
    /// 执行Lua脚本
    /// </summary>
    /// <param name="_className">类名</param>
    /// <param name="_methodName">方法名</param>
    [behaviac.MethodMetaInfo()]
    public void ExecuteLua(string _className, string _methodName)
    {
        DJLuaManager.GetInstance().ExecuteFunc(_className, _methodName, this);
    }

    void Update()
    {
        //behaviac.Workspace.Instance.Update();
        if (isInit)
            btexec();
    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {
        UnityEngine.Debug.Log("我复活了");
        hp = 0;
        isDead = true;
    }
}
