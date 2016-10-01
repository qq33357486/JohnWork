--
-- Des: 通用行为节点
-- Author: John
-- Date: 2016年9月19日 星期一 农历八月十九
-- Docment url: https://worktile.com/project/ff9e093759b04c258f531c3b39808063/page/bf5a9c7322314b3abe5b609c12d01f85
-- 
Action_CommonBehavior = Action:new()

----------------------------------------------------------------------------------------------
---- 继承函数
----------------------------------------------------------------------------------------------

function Action_CommonBehavior:ctor()
    report_dt('[testfunc]Action CommonBehavior')
end 

function Action_CommonBehavior:open(tick)
    -- nohing
end

function Action_CommonBehavior:tick(tick)
    local F_Type = self.parameters.F_Type
    if F_Type == "MoveToTarget" then
        self:MoveToTarget(tick)
    else
        error("未知的通用事件类型：" .. F_Type)
    end

    return Status.SUCCESS
end

----------------------------------------------------------------------------------------------
---- 内部逻辑 (说明文档里都有)
----------------------------------------------------------------------------------------------

function Action_CommonBehavior:MoveToTarget(tick)
    local Move_Type = self.paramters.Move_Type
    if Move_Type == "Force" then

    elseif Move_Type == "Normal" then

    else

        error("MoveToTarget事件，未知的移动类型:" .. Move_Type)
        return
    end

    print("移动至目标,移动类型:" .. MoveType)
end
