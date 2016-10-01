--
-- Des: 健康感知器
-- Author: John
-- Date: 2016年9月18日 星期日 农历八月十八
-- 文档: https://worktile.com/project/ff9e093759b04c258f531c3b39808063/page/269e05f7ba3b490caca35aea2753f612
--

require "sprite_base"

perception_health = Class.define("perception_health", perception_base)

----------------------------------------------------------------------------------------------
---- 表内变量
----------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------
---- 继承函数
----------------------------------------------------------------------------------------------


----------------------------------------------------------------------------------------------
---- 内部逻辑
----------------------------------------------------------------------------------------------

-- 感知器的刷新帧
function perception_health:tick()

end

function perception_health:CheckHp(ConditionType, _hp)

    if ConditionType == "<=" then
        return hero.Ai.hp <= _hp
    elseif ConditionType == ">=" then
        return hero.Ai.hp >= hp
    end
    return false
end

-- 精灵对象是否忙碌
function perception_health:isBusy()
    return false
end

-- 精灵对象是否异常
function perception_health:isException()
    return false
end

-- 判断是否某个具体状态
function perception_health:checkProperty(ExceptionType)
    return false
end

----------------------------------------------------------------------------------------------
---- 外部接口
----------------------------------------------------------------------------------------------

-- 行为树的询问函数
-- 直接返回ture或flase，出去后再转义，避免耦合度
function perception_health:Ask(_askType, _args)
    -- 参数哟~可能为空
    -- local args = { ...}

    if _askType == "CheckHp" then
        return self:CheckHp(_args.ConditionType, _args.ConditionParam)
    elseif _askType == "IsBusy" then
        return self:isBusy()
    elseif _askType == "IsException" then
        return self:isException()
    elseif _askType == "CheckProperty" then
        return self:checkProperty(_args.ExceptionType)
    else
        error("【健康感知器】没有定义的Ask类型：" .. _askType)
        return false
    end
end

----------------------------------------------------------------------------------------------
---- 通信接口
----------------------------------------------------------------------------------------------