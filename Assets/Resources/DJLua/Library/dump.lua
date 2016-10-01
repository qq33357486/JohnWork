--[[
dump对象
@param object obj
@return string
]]

function getIndent(level)
    return string.rep("\t", level)
end
function wrapKey(val)
    if type(val) == "number" then
        return "[" .. val .. "]"
    elseif type(val) == "string" then
        return '["' .. val .. '"]'
    else
        return "[" .. tostring(val) .. "]"
    end
end
function wrapVal(val, level)
    if type(val) == "table" then
        return dumpObj(val, level)
    elseif type(val) == "number" then
        return val
    elseif type(val) == "string" then
        return '"' .. val .. '"'
    else
        return tostring(val)
    end
end

function dumpObj(obj, level)
    if type(obj) ~= "table" then
        return wrapVal(obj)
    end
    level = level + 1
    local tokens = { }
    tokens[#tokens + 1] = "{"
    for k, v in pairs(obj) do
        tokens[#tokens + 1] = getIndent(level) .. wrapKey(k) .. " = " .. wrapVal(v, level) .. ","
    end
    tokens[#tokens + 1] = getIndent(level - 1) .. "}"
    return table.concat(tokens, "\n")
end

function dump(obj, _prefix)
    return dumpObj(obj, 0)
end