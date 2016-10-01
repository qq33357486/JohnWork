--
-- Des: 技能行为事件
-- Author: John
-- Date: 2016年9月19日 星期一 农历八月十九
-- Docment url: https://worktile.com/project/ff9e093759b04c258f531c3b39808063/page/b1a23a4b4e2b43d098ea64aec531f71b
-- 
Action_Spell = Action:new()

----------------------------------------------------------------------------------------------
---- 继承函数
----------------------------------------------------------------------------------------------

function Action_Spell:ctor()
    report_dt('[testfunc]Action FightBehavior')
end 

function Action_Spell:open(tick)
    -- nohing
end

function Action_Spell:tick(tick)
    local F_Type = self.parameters.F_Type
    if F_Type == "AutoFitCast" then
        self:AutoFitCast(tick)
    elseif F_Type == "SpecifyCast" then
        self:SpecifyCast(tick)
    else
        error("未知的技能事件，事件类型：" .. F_Type)
    end

    return Status.SUCCESS
end

----------------------------------------------------------------------------------------------
---- 内部逻辑 (说明文档里都有)
----------------------------------------------------------------------------------------------

-- 说明： 自动选择合适的技能进行释放。
function Action_Spell:AutoFitCast(tick)
    print("自适配技能释放")
end

-- 说明： 释放指定技能，可以强制释放，也可以满足条件释放。
function Action_Spell:SpecifyCast(tick)
    local Spell = self.parameters.Spell
    local IsForce = self.parameters.IsForce

    print("释放了技能：" .. Spell .. "强制状态为：" .. IsForce)
end