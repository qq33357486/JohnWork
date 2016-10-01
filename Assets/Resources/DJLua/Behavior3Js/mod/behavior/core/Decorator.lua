--
-- Author: yang jian 181269573@qq.com
-- Date: 2015-08-23 15:48:05
--  
Decorator = BaseNode:new()
Decorator.category = YJBehavior_enumTable.decorator

function Decorator:new()
    o = Decorator
    report_dt("Decorator:new ")
    settings = settings or { }
    o.child = settings.child or nil;
    return o
end

function Decorator:tick(tick)
    report_dt("Decorator:tick ")
end


-- function Decorator:close( tick, status)

-- end

