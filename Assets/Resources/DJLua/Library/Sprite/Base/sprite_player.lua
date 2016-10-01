--
-- Created by IntelliJ IDEA.
-- User: Baron
-- Date: 9/2/2016
-- Time: 4:06 AM
-- 
--

require "sprite_base"

sprite_player = Class.define("sprite_player", sprite_base)

function sprite_player:ctor(_id, _model_name)
    self:super(sprite_player, "ctor", _id, _model_name)

end


----------------------------------------------------------------------------------------------
---- 位置同步：服务器返回移动指令处理
----------------------------------------------------------------------------------------------
function sprite_player:move_handler(_args)
    if nil == _args then
        return
    end
    if nil == self.sprite_behaviour then
        print("sprite_behaviour为空", dt())
        return
    end
    if nil == self.sprite_behaviour.sprite_transform then
        print("sprite_behaviour.sprite_transform为空" , dt())
        return
    end


    self.sprite_behaviour:MoveCmdHandler(_args)
end

