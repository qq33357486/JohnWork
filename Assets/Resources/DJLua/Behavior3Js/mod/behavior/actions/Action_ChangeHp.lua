--
-- Des: 改变血量的行为Action阶段
-- Author: John
-- Date: 2015-08-25 17:43:24
-- 
Action_ChangeHp = Action:new()

function Action_ChangeHp:tick(tick)
    tick.target.hp = tick.target.hp - self.parameters.hp
    print("减去血量:" .. self.parameters.hp .. "剩余" .. tick.target.hp)
    return Status.SUCCESS
end