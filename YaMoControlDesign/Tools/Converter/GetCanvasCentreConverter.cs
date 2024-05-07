/*********************************************************************
 * Copyright(c) YaMoStudio All Rights Reserved.
 * 开发者：YaMoStudio
 * 命名空间：YaMoControlDesign.Tools.Converter
 * 文件名：GetCanvasCentreConverter
 * 版本号：V1.0.0.0
 * 创建时间：2024/5/4 21:45:17
 ******************************************************/
using System;
using System.Globalization;
using System.Windows.Data;

namespace YaMoControlDesign.Tools.Converter
{
    /// <summary>
    /// 获取 Canvas 中心点
    /// </summary>
    public class GetCanvasCentreConverter : IMultiValueConverter
    {
        /// <inheritdoc/>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return ((double)values[0] - (double)values[1]) / 2;
        }

        /// <inheritdoc/>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
