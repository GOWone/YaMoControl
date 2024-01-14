using System.Windows;

namespace YaMoControlDesign.Controls
{

    public interface ISelectable
    {
        event RoutedEventHandler Selected;

        bool IsSelected { get; set; }
    }
}