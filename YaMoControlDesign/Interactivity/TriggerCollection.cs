﻿using System.Windows;
using YaMoControlDesign.Interactivity;

namespace YaMoControlDesign.Interactivity
{

    public sealed class TriggerCollection : AttachableCollection1<TriggerBase>
    {
        internal TriggerCollection()
        {
        }

        protected override void OnAttached()
        {
            foreach (var triggerBase in this)
                triggerBase.Attach(AssociatedObject);
        }

        protected override void OnDetaching()
        {
            foreach (var triggerBase in this)
                triggerBase.Detach();
        }

        internal override void ItemAdded(TriggerBase item)
        {
            if (AssociatedObject == null)
                return;
            item.Attach(AssociatedObject);
        }

        internal override void ItemRemoved(TriggerBase item)
        {
            if (((IAttachedObject)item).AssociatedObject == null)
                return;
            item.Detach();
        }

        protected override Freezable CreateInstanceCore()
        {
            return new TriggerCollection();
        }
    }
}