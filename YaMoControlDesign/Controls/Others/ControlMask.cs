﻿/*********************************************************************
 * Copyright(c) YaMoStudio All Rights Reserved.
 * 开发者：YaMoStudio
 * 命名空间：YaMoControlDesign.Controls.Others
 * 文件名：ControlMask
 * 版本号：V1.0.0.0
 * 创建时间：2024/5/4 21:36:25
 ******************************************************/
using System.Windows;
using System.Windows.Controls;
using YaMoControlDesign.Data;

namespace YaMoControlDesign.Controls
{
    /// <summary>
    /// 控件遮罩
    /// 用于提供 MouseOver 和 Pressed 等效果
    /// </summary>
    public class ControlMask : Control
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlMask"/> class.
        /// </summary>
        static ControlMask()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ControlMask), new FrameworkPropertyMetadata(typeof(ControlMask)));
        }

        /// <summary>
        /// 是否激活
        /// </summary>
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register(
            "IsActive", typeof(bool), typeof(ControlMask), new PropertyMetadata(BooleanBoxes.FalseBox));

        /// <summary>
        /// 是否激活
        /// </summary>
        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, BooleanBoxes.Box(value)); }
        }

        /// <summary>
        /// 圆角半径
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
            "CornerRadius", typeof(CornerRadius), typeof(ControlMask), new PropertyMetadata(default(CornerRadius)));

        /// <summary>
        /// 圆角半径
        /// </summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        /// <summary>
        /// 遮罩透明度
        /// </summary>
        public static readonly DependencyProperty MaskOpacityProperty = DependencyProperty.Register(
            "MaskOpacity", typeof(double), typeof(ControlMask), new PropertyMetadata(default(double)));

        /// <summary>
        /// 遮罩透明度
        /// </summary>
        public double MaskOpacity
        {
            get { return (double)GetValue(MaskOpacityProperty); }
            set { SetValue(MaskOpacityProperty, value); }
        }

        /// <summary>
        /// 父元素 (用于出发 IsMouseOver)
        /// </summary>
        public static readonly DependencyProperty ParentElementProperty = DependencyProperty.Register(
            "ParentElement", typeof(UIElement), typeof(ControlMask), new PropertyMetadata(default(UIElement)));

        /// <summary>
        /// 父元素 (用于出发 IsMouseOver)
        /// </summary>
        public UIElement ParentElement
        {
            get { return (UIElement)GetValue(ParentElementProperty); }
            set { SetValue(ParentElementProperty, value); }
        }
    }
}
