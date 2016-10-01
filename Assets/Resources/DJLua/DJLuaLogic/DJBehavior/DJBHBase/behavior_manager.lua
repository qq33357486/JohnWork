--
-- Des: 行为树的管理器，行为树的添加移除，刷帧放到这边。这样别人也能维护
-- Author: John
-- Date: 2016年9月18日 星期日 农历八月十八
--


-- requrie "Isprite"
require "sprite_base"
require "sprite_player"


behavior_manager = Class.define("DJBehaviorTreeManager")

----------------------------------------------------------------------------------------------
---- 表内变量
----------------------------------------------------------------------------------------------

-- 已经被生成的行为树字典
-- key : sprite
-- value : tree
behavior_mamnager.treeDict = nil

----------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------
---- 继承函数
----------------------------------------------------------------------------------------------

-- 单例
function behavior_manager:get_instance()
    if not self.m_instance then
        self.m_instance = Class.new(behavior_manager)
    end
    return self.m_instance
end

-- 构造
function behavior_manager:_ctor()

    -- 初始化内部变量
    behavior_manager.treeDict = { }

end

----------------------------------------------------------------------------------------------
---- 内部逻辑
----------------------------------------------------------------------------------------------




----------------------------------------------------------------------------------------------
---- 外部接口
----------------------------------------------------------------------------------------------

-- 给精灵创建一个新AI
function behavior_manager:CreateAI(_sprite)
end

-- 移除精灵身上的AI
function behavior_manager:RemoveAi(_sprite)
end

-- 关闭AI
function behavior_manager:CloseAi(_sprite)
end

-- 开启AI
function behavior_manager:OpenAi(_sprite)
end

-- 关闭所有Ai
function behavior_manager:CloseAllAi()
end

-- 开启所有对象的Ai
function behavior_manager:OpenAllAi()
end

----------------------------------------------------------------------------------------------
---- 通信接口
----------------------------------------------------------------------------------------------
function behavior_manager:move_handler(_args)
    if _args then
        local find_sprite = self:find_sprite("1", _args.roleId)
        if find_sprite then
            find_sprite:move_handler(_args)
        end
    end
end






