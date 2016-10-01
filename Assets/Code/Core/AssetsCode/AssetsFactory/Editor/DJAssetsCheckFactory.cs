// ===============================================================================
// Project Name        :    DJAssetsCheckFactory.cs
// Class Description   :    资源检测的脚本工厂
// Author              :    John
// Create Time         :    2016年8月14日 星期日 农历七月十二
// ===============================================================================
// Copyright © John 2016 . All rights reserved.
// ===============================================================================

using DJAssetsDefine;

public class DJAssetsCheckFactory
{
    public static DJAssetsCheckBase GetCheckUnit(AssetType _type)
    {
        switch (_type)
        {
            case AssetType.Audio:
                return new DJAssetCheckUnit_Audiu();
        }
        return null;
    }
}
