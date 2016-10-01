--
-- Des: 改变血量的行为Action阶段
-- Author: John
-- Date: 2015-08-25 17:43:24
-- 
Action_Reborn = Action:new()

function Action_Reborn:ctor()
    report_dt('[testfunc]Action ChangeHp')
end 

function Action_Reborn:open(tick)
    -- nohing
end

function Action_Reborn:tick(tick)
    print("复活")
    tick.target.hp = 100
    return Status.SUCCESS
end