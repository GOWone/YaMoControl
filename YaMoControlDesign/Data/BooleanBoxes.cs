/*********************************************************************
 * Copyright(c) YaMoStudio All Rights Reserved.
 * 开发者：YaMoStudio
 * 命名空间：YaMoControlDesign.Data
 * 文件名：BooleanBoxes
 * 版本号：V1.0.0.0
 * 创建时间：2024/5/4 21:18:26
 ******************************************************/

namespace YaMoControlDesign.Data
{
    internal static class BooleanBoxes
    {
        internal static object TrueBox = true;

        internal static object FalseBox = false;

        internal static object Box(bool value)
        {
            if (value)
            {
                return TrueBox;
            }

            return FalseBox;
        }
    }
}
