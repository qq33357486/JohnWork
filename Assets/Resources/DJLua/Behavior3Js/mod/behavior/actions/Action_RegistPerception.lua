--
-- Des: 注册感知器的事件
-- Author: John
-- Date: 2016年9月19日 星期一 农历八月十九
-- 
Action_RegistPerception = Action:new()

function Action_RegistPerception:ctor()
    report_dt('[testfunc]Action RegistPerception')
end 

function Action_RegistPerception:open(tick)
    -- nohing
end

function Action_RegistPerception:tick(tick)
    tick.target.Ai.registPerception(self.parameters.P_Type)
    return Status.SUCCESS
end