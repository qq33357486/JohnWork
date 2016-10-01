if not UnityEngine.GameObject or not  UnityEngine.UI then
	error ("Click Make/All to generate lua wrap file")
end

local mClass = {}

function main ()
	mClass._mainView = GameObject.Find ("UIPanel");
	if not mClass._mainView  then
		error ("找不到物体:UIPanel")
		return
	end
	mClass._panel = mClass._mainView:GetComponent ("UIPanel")
	if not mClass._panel  then
		error ("找不到组件")
		return
	end
	print("1")
	mClass.ui = mClass._panel.ui
	n1 = mClass.ui:GetChild ("n1")
	n2 = mClass.ui:GetChild ("n2")
	mClass.asLoader = n2.asLoader
	child = n1.onClick
	child:Clear ()
	print ("2")
	child:Add (function ()
		print("4")
		if not mClass.asLoader then
			error ("装载器找不到")
		end
		if not mClass.asLoader.url then
			error ("找不到装载器的url")
		end
		item = UIPackage.GetItemURL ("DJFairyUI_Test", "Button_Grey")
		if not item then
			error ("没找到图集资源")
		end
	end)
	print("3")
	return mClass
end

-- 节点被单击
function nodeClick (_agent)

-- 实际上要去调用别处实现的子节点，就需要暴露出Lua接口
	Debug.Log ("123")
	Debug.Log (_agent.Name)

end

