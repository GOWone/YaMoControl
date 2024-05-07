/*********************************************************************
 * Copyright(c) YaMoStudio All Rights Reserved.
 * 开发者：YaMoStudio
 * 命名空间：YaMoControlDesign.Controls.HambugerMenu
 * 文件名：HamburgerMenuOptions
 * 版本号：V1.0.0.0
 * 创建时间：2024/5/4 21:28:46
 ******************************************************/
using System.Windows;
using System.Windows.Controls;

namespace YaMoControlDesign.Controls
{
    /// <summary>
    /// 汉堡包菜单选项控件
    /// </summary>
    [StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(HamburgerMenuOptionsItem))]
    public class HamburgerMenuOptions : Menu
    {
        static HamburgerMenuOptions()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HamburgerMenuOptions), new FrameworkPropertyMetadata(typeof(HamburgerMenuOptions)));
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
