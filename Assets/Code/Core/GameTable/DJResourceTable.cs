//// ===============================================================================
// Project Name        :    DJResourceTable.cs
// Class Description   :    资源表的定义文件
// Author              :    John
// Create Time         :    2016年8月6日 星期六 农历七月初四
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================

using System.Collections.Generic;
using DJAssetsDefine;

public class DJResourceTable : DJTableBase
{
    public List<DJAssetDataModel> Datas;

    public override void Init()
    {
        Datas = new List<DJAssetDataModel>();
    }
}
