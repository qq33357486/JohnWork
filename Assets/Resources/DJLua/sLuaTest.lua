--
-- User: John
-- Date: 2016年10月1日 星期六 农历九月初一
-- Des: lua的测试脚本

local mClass = { }

function main()
    Debug.Log("我被加载了");
    return mClass
end

-- 节点被单击
function mClass:testClick()
    Debug.Log("我被点击了")
end

