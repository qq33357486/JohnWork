--
-- Des: 战斗行为事件，想了想逻辑函数没必要单独再写一个类了，就直接写里面吧
-- Author: John
-- Date: 2016年9月19日 星期一 农历八月十九
-- Docment url: https://worktile.com/project/ff9e093759b04c258f531c3b39808063/page/25d16aefdf25429fa6b86ec8af57e4ea
-- 
Action_FightBehavior = Action:new()

----------------------------------------------------------------------------------------------
---- 继承函数
----------------------------------------------------------------------------------------------

function Action_FightBehavior:ctor()
    report_dt('[testfunc]Action FightBehavior')
end 

function Action_FightBehavior:open(tick)
    -- nohing
end

function Action_FightBehavior:tick(tick)
    local F_Type = self.parameters.F_Type
    if F_Type == "ChangeToSprite" then
        self:ChangeToSprite(tick)
    elseif F_Type == "SetTarget" then
        self:SetTarget(tick)
    else
        error("未知的战斗事件，事件类型：" .. F_Type)
    end

    return Status.SUCCESS
end

----------------------------------------------------------------------------------------------
---- 内部逻辑 (说明文档里都有)
----------------------------------------------------------------------------------------------

-- 变身
function Action_FightBehavior:ChangeToSprite(tick)
    print("我变身啦,想要变身的目标ID是：" .. self.parameters.TargetID)
end

-- 设置目标
function Action_FightBehavior:SetTarget(tick)
    print("我的目标要设置为：" .. self.paramters.Target_Type)
    if self.paramters.Target_Type == "Hero" then
        -- 目标设置为主角
    end
end