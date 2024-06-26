﻿/*********************************************************************
 * Copyright(c) YaMoStudio All Rights Reserved.
 * 开发者：YaMoStudio
 * 命名空间：YaMoControlDesign.Tools.Helper
 * 文件名：ScrollViewerHelper
 * 版本号：V1.0.0.0
 * 创建时间：2024/5/4 21:50:11
 ******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows;
using YaMoControlDesign.Data;

namespace YaMoControlDesign.Controls
{
    /// <summary>
    /// ScrollViewer 帮助类
    /// </summary>
    public class ScrollViewerHelper
    {
        /// <summary>
        /// 滚动条前景色
        /// </summary>
        public static readonly DependencyProperty ScrollBarForegroundProperty = DependencyProperty.RegisterAttached(
            "ScrollBarForeground", typeof(Brush), typeof(ScrollViewerHelper), new PropertyMetadata(default(Brush)));

        /// <summary>
        /// Sets the scroll bar foreground.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="value">The value.</param>
        public static void SetScrollBarForeground(DependencyObject element, Brush value)
        {
            element.SetValue(ScrollBarForegroundProperty, value);
        }

        /// <summary>
        /// Gets the scroll bar foreground.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>A Brush.</returns>
        public static Brush GetScrollBarForeground(DependencyObject element)
        {
            return (Brush)element.GetValue(ScrollBarForegroundProperty);
        }

        /// <summary>
        /// 滚动条背景色
        /// </summary>
        public static readonly DependencyProperty ScrollBarBackgroundProperty = DependencyProperty.RegisterAttached(
            "ScrollBarBackground", typeof(Brush), typeof(ScrollViewerHelper), new PropertyMetadata(default(Brush)));

        /// <summary>
        /// Sets the scroll bar background.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="value">The value.</param>
        public static void SetScrollBarBackground(DependencyObject element, Brush value)
        {
            element.SetValue(ScrollBarBackgroundProperty, value);
        }

        /// <summary>
        /// Gets the scroll bar background.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>A Brush.</returns>
        public static Brush GetScrollBarBackground(DependencyObject element)
        {
            return (Brush)element.GetValue(ScrollBarBackgroundProperty);
        }

        /// <summary>
        /// 滚动条大小
        /// </summary>
        public static readonly DependencyProperty ScrollBarSizeProperty = DependencyProperty.RegisterAttached(
            "ScrollBarSize", typeof(double), typeof(ScrollViewerHelper), new PropertyMetadata(default(double)));

        /// <summary>
        /// Sets the scroll bar size.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="value">The value.</param>
        public static void SetScrollBarSize(DependencyObject element, double value)
        {
            element.SetValue(ScrollBarSizeProperty, value);
        }

        /// <summary>
        /// Gets the scroll bar size.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>A double.</returns>
        public static double GetScrollBarSize(DependencyObject element)
        {
            return (double)element.GetValue(ScrollBarSizeProperty);
        }

        /// <summary>
        /// 显示箭头按钮
        /// </summary>
        public static readonly DependencyProperty ShowArrowButtonProperty = DependencyProperty.RegisterAttached(
            "ShowArrowButton", typeof(bool), typeof(ScrollViewerHelper), new PropertyMetadata(BooleanBoxes.FalseBox));

        /// <summary>
        /// Sets the show arrow button.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="value">If true, value.</param>
        public static void SetShowArrowButton(DependencyObject element, bool value)
        {
            element.SetValue(ShowArrowButtonProperty, BooleanBoxes.Box(value));
        }

        /// <summary>
        /// Gets the show arrow button.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>A bool.</returns>
        public static bool GetShowArrowButton(DependencyObject element)
        {
            return (bool)element.GetValue(ShowArrowButtonProperty);
        }

        /// <summary>
        /// 垂直偏移变化值
        /// </summary>
        public static readonly DependencyProperty VerticalDeltaProperty = DependencyProperty.RegisterAttached(
            "VerticalDelta", typeof(double), typeof(ScrollViewerHelper), new PropertyMetadata(default(double)));

        /// <summary>
        /// Sets the vertical delta.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="value">The value.</param>
        public static void SetVerticalDelta(DependencyObject element, double value)
        {
            element.SetValue(VerticalDeltaProperty, value);
        }

        /// <summary>
        /// Gets the vertical delta.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>A double.</returns>
        public static double GetVerticalDelta(DependencyObject element)
        {
            return (double)element.GetValue(VerticalDeltaProperty);
        }

        /// <summary>
        /// 水平偏移变化值
        /// </summary>
        public static readonly DependencyProperty HorizontalDeltaProperty = DependencyProperty.RegisterAttached(
            "HorizontalDelta", typeof(double), typeof(ScrollViewerHelper), new PropertyMetadata(default(double)));

        /// <summary>
        /// Sets the horizontal delta.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="value">The value.</param>
        public static void SetHorizontalDelta(DependencyObject element, double value)
        {
            element.SetValue(HorizontalDeltaProperty, value);
        }

        /// <summary>
        /// Gets the horizontal delta.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>A double.</returns>
        public static double GetHorizontalDelta(DependencyObject element)
        {
            return (double)element.GetValue(HorizontalDeltaProperty);
        }

        /// <summary>
        /// 垂直偏移
        /// </summary>
        public static readonly DependencyProperty VerticalOffsetProperty = DependencyProperty.RegisterAttached(
            "VerticalOffset", typeof(double), typeof(ScrollViewerHelper), new PropertyMetadata(default(double), OnVerticalOffsetChanged));

        private static void OnVerticalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ScrollViewer scrollViewer)
            {
                scrollViewer.ScrollToVerticalOffset((double)e.NewValue);
            }
        }

        /// <summary>
        /// Sets the vertical offset.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="value">The value.</param>
        public static void SetVerticalOffset(DependencyObject element, double value)
        {
            element.SetValue(VerticalOffsetProperty, value);
        }

        /// <summary>
        /// Gets the vertical offset.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>A double.</returns>
        public static double GetVerticalOffset(DependencyObject element)
        {
            return (double)element.GetValue(VerticalOffsetProperty);
        }

        /// <summary>
        /// 水平偏移
        /// </summary>
        public static readonly DependencyProperty HorizontalOffsetProperty = DependencyProperty.RegisterAttached(
            "HorizontalOffset", typeof(double), typeof(ScrollViewerHelper), new PropertyMetadata(default(double), OnHorizontalOffsetChanged));

        private static void OnHorizontalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ScrollViewer scrollViewer)
            {
                scrollViewer.ScrollToHorizontalOffset((double)e.NewValue);
            }
        }

        /// <summary>
        /// Sets the horizontal offset.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="value">The value.</param>
        public static void SetHorizontalOffset(DependencyObject element, double value)
        {
            element.SetValue(HorizontalOffsetProperty, value);
        }

        /// <summary>
        /// Gets the horizontal offset.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>A double.</returns>
        public static double GetHorizontalOffset(DependencyObject element)
        {
            return (double)element.GetValue(HorizontalOffsetProperty);
        }

        /// <summary>
        /// 是否显示动画
        /// </summary>
        public static readonly DependencyProperty IsOnlyArrowProperty = DependencyProperty.RegisterAttached(
            "IsOnlyArrow", typeof(bool), typeof(ScrollViewerHelper), new PropertyMetadata(BooleanBoxes.FalseBox, OnIsOnlyArrowChanged));

        private static void OnIsOnlyArrowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ScrollViewer scrollViewer)
            {
                scrollViewer.Loaded += (sender, args) =>
                {
                    if (GetIsOnlyArrow(scrollViewer))
                    {
                        var horizontalDelta = GetHorizontalDelta(scrollViewer);
                        var verticalDelt = GetVerticalDelta(scrollViewer);
                        if (scrollViewer.Template.FindName("upButton", scrollViewer) is ButtonBase upButton)
                        {
                            upButton.Click += (a, b) => VerticalAnimation(scrollViewer, -verticalDelt);
                        }

                        if (scrollViewer.Template.FindName("downButton", scrollViewer) is ButtonBase downButton)
                        {
                            downButton.Click += (a, b) => VerticalAnimation(scrollViewer, verticalDelt);
                        }

                        if (scrollViewer.Template.FindName("leftButton", scrollViewer) is ButtonBase leftButton)
                        {
                            leftButton.Click += (a, b) => HorizontalAnimation(scrollViewer, -horizontalDelta);
                        }

                        if (scrollViewer.Template.FindName("rightButton", scrollViewer) is ButtonBase rightButton)
                        {
                            rightButton.Click += (a, b) => HorizontalAnimation(scrollViewer, horizontalDelta);
                        }
                    }
                };
            }
        }

        private static void VerticalAnimation(ScrollViewer scrollViewer, double offset)
        {
            double actullOffset = scrollViewer.VerticalOffset + offset;
            if (actullOffset < 0)
            {
                actullOffset = 0;
            }
            else if (actullOffset > scrollViewer.ScrollableHeight)
            {
                actullOffset = scrollViewer.ScrollableHeight;
            }

            var Animation = new DoubleAnimation
            {
                From = scrollViewer.VerticalOffset,
                To = actullOffset,
                Duration = TimeSpan.FromMilliseconds(300),
                EasingFunction = new CubicEase() { EasingMode = EasingMode.EaseOut },
            };

            scrollViewer.BeginAnimation(VerticalOffsetProperty, Animation);
        }

        private static void HorizontalAnimation(ScrollViewer scrollViewer, double offset)
        {
            double actullOffset = scrollViewer.HorizontalOffset + offset;
            if (actullOffset < 0)
            {
                actullOffset = 0;
            }
            else if (actullOffset > scrollViewer.ScrollableWidth)
            {
                actullOffset = scrollViewer.ScrollableWidth;
            }

            var Animation = new DoubleAnimation
            {
                From = scrollViewer.HorizontalOffset,
                To = actullOffset,
                Duration = TimeSpan.FromMilliseconds(300),
                EasingFunction = new CubicEase() { EasingMode = EasingMode.EaseOut },
            };

            scrollViewer.BeginAnimation(HorizontalOffsetProperty, Animation);
        }

        public static void SetIsOnlyArrow(DependencyObject element, bool value)
        {
            element.SetValue(IsOnlyArrowProperty, BooleanBoxes.Box(value));
        }

        public static bool GetIsOnlyArrow(DependencyObject element)
        {
            return (bool)element.GetValue(IsOnlyArrowProperty);
        }

        /// <summary>
        /// 箭头图标颜色
        /// </summary>
        public static readonly DependencyProperty ArrowIconBrushProperty = DependencyProperty.RegisterAttached(
            "ArrowIconBrush", typeof(Brush), typeof(ScrollViewerHelper), new PropertyMetadata(default(Brush)));

        public static void SetArrowIconBrush(DependencyObject element, Brush value)
        {
            element.SetValue(ArrowIconBrushProperty, value);
        }

        public static Brush GetArrowIconBrush(DependencyObject element)
        {
            return (Brush)element.GetValue(ArrowIconBrushProperty);
        }

        /// <summary>
        /// 箭头按钮样式
        /// </summary>
        public static readonly DependencyProperty ArrowButtonStyleProperty = DependencyProperty.RegisterAttached(
            "ArrowButtonStyle", typeof(Style), typeof(ScrollViewerHelper), new PropertyMetadata(default));

        public static void SetArrowButtonStyle(DependencyObject element, Style value)
        {
            element.SetValue(ArrowButtonStyleProperty, value);
        }

        public static Style GetArrowButtonStyle(DependencyObject element)
        {
            return (Style)element.GetValue(ArrowButtonStyleProperty);
        }

        /// <summary>
        /// 是否滚动条动态大小
        /// </summary>
        public static readonly DependencyProperty IsDynamicBarSizeProperty = DependencyProperty.RegisterAttached(
            "IsDynamicBarSize", typeof(bool), typeof(ScrollViewerHelper), new PropertyMetadata(BooleanBoxes.FalseBox, OnIsDynamicBarSizeChanged));

        public static void SetIsDynamicBarSize(DependencyObject element, bool value)
        {
            element.SetValue(IsDynamicBarSizeProperty, BooleanBoxes.Box(value));
        }

        public static bool GetIsDynamicBarSize(DependencyObject element)
        {
            return (bool)element.GetValue(IsDynamicBarSizeProperty);
        }

        private static void CaptureScrollBarTouchDown(ScrollViewer scrollViewer)
        {
            var isDynamicBarSize = GetIsDynamicBarSize(scrollViewer);
            if (!(scrollViewer.Template.FindName("PART_VerticalScrollBar", scrollViewer) is ScrollBar verticalScrollBar) ||
                !(scrollViewer.Template.FindName("PART_HorizontalScrollBar", scrollViewer) is ScrollBar horizontalScrollBar))
            {
                return;
            }

            if (isDynamicBarSize)
            {
                verticalScrollBar.PreviewTouchDown += ScrollBar_PreviewTouchDown;
                horizontalScrollBar.PreviewTouchDown += ScrollBar_PreviewTouchDown;
            }
            else
            {
                verticalScrollBar.PreviewTouchDown -= ScrollBar_PreviewTouchDown;
                horizontalScrollBar.PreviewTouchDown -= ScrollBar_PreviewTouchDown;
            }
        }

        private static void OnIsDynamicBarSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ScrollViewer scrollViewer)
            {
                if (scrollViewer.IsLoaded)
                {
                    CaptureScrollBarTouchDown(scrollViewer);
                }
                else
                {
                    scrollViewer.Loaded += ScrollViewer_Loaded;
                }
            }
        }

        private static void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            var scrollViewer = sender as ScrollViewer;
            scrollViewer.Loaded -= ScrollViewer_Loaded;
            CaptureScrollBarTouchDown(scrollViewer);
        }

        private static void ScrollBar_PreviewTouchDown(object sender, System.Windows.Input.TouchEventArgs e)
        {
            e.Handled = true;
        }
    }
}
