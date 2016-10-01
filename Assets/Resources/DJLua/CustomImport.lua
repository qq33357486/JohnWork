-- ***********************************************************
-- 通用包
-- ***********************************************************
import "UnityEngine"
import "FairyGUI"
-- ***********************************************************

-- ***********************************************************
-- 自定义包
-- ***********************************************************
import "DJLuaTools"
-- ***********************************************************


-- ***********************************************************
-- 攻击包
-- ***********************************************************
require("DJLua/Library/dump")
require("DJLua/Library/Object")
-- ***********************************************************

-- ***********************************************************
-- 行为树所需要的基础包
-- ***********************************************************
require("DJLua.Behavior3Js.mod.behavior.util")
require("DJLua/Behavior3Js/mod/behavior/core/YJBehavior")

require("DJLua/Behavior3Js/mod.behavior.core.BaseNode")
require("DJLua/Behavior3Js/mod.behavior.core.Tick")
require("DJLua/Behavior3Js/mod.behavior.core.Action")
require("DJLua/Behavior3Js/mod.behavior.core.Composite")
require("DJLua/Behavior3Js/mod.behavior.core.Condition")
require("DJLua/Behavior3Js/mod.behavior.core.Decorator")
require("DJLua/Behavior3Js/mod.behavior.core.Blackboard")
require("DJLua/Behavior3Js/mod.behavior.composites.Priority")
require("DJLua/Behavior3Js/mod.behavior.composites.Sequence")
require("DJLua/Behavior3Js/mod.behavior.composites.MemSequence")
require("DJLua/Behavior3Js/mod.behavior.composites.AllSequence")
require("DJLua/Behavior3Js/mod.behavior.actions.Wait")
require("DJLua/Behavior3Js/mod.behavior.conditions.EqualCondition")
-- ***********************************************************

-- ***********************************************************
-- 游戏逻辑所需要的包
-- ***********************************************************

-- 条件包
require("DJLua/Behavior3Js/mod.behavior.conditions.Condition_IsDead")

-- 事件包
require("DJLua/Behavior3Js/mod.behavior.actions.Action_ChangeHp")
require("DJLua/Behavior3Js/mod.behavior.actions.Action_Reborn")

-- ***********************************************************

local mClass = { }

function main()
    return mClass
end