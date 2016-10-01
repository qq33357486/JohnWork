//// ===============================================================================
// Project Name        :    DJAssetsDefine.cs
// Class Description   :    资源管理器的定义文件
// Author              :    John
// Create Time         :    2016年7月26日 星期二 农历六月廿三
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================

using System.Collections.Generic;
using DJAssetsDefine;

public class DJAssetTypeTable : DJTableBase
{
    public List<AssetsConfig> Datas;

    public override void Init()
    {
        base.Init();
        Datas = new List<AssetsConfig>();
    }
}
