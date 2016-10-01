--
-- Des: 健康感知器的Condition方法。
-- Author: John
-- Date: 2016年9月19日 星期一 农历八月十九
--

Condition_Perception_Radar = Condition:new()

-- 对于Condition节点来说，tick就是询问函数咯
function Condition_Perception_Radar:tick(tick)
    return tick.target.Ai.askPerception("P_Radar", self.parameters.AskType, self.parameters)
end 