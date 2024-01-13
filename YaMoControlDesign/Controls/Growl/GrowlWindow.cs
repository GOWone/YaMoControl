using System;
using System.Windows;
using System.Windows.Controls;
using YaMoControlDesign.Tools;
using YaMoControlDesign.Tools.Interop;

namespace YaMoControlDesign.Controls
{

    public sealed class GrowlWindow : Window
    {
        internal Panel GrowlPanel { get; set; }

        internal GrowlWindow()
        {
            WindowStyle = WindowStyle.None;
            AllowsTransparency = true;

            GrowlPanel = new StackPanel
            {
                VerticalAlignment = VerticalAlignment.Top
            };

            Content = new ScrollViewer
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Hidden,
                IsInertiaEnabled = true,
                Content = GrowlPanel
            };
        }

        internal void Init()
        {
            var desktopWorkingArea = SystemParameters.WorkArea;
            Height = desktopWorkingArea.Height;
            Left = desktopWorkingArea.Right - Width;
            Top = 0;
        }

        protected override void OnSourceInitialized(EventArgs e)
            => InteropMethods.IntDestroyMenu(this.GetHwndSource().CreateHandleRef());
    }
}