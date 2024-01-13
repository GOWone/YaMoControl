using System.Windows;

namespace YaMoControlDesign.Interactivity
{

    public abstract class Behavior<T> : Behavior1 where T : DependencyObject
    {
        protected Behavior() : base(typeof(T))
        {
        }

        protected new T AssociatedObject => (T)base.AssociatedObject;
    }
}