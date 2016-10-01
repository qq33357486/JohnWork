--
-- Author: yang jian 181269573@qq.com
-- Date: 2015-08-27 15:37:36
--
Condition_IsDead = Condition:new()

function Condition_IsDead:tick(tick)
    -- print("判断是否死亡")
    if tick.target.hp <= 0 then
        return Status.SUCCESS
    else
        return Status.FAILURE
    end
end 