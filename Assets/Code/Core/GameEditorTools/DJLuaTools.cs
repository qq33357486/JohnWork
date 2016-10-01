using UnityEngine;

namespace DJLuaTools
{
    /// <summary>
    /// 资源的
    /// </summary>
    public class Rs
    {
        /// <summary>
        /// 读取文本
        /// </summary>
        /// <param name="_path"></param>
        static public string LoadText(string _path)
        {
            var tex = Resources.Load(_path) as TextAsset;
            if (tex == null)
                Debug.LogError("没有找到资源:" + _path);
            return tex.text;
        }

    }
}


