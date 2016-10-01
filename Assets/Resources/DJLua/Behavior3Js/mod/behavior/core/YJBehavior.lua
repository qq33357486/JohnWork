--
-- Author: yang jian 181269573@qq.com
-- Date: 2015-08-20 16:28:28
--

----------------------------------------------------------------------------------------------
---- 全局变量
----------------------------------------------------------------------------------------------

-- 行为树节点类型的定义
YJBehavior_enumTable = {
    composite = "composite",
    -- 复合节点
    decorator = "decorator",
    -- 装饰节点
    action = "action",
    -- 行动节点
    condition = "condition",-- 条件节点
}

-- 行为树返回状态的定义
Status = {
    SUCCESS = "SUCCESS",
    --
    FAILURE = "FAILURE",
    --
    RUNNING = "RUNNING",
    --
    ERROR = "ERROR"--
}


-- 混合节点表
YJBehavior_real_func = { }

-- 功能节点
YJBehavior_func_names = { }

-- 全局是否初始化
YJBehavior_IsInit = false


----------------------------------------------------------------------------------------------
---- 全局函数
----------------------------------------------------------------------------------------------
-- 不知道为什么全局定义会失效，所以手动的初始化这些字典定义
function InitDict()
    if YJBehavior_IsInit == true then
        return
    end

    -- 混合节点
    YJBehavior_real_func.Priority = Priority
    YJBehavior_real_func.Sequence = Sequence
    YJBehavior_real_func.AllSequence = AllSequence
    YJBehavior_real_func.MemSequence = MemSequence

    -- ACTION
    YJBehavior_func_names.Wait = Wait
    YJBehavior_func_names.ClearPerceptions = Action_ClearPerceptionList
    YJBehavior_func_names.RegistPerception = Action_RegistPerception
    YJBehavior_func_names.FightBehavior = Action_FightBehavior
    YJBehavior_func_names.Action_Spell = Action_Spell
    YJBehavior_func_names.CommonBehavior = Action_CommonBehavior

    -- conditions
    YJBehavior_func_names.Perception_Health = Condition_Perception_Health
    YJBehavior_func_names.Perception_Radar = Condition_Perception_Radar

    -- decorator
    -- YJBehavior_func_names.testDecorator = testDecorator

    YJBehavior_IsInit = true
end

----------------------------------------------------------------------------------------------
---- 类定义
----------------------------------------------------------------------------------------------
-- 树根节点
YJBehavior = { }
-- YJBehavior.tick = nil

-- 感知器队列
YJBehavior.perceptionsList = { }

----------------------------------------------------------------------------------------------
---- 内部函数
----------------------------------------------------------------------------------------------

local json = require("DJLua/Library/json")

local _bt_obj = { }
_bt_obj.map = { }
_bt_obj.rootNode = { }
_bt_obj.nodes = { }
_bt_obj.custom_nodes = { }
function YJBehavior:new(title)
    o = { }
    setmetatable(o, self)
    self.__index = self
    print("生成了一颗新树,名字叫:" .. title)
    self.id = bt_getuuid()
    self.title = title
    self.description = 'Default description'
    self.properties = { }
    self.root = nil
    self.debug = nil
    InitDict()
    return o
end 

function YJBehavior:load(path)
    -- 读取json文件
    local text = Rs.LoadText(path)
    if text.size == 0 then
        print("空的")
    end
    --    print(text)
    -- local fileUtils = cc.FileUtils:getInstance()
    -- local fullpath = fileUtils:fullPathForFilename( path )
    _bt_obj.map = json.decode(text)
    _bt_obj.rootNode = _bt_obj.map.root
    _bt_obj.nodes = _bt_obj.map.nodes
    for i, v in ipairs(_bt_obj.map.custom_nodes) do
        _bt_obj.custom_nodes[v.name] = v
    end

    dump(_bt_obj.map, "[_bt_obj] .map  =>")
    dump(_bt_obj.rootNode, "[_bt_obj] rootNode  =>")
    dump(_bt_obj.nodes, "[_bt_obj] nodes  =>")
    dump(_bt_obj.custom_nodes, "[_bt_obj] custom_nodes  =>")

    local tree_nodes = { }
    for k, v in pairs(_bt_obj.nodes) do
        local spec = v
        local cls
        if YJBehavior_real_func[spec.name] then
            cls = YJBehavior_real_func[spec.name]
        elseif YJBehavior_func_names[spec.name] then
            cls = YJBehavior_func_names[spec.name]
        else
            report_dt('BehaviorTree.load: Invalid node name + "' .. spec.name .. '".')
        end
        if cls then
            local node = cls:new(spec)
            node:setObj(spec)
            node.id = spec.id or node.id
            node.title = spec.title or node.title
            node.description = spec.description or node.description
            node.properties = spec.properties or node.properties
            node.parameters = spec.parameters or node.parameters
            -- print(node.id .. "  : " .. node.name)
            tree_nodes[node.id] = node
        else
            error("cls is nil. spec name :" .. spec.name);
        end

    end

    -- Connect the nodes
    for id, v in pairs(_bt_obj.nodes) do
        local spec = _bt_obj.nodes[id]
        local node = tree_nodes[id]
        if node == nil then
            error("Node为空：" + id)
        end
        if node.category == YJBehavior_enumTable.composite and spec.children then
            dump(node, "node")
            dump(spec, "spec")
            for i = 1, #node.children do
                local cid = spec.children[i]
                -- print("父：" .. node.name .. " 子:" .. tree_nodes[cid].name)
                table.insert(node.children, tree_nodes[cid])
            end
        elseif node.category == YJBehavior_enumTable.decorator and spec.child then
            local cid = spec.child
            -- print("父：" .. node.name .. " 子:" .. tree_nodes[cid].name)
            node.child = tree_nodes[cid]
        end
    end
    self.id = tree_nodes[_bt_obj.rootNode].id
    self.root = tree_nodes[_bt_obj.rootNode]
    -- print(self.id .. "  :  " .. self.root.name)
    -- dump(tree_nodes, "tree_nodes")
end


function YJBehavior:tick(target, blackboard)

    --    print("进入树")
    local tick = Tick:new()
    tick.debug = self.debug
    tick.target = target
    tick.blackboard = blackboard
    tick.tree = self
    --    print("根节点ID:" .. self.root.name)
    local state = self.root:_execute(tick)

    -- 循环感知器队列，进行刷帧行为
    for _key, _value in pairs(self.perceptionsList) do
        print("被执行的感知器" .. _value.name)
    end

    return state
end

----------------------------------------------------------------------------------------------
---- 外部接口函数
----------------------------------------------------------------------------------------------

-- 添加感知器
-- 参数：感知器类型
function YJBehavior:registPerception(_perceptionType)
    local perception = nil
    local fac = nil
    local perception = nil

    -- 得到工厂
    fac = behavior_factory:get_instance()
    -- 得到感知器
    perception = fac.getPerception(_perceptionType)
    if perception == nil then
        return
    end

    -- 初始化感知器
    perception.init(self.owner)

    -- 加入到感知器队列种
    self.perceptionsList[_perceptionType] = perception

    print("感知器成功加入到队列种： " .. _perceptionType)
end

-- 询问感知器
-- _perceptionType： 感知器类型
-- _askType： 询问类型
-- ... ： 感知器的可变参数
function YJBehavior:askPerception(_perceptionType, _askType, _args)
    -- 得到感知器
    local perception = self.perceptionsList[_perceptionType]
    if perception == nil then
        -- 这种断言时候要换成工具的！
        assert(true)
        error("没有找到感知器:" .. _perceptionType)
        return YJBehavior.Status.FAILURE
    end

    -- 询问感知器,然后将结果转义成行为树要的返回
    if perception.Ask(_askType, _args) == true then
        return YJBehavior.Status.SUCCESS
    else
        return YJBehavior.Status.FAILURE
    end
end

-- 清空感知器
function YJBehavior:clearPerceptionList()
    self.perceptionsList = { }
end
