/*********************************************************************
 * Copyright(c) YaMoStudio All Rights Reserved.
 * 开发者：YaMoStudio
 * 命名空间：YaMoControlDesign.Controls.HambugerMenu
 * 文件名：HamburgerMenuOptionsItem
 * 版本号：V1.0.0.0
 * 创建时间：2024/5/4 21:21:30
 ******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using YaMoControlDesign.Data;

namespace YaMoControlDesign.Controls
{
    /// <summary>
    /// HamburgerMenuOptionsItem
    /// </summary>
    [StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(HamburgerMenuOptionsItem))]
    public class HamburgerMenuOptionsItem : MenuItem
    {
        #region properties

        /// <summary>
        /// 图标类型
        /// </summary>
        public static readonly DependencyProperty IconTypeProperty = DependencyProperty.Register(
            "IconType", typeof(IconType?), typeof(HamburgerMenuOptionsItem), new PropertyMetadata(null));

        /// <summary>
        /// 图标类型
        /// </summary>
        public IconType? IconType
        {
            get { return (IconType?)GetValue(IconTypeProperty); }
            set { SetValue(IconTypeProperty, value); }
        }

        #endregion properties
        static HamburgerMenuOptionsItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HamburgerMenuOptionsItem), new FrameworkPropertyMetadata(typeof(HamburgerMenuOptionsItem)));
        }

        /// <inheritdoc/>
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is HamburgerMenuOptionsItem;
        }

        /// <inheritdoc/>
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new HamburgerMenuOptionsItem();
        }
    }
}
