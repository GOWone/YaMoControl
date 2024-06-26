﻿/*********************************************************************
 * Copyright(c) YaMoStudio All Rights Reserved.
 * 开发者：YaMoStudio
 * 命名空间：YaMoControlDesign.Controls.HambugerMenu
 * 文件名：HambugerMenu
 * 版本号：V1.0.0.0
 * 创建时间：2024/5/4 21:20:38
 ******************************************************/
using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using YaMoControlDesign.Data;

namespace YaMoControlDesign.Controls
{
    /// <summary>
    /// 汉堡包菜单
    /// </summary>
    [StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(HamburgerMenuItem))]
    [StyleTypedProperty(Property = "OptionsItemContainerStyle", StyleTargetType = typeof(HamburgerMenuOptionsItem))]
    [TemplatePart(Name = HamburgerButtonPartName, Type = typeof(Button))]
    [TemplatePart(Name = OptionsItemsControlPartName, Type = typeof(MenuBase))]
    [TemplatePart(Name = ContentTransitionPartName, Type = typeof(Transition))]
    public class HamburgerMenu : TabControl
    {
        /// <summary>
        /// 汉堡包按钮
        /// </summary>
        public const string HamburgerButtonPartName = "PART_HamburgerButton";

        /// <summary>
        /// 选项集合控件
        /// </summary>
        public const string OptionsItemsControlPartName = "PART_OptionsItemsControl";

        /// <summary>
        /// 内容转换
        /// </summary>
        public const string ContentTransitionPartName = "PART_ContentTransition";

        #region fields

        private CornerRadius _cornerRadius;
        private MenuBase optionsMenu;
        private Transition contentTransition;

        #endregion fields

        #region properties

        /// <summary>
        /// 圆角半径
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty = Border.CornerRadiusProperty.AddOwner(typeof(HamburgerMenu), new FrameworkPropertyMetadata(default(CornerRadius), FrameworkPropertyMetadataOptions.AffectsMeasure));

        /// <summary>
        /// 圆角半径
        /// </summary>
        public CornerRadius CornerRadius
        {
            get => _cornerRadius;
            set => SetValue(CornerRadiusProperty, value);
        }

        /// <summary>
        /// 是否展开菜单
        /// </summary>
        public static readonly DependencyProperty IsExpandedProperty = DependencyProperty.Register(
            "IsExpanded", typeof(bool), typeof(HamburgerMenu), new FrameworkPropertyMetadata(BooleanBoxes.FalseBox, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// 是否展开菜单
        /// </summary>
        public bool IsExpanded
        {
            get { return (bool)GetValue(IsExpandedProperty); }
            set { SetValue(IsExpandedProperty, BooleanBoxes.Box(value)); }
        }

        /// <summary>
        /// 标题
        /// </summary>
        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(
            "Header", typeof(string), typeof(HamburgerMenu), new PropertyMetadata(default(string)));

        /// <summary>
        /// 标题
        /// </summary>
        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        /// <summary>
        /// 面板头部内容
        /// </summary>
        public static readonly DependencyProperty PaneHeaderProperty = DependencyProperty.Register(
            "PaneHeader", typeof(object), typeof(HamburgerMenu), new PropertyMetadata(default(object)));

        /// <summary>
        /// 面板头部内容
        /// </summary>
        public object PaneHeader
        {
            get { return (object)GetValue(PaneHeaderProperty); }
            set { SetValue(PaneHeaderProperty, value); }
        }

        /// <summary>
        /// 面板底部内容
        /// </summary>
        public static readonly DependencyProperty PaneFooterProperty = DependencyProperty.Register(
            "PaneFooter", typeof(object), typeof(HamburgerMenu), new PropertyMetadata(default(object)));

        /// <summary>
        /// 面板底部内容
        /// </summary>
        public object PaneFooter
        {
            get { return (object)GetValue(PaneFooterProperty); }
            set { SetValue(PaneFooterProperty, value); }
        }

        /// <summary>
        /// 折叠宽度
        /// </summary>
        public static readonly DependencyProperty CollapsedWidthProperty = DependencyProperty.Register(
            "CollapsedWidth", typeof(double), typeof(HamburgerMenu), new PropertyMetadata(default(double)));

        /// <summary>
        /// 折叠宽度
        /// </summary>
        public double CollapsedWidth
        {
            get { return (double)GetValue(CollapsedWidthProperty); }
            set { SetValue(CollapsedWidthProperty, value); }
        }

        /// <summary>
        /// 展开宽度
        /// </summary>
        public static readonly DependencyProperty ExpandedWidthProperty = DependencyProperty.Register(
            "ExpandedWidth", typeof(double), typeof(HamburgerMenu), new PropertyMetadata(default(double)));

        /// <summary>
        /// 展开宽度
        /// </summary>
        public double ExpandedWidth
        {
            get { return (double)GetValue(ExpandedWidthProperty); }
            set { SetValue(ExpandedWidthProperty, value); }
        }

        /// <summary>
        /// 图标宽度
        /// </summary>
        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.Register(
            "IconWidth", typeof(double), typeof(HamburgerMenu), new PropertyMetadata(default(double)));

        /// <summary>
        /// 图标宽度
        /// </summary>
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        /// <summary>
        /// 是否显示汉堡包按钮
        /// </summary>
        public static readonly DependencyProperty IsShowHamburgerButtonProperty = DependencyProperty.Register(
            "IsShowHamburgerButton", typeof(bool), typeof(HamburgerMenu), new PropertyMetadata(BooleanBoxes.TrueBox));

        /// <summary>
        /// 是否显示汉堡包按钮
        /// </summary>
        public bool IsShowHamburgerButton
        {
            get { return (bool)GetValue(IsShowHamburgerButtonProperty); }
            set { SetValue(IsShowHamburgerButtonProperty, BooleanBoxes.Box(value)); }
        }

        /// <summary>
        /// 是否显示小竖条
        /// </summary>
        public static readonly DependencyProperty IsShowLittleBarProperty = DependencyProperty.Register(
            "IsShowLittleBar", typeof(bool), typeof(HamburgerMenu), new PropertyMetadata(BooleanBoxes.TrueBox));

        /// <summary>
        /// 是否显示小竖条
        /// </summary>
        public bool IsShowLittleBar
        {
            get { return (bool)GetValue(IsShowLittleBarProperty); }
            set { SetValue(IsShowLittleBarProperty, BooleanBoxes.Box(value)); }
        }

        /// <summary>
        /// 转换类型
        /// </summary>
        public static readonly DependencyProperty TransitionTypeProperty =
            DependencyProperty.Register("TransitionType", typeof(TransitionType), typeof(HamburgerMenu), new PropertyMetadata(default(TransitionType)));

        /// <summary>
        /// 转换类型
        /// </summary>
        public TransitionType TransitionType
        {
            get { return (TransitionType)GetValue(TransitionTypeProperty); }
            set { SetValue(TransitionTypeProperty, value); }
        }

        /// <summary>
        /// 动画时长
        /// </summary>
        public static readonly DependencyProperty TransitionDurationProperty =
            DependencyProperty.Register("TransitionDuration", typeof(Duration), typeof(HamburgerMenu), new PropertyMetadata(default(Duration)));

        /// <summary>
        /// 动画时长
        /// </summary>
        public Duration TransitionDuration
        {
            get { return (Duration)GetValue(TransitionDurationProperty); }
            set { SetValue(TransitionDurationProperty, value); }
        }

        /// <summary>
        /// 面板背景
        /// </summary>
        public static readonly DependencyProperty PaneBackgroundProperty =
            DependencyProperty.Register("PaneBackground", typeof(Brush), typeof(HamburgerMenu), new PropertyMetadata(default(Brush)));

        /// <summary>
        /// 面板背景
        /// </summary>
        public Brush PaneBackground
        {
            get { return (Brush)GetValue(PaneBackgroundProperty); }
            set { SetValue(PaneBackgroundProperty, value); }
        }

        /// <summary>
        /// 面板边框
        /// </summary>
        public static readonly DependencyProperty PaneBorderThicknessProperty =
            DependencyProperty.Register("PaneBorderThickness", typeof(Thickness), typeof(HamburgerMenu), new PropertyMetadata(default(Thickness)));

        /// <summary>
        /// 面板边框
        /// </summary>
        public Thickness PaneBorderThickness
        {
            get { return (Thickness)GetValue(PaneBorderThicknessProperty); }
            set { SetValue(PaneBorderThicknessProperty, value); }
        }

        /// <summary>
        /// 面板圆角半径
        /// </summary>
        public static readonly DependencyProperty PaneBorderCornerRadiusProperty =
            DependencyProperty.Register("PaneBorderCornerRadius", typeof(CornerRadius), typeof(HamburgerMenu), new PropertyMetadata(default(CornerRadius)));

        /// <summary>
        /// 面板圆角半径
        /// </summary>
        public CornerRadius PaneBorderCornerRadius
        {
            get { return (CornerRadius)GetValue(PaneBorderCornerRadiusProperty); }
            set { SetValue(PaneBorderCornerRadiusProperty, value); }
        }

        /// <summary>
        /// 菜单图标
        /// </summary>
        public static readonly DependencyProperty MenuIconProperty = DependencyProperty.Register(
            "MenuIcon", typeof(object), typeof(HamburgerMenu), new PropertyMetadata(default(object)));

        /// <summary>
        /// 菜单图标
        /// </summary>
        public object MenuIcon
        {
            get { return GetValue(MenuIconProperty); }
            set { SetValue(MenuIconProperty, value); }
        }

        #endregion properties

        #region options item

        // form https://github.com/MahApps/MahApps.Metro
        // MahApps.Metro.Controls.HamburgerMenu

        /// <summary>Identifies the <see cref="OptionsItemsSource"/> dependency property.</summary>
        public static readonly DependencyProperty OptionsItemsSourceProperty = DependencyProperty.Register(
            nameof(OptionsItemsSource), typeof(IEnumerable), typeof(HamburgerMenu), new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets an object source used to generate the content of the options.
        /// </summary>
        public IEnumerable OptionsItemsSource
        {
            get => (IEnumerable)this.GetValue(OptionsItemsSourceProperty);
            set => this.SetValue(OptionsItemsSourceProperty, value);
        }

        /// <summary>Identifies the <see cref="OptionsItemContainerStyle"/> dependency property.</summary>
        public static readonly DependencyProperty OptionsItemContainerStyleProperty = DependencyProperty.Register(
            nameof(OptionsItemContainerStyle), typeof(Style), typeof(HamburgerMenu), new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets the <see cref="Style"/> used for each item in the options.
        /// </summary>
        public Style OptionsItemContainerStyle
        {
            get => (Style)this.GetValue(OptionsItemContainerStyleProperty);
            set => this.SetValue(OptionsItemContainerStyleProperty, value);
        }

        /// <summary>Identifies the <see cref="OptionsItemTemplate"/> dependency property.</summary>
        public static readonly DependencyProperty OptionsItemTemplateProperty = DependencyProperty.Register(
            nameof(OptionsItemTemplate), typeof(DataTemplate), typeof(HamburgerMenu), new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets the <see cref="DataTemplate"/> used to display each item in the options.
        /// </summary>
        public DataTemplate OptionsItemTemplate
        {
            get => (DataTemplate)this.GetValue(OptionsItemTemplateProperty);
            set => this.SetValue(OptionsItemTemplateProperty, value);
        }

        /// <summary>Identifies the <see cref="OptionsItemTemplateSelector"/> dependency property.</summary>
        public static readonly DependencyProperty OptionsItemTemplateSelectorProperty = DependencyProperty.Register(
            nameof(OptionsItemTemplateSelector), typeof(DataTemplateSelector), typeof(HamburgerMenu), new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets the <see cref="DataTemplateSelector"/> used to display each item in the options.
        /// </summary>
        public DataTemplateSelector OptionsItemTemplateSelector
        {
            get => (DataTemplateSelector)this.GetValue(OptionsItemTemplateSelectorProperty);
            set => this.SetValue(OptionsItemTemplateSelectorProperty, value);
        }

        /// <summary>Identifies the <see cref="OptionsVisibility"/> dependency property.</summary>
        public static readonly DependencyProperty OptionsVisibilityProperty = DependencyProperty.Register(
            nameof(OptionsVisibility), typeof(Visibility), typeof(HamburgerMenu), new PropertyMetadata(Visibility.Visible));

        /// <summary>
        /// Gets or sets the <see cref="Visibility"/> of the options menu.
        /// </summary>
        public Visibility OptionsVisibility
        {
            get => (Visibility)this.GetValue(OptionsVisibilityProperty);
            set => this.SetValue(OptionsVisibilityProperty, value);
        }

        /// <summary>
        /// Gets the collection used to generate the content of the option list.
        /// </summary>
        /// <exception cref="Exception">
        /// Exception thrown if OptionsListView is not yet defined.
        /// </exception>
        public ItemCollection OptionsItems
        {
            get
            {
                if (this.optionsMenu is null)
                {
                    throw new Exception("OptionsListView is not defined yet. Please use OptionsItemsSource instead.");
                }

                return this.optionsMenu.Items;
            }
        }

        #endregion options item

        #region events

        /// <summary>
        /// 汉堡包按钮点击事件
        /// </summary>
        public static readonly RoutedEvent HamburgerButtonClickEvent = EventManager.RegisterRoutedEvent(nameof(HamburgerButtonClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(HamburgerMenu));

        /// <summary>
        /// 汉堡包按钮点击
        /// </summary>
        public event RoutedEventHandler HamburgerButtonClick
        {
            add => this.AddHandler(HamburgerButtonClickEvent, value);
            remove => this.RemoveHandler(HamburgerButtonClickEvent, value);
        }

        #endregion events

        static HamburgerMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HamburgerMenu), new FrameworkPropertyMetadata(typeof(HamburgerMenu)));
        }

        #region methods

        /// <inheritdoc/>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Button button = GetTemplateChild(HamburgerButtonPartName) as Button;
            button.Click += Button_Click;

            optionsMenu = GetTemplateChild(OptionsItemsControlPartName) as MenuBase;

            contentTransition = GetTemplateChild(ContentTransitionPartName) as Transition;

            SelectionChanged += HamburgerMenu_SelectionChanged;
        }

        private void HamburgerMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.OriginalSource.GetHashCode() == GetHashCode())
            {
                Transition.ShowAnimation(contentTransition);
            }
        }

        /// <inheritdoc/>
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is HamburgerMenuItem;
        }

        /// <inheritdoc/>
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new HamburgerMenuItem();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var args = new RoutedEventArgs(HamburgerButtonClickEvent, sender);
            this.RaiseEvent(args);

            if (!args.Handled)
            {
                IsExpanded = !IsExpanded;
            }
        }

        #endregion methods
    }
}
