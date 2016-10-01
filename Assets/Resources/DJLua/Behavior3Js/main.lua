-- require "config"
-- require "cocos.init"

local mClass = { }

-- cclog
cclog = function(_str)
    print(string.format(_str))
end

hero = { }

function mClass:testbt()
    hero.hp = 100
    self.bt = YJBehavior:new("我的树")
    self.b = Blackboard:new()
    self.bt:load("DJLua/Behavior3Js/test_john")
    hero.Ai = self.bt

    -- 下面的用法是在每一帧里面去条用tick  具体使用具体嵌入tick就好了
    -- local callback_time = nil
    -- local running_tick = function (  )
    --     local s = bt:tick( "hello" , b  )
    --     -- report_dt("tick state2 == > ".. s .. "|||" ..callback_time  )
    --     if s ~= Status.RUNNING     then
    --         running_lib_del_by_time(callback_time)
    --     end
    -- end
    -- callback_time = running_lib_reg(  running_tick , 1000   )
end
function __G__TRACKBACK__bt(msg)
    cclog("----------------------------------------")
    cclog("__G__TRACKBACK__bt: " .. tostring(msg) .. "\n")
    cclog(debug.traceback())
    cclog("----------------------------------------")
end

function mClass:RunOnce()
    --    print("执行一次，" .. type(bt) .. "  ,  " .. bt.title)
    self.bt:tick(hero, self.b)
end

function main()
    return mClass
end

