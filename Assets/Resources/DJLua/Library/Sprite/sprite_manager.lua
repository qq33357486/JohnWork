--
-- Created by IntelliJ IDEA.
-- User: Baron
-- Date: 9/7/2016
-- Time: 8:21 AM
-- 
--


--requrie "Isprite"
require "sprite_base"
require "sprite_player"


sprite_manager = Class.define("sprite_manager")

sprite_manager.Hero = nil;

----------------------------------------------------------------------------------------------
---- 单例对象
----------------------------------------------------------------------------------------------

function sprite_manager:get_instance()
    if not self.m_instance then
        self.m_instance = Class.new(sprite_manager)
    end
    return self.m_instance
end


----------------------------------------------------------------------------------------------
---- 构造
----------------------------------------------------------------------------------------------
function sprite_manager:_ctor()

    -- default hero id
    self.hero_id = -1
    self.hero_name = "default"
    self.sprites = {
        ["1"] = {}, -- 角色队列
        ["2"] = {}, -- 怪物
        ["3"] = {}  -- 宝宝
    } -- 精灵队列



    self.listener = dispatcher.get_listener_owner(self.className)
    --位置同步：服务器返回消息
    dispatcher.on_g_message(self.listener, "protocol_rec_10601", function(args)
        self:move_handler(args)
    end)
end





----------------------------------------------------------------------------------------------
---- 根据id查找一个精灵
----------------------------------------------------------------------------------------------
function sprite_manager:find_sprite(_type, _id)
    if _id == self.hero_id then
        return sprite_manager.Hero;
    end

    -- 先根据类型查找
    local type_table = self.sprites[_type]
    if not type_table then
        return nil
    end

    -- 再根据id查找
    local find_sprite = type_table[_id]

    return find_sprite

end


----------------------------------------------------------------------------------------------
---- 位置同步：服务器返回移动指令处理
----------------------------------------------------------------------------------------------
function sprite_manager:move_handler(_args)
    if _args then
        local find_sprite = self:find_sprite("1",_args.roleId)
        if  find_sprite then
            find_sprite:move_handler(_args)
        end
    end
end






