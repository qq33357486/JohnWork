--
-- Author: yang jian 181269573@qq.com
-- Date: 2015-08-19 17:10:41
--
-- change table to enum type



-- BaseNode = class("BaseNode")
BaseNode = { }
-- BaseNode.__index = BaseNode   -- 用于访问
BaseNode.category = nil
BaseNode.name = nil
BaseNode.title = nil
BaseNode.description = nil
BaseNode.id = nil
BaseNode.parameters = { }
BaseNode.properties = { }
BaseNode.children = nil
BaseNode.child = nil
BaseNode.display = nil
BaseNode.tick = nil 

-- 打印日志
function BaseNode:log(str)
    print(self.name .. ":" .. str)
end

function BaseNode:new()
    o = { }
    setmetatable(o, self)
    self.__index = self
    self.id = bt_getuuid()
    self.description = ""
    return o
end

function BaseNode:setObj(setting)
    print("基类被初始化了:" .. setting.name)
    self.name = setting.name or "基础节点"
    self.title = setting.title or self.name
    self.description = ""
    -- cclog( "self.name ==>"..setting.name  )
end


--[[
     * This is the main method to propagate the tick signal to this node. This
     * method calls all callbacks: `enter`, `open`, `tick`, `close`, and
     * `exit`. It only opens a node if it is not already open. In the same
     * way, this method only close a node if the node  returned a status
     * different of `b3.RUNNING`.
     *
     * @method _execute
     * @param {Tick} tick A tick instance.
     * @returns {Constant} The tick state.
     * @protected
]]
function BaseNode:_execute(tick)
    --  /* ENTER */
    self:_enter(tick);

    -- print("this is _excute: " .. self.name)

    -- /* OPEN */
    if not tick.blackboard:get('isOpen', tick.tree.id, self.id) then
        -- print("tick.blackboard:get( 'isOpen', tick.tree.id, self.id ) == > " .. tostring(tick.blackboard:get('isOpen', tick.tree.id, self.id)))
        self:_open(tick)
    end
    -- /* TICK */
    local status = self:_tick(tick);

    -- /* CLOSE */
    if status ~= Status.RUNNING then
        self:_close(tick)
    end
    self:_exit(tick)
    return status
end

--[[  /**
     * Wrapper for enter method.
     *
     * @method _enter
     * @param {Tick} tick A tick instance.
     * @protected
    **/]] 
function BaseNode:_enter(tick)
    tick:_enterNode(self);
    self:enter(tick);
end

-- 节点打开时运行的函数
function BaseNode:_open(tick)
    tick:_openNode(self)
    tick.blackboard:set('isOpen', true, tick.tree.id, self.id);
    self:open(tick);
    if not tick.debug then
        tick.debug = ""
    end
    if self.name ~= nil then
        tick.debug = tick.debug .. self.name .. " == > "
        -- print("[tick.debug] " .. tick.debug)
    end
end

-- tick每段时间检测的时候执行函数 
function BaseNode:_tick(tick)
    tick:_tickNode(self);
    return self:tick(tick);
end

function BaseNode:_close(tick)
    tick:_closeNode(self);
    -- __G__TRACKBACK__bt("ticktickticktick")
    tick.blackboard:set('isOpen', false, tick.tree.id, self.id);
    self:close(tick)
end 
function BaseNode:_exit(tick)
    tick:_exitNode(self);
    self:exit(tick);
end 




function BaseNode:enter(tick)

end

function BaseNode:open(tick)
    -- report_dt("BaseNode:open ")
end 
function BaseNode:tick(tick)
    return Status.SUCCESS
end
function BaseNode:close(tick)

end
function BaseNode:exit(tick)

end

-- -- 类型 tick
-- function BaseNode:tick( tick)
--     return Status.SUCCESS
-- end
-- function BaseNode:execute( tick )
--     self:open( tick )
--     local status = self:tick(tick);
--     self:close(tick, status);
--     return status
-- end



function BaseNode:getId()
    return id
end

function BaseNode:setId(value)
    id = value
end

function BaseNode:getDescription()
    return self.description
end

function BaseNode:getName()
    return self.name
end

function BaseNode:setName(value)
    self.name = value
end

function BaseNode:getTitle()
    return self.title
end

function BaseNode:setTitle(value)
    self.title = value
end

function BaseNode:getParameters()
    return self.parameters
end

function BaseNode:setParameters(value)
    self.parameters = value
end

function BaseNode:getProperties()
    return self.properties
end

function BaseNode:setProperties(value)
    properties = value
end

-- 类别 
function BaseNode:getCategory()
    return self.category
end 

function BaseNode:getChildren()
    return self.children
end

function BaseNode:setChildren(value)
    self.children = value
end

function BaseNode:getChild()
    return self.child
end

function BaseNode:setChild(value)
    self.child = value
end

function BaseNode:getDisplay()
    return self.display
end

function BaseNode:setDisplay(value)
    self.display = value
end 

return BaseNode