--
-- Des: 清空感知器队列
-- Author: John
-- Date: 2016年9月19日 星期一 农历八月十九
-- 
Action_ClearPerceptionList = Action:new()

function Action_ClearPerceptionList:ctor()
    report_dt('[testfunc]Action RegistPerception')
end 

function Action_ClearPerceptionList:open(tick)
    -- nohing
end

function Action_ClearPerceptionList:tick(tick)
    tick.target.Ai.clearPerceptionList()
    return Status.SUCCESS
end