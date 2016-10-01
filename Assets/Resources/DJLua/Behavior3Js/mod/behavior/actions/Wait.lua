--
-- Author: yang jian 181269573@qq.com
-- Date: 2015-08-25 17:43:24
-- 
Wait = Action:new()
Wait.endTime = 0 

function Wait:open(tick)
    local startTime = os.clock()
    self.endTime = self.parameters.milliseconds
    tick.blackboard:set('startTime', startTime, tick.tree.id, self.id)
end

function Wait:tick(tick)
    local currTime = os.clock()
    local startTime = tick.blackboard:get('startTime', tick.tree.id, self.id)
    -- report_dt("[wait]" .. "   " .. currTime .. "   " .. startTime .. "   " .. self.endTime)
    if (currTime - startTime) > self.endTime then
        return Status.SUCCESS
    end
    return Status.RUNNING
end