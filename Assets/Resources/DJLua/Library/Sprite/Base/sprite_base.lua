--
-- Created by IntelliJ IDEA.
-- User: Baron
-- Date: 9/2/2016
-- Time: 4:04 AM
-- 
--

require "Isprite"
require "property_define"

sprite_base = Class.define("sprite_base", Object, Isprite)

function sprite_base:ctor(_id, _model_name)

    -- 精灵id
    self.id = _id

    -- 模型名称
    self.model_name = _model_name

    --是否是在多人pvp，是否需要同步位置（暂时放这里）
    self.isin_morepvp = false


    if not self.id then
        self.id = random_number(16) -- 随机一个16位长度的id
    end

    -- 精灵名字
    self.name = "baron"

    -- 属性队列
    self.runtime_datas = {
        -- 格式 id = value

    }

    -- 精灵的behaviour对象
    self.sprite_behaviour = {}
end


----------------------------------------------------------------------------------------------
---- init
----------------------------------------------------------------------------------------------
function sprite_base:init()

    -- 获取一个模型
    if self.model_name then
        self.sprite_behaviour = HKSpriteManager.Instance:GetSpriteGameObject(self.model_name, 3, nil)
    end


end


----------------------------------------------------------------------------------------------
---- 出生
----------------------------------------------------------------------------------------------

function sprite_base:birth()


end

----------------------------------------------------------------------------------------------
---- run
----------------------------------------------------------------------------------------------
function sprite_base:run()
    if self.sprite_behaviour and self.sprite_behaviour.sprite_animator then

        if not self.sprite_behaviour.sprite_animator:GetBool("is_run") then
            if false == self.isin_morepvp then
                self.sprite_behaviour:PlayAnimationWithLoop("Run", 0, 0)
            else --同步位置
                self.sprite_behaviour:ChangeJoystickState(true)
            end
        end

    end
end



----------------------------------------------------------------------------------------------
---- idle
----------------------------------------------------------------------------------------------

function sprite_base:idle()
    if false == self.isin_morepvp then
        if self.sprite_behaviour.sprite_animator:GetBool("is_run") then
            self.sprite_behaviour:PlayAnimation("Stand", 0.2, 0)
            self.sprite_behaviour.sprite_animator:SetBool("is_run", false)
        end
    else --同步位置
        --位置同步：主角的情况下，场景验证目前是放在了c#中，待之后确认放哪里
        if sprite_manager.Hero  and self.id == sprite_manager.Hero.id then
            self.sprite_behaviour:StopMove()
        end
    end
end


----------------------------------------------------------------------------------------------
---- 旋转到目标角度
----------------------------------------------------------------------------------------------

function sprite_base:rotate(_angle)
    if self.sprite_behaviour then
        self.sprite_behaviour:Rotate(_angle)
    end

end


