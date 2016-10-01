--
-- Author: yang jian 181269573@qq.com
-- Date: 2015-08-23 17:24:26
--
--- 序列节点（按从上到下顺序执行），可以执行>=1个子节点，有一个返回非成功，就中断，返回
Sequence = Composite:new()
Sequence.category = YJBehavior_enumTable.composite

function Sequence:tick(tick)
    for id, v in pairs(self.children) do
        if type(v) == "table" then
            -- print("顺序节点：" .. v.name)
            local status = v:_execute(tick)
            if status ~= Status.SUCCESS then
                return status
            end
            --        else
            --            print("错误的节点类型:" .. type(v) .. "  " .. v)
        end
    end
    return Status.SUCCESS
end   