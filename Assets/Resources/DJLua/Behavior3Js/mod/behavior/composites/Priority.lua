--
-- Author: yang jian 181269573@qq.com
-- Date: 2015-08-23 17:24:33
--

Priority = Composite:new()
Priority.category = YJBehavior_enumTable.composite
 
function Priority:getName()
    return "Priority"
end

function Priority:tick(tick)
    -- local value = tick.getValue();
    for id, v in pairs(self.children) do
        if type(v) == "table" then
            local status = v:_execute(tick)
            if status ~= Status.FAILURE then
                return status
            end
            --        else
            --            print("错误的类型" .. type(v) .. "  " ..v)
        end
    end

    return Status.FAILURE
end 

return Priority 