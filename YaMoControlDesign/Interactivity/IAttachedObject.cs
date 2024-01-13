using System.Windows;

namespace YaMoControlDesign.Interactivity
{

    public interface IAttachedObject
    {
        void Attach(DependencyObject dependencyObject);
        void Detach();

        DependencyObject AssociatedObject { get; }
    }
}