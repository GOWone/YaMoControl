/*********************************************************************
 * Copyright(c) YaMoStudio All Rights Reserved.
 * 开发者：YaMoStudio
 * 命名空间：YaMoControlDesign.Controls.HambugerMenu
 * 文件名：HamburgerMenuItemCollection
 * 版本号：V1.0.0.0
 * 创建时间：2024/5/4 22:00:19
 ******************************************************/
using System.Windows;

namespace YaMoControlDesign.Controls
{
    /// <summary>
    /// The HamburgerMenuItemCollection provides typed collection of HamburgerMenuItemBase.
    /// form https://github.com/MahApps/MahApps.Metro
    /// MahApps.Metro.Controls.HamburgerMenu
    /// </summary>
    public class HamburgerMenuItemCollection : FreezableCollection<HamburgerMenuOptionsItem>
    {
        /// <inheritdoc/>
        protected override Freezable CreateInstanceCore()
        {
            return new HamburgerMenuItemCollection();
        }
    }
}
