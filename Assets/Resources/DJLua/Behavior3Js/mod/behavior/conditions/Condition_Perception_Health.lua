--
-- Des: 健康感知器的Condition方法。
-- Author: John
-- Date: 2016年9月19日 星期一 农历八月十九
--

Condition_Perception_Health = Condition:new()

-- 对于Condition节点来说，tick就是询问函数咯
function Condition_Perception_Health:tick(tick)
    return tick.target.Ai.askPerception("P_Health", self.parameters.AskType, self.parameters)
end 