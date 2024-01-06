﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows;

namespace YaMoControlDesign.Interactivity
{
    public class AdornerContainer : Adorner
    {
        private UIElement _child;

        public AdornerContainer(UIElement adornedElement) : base(adornedElement)
        {
        }

        public UIElement Child
        {
            get => _child;
            set
            {
                if (value == null)
                {
                    RemoveVisualChild(_child);
                    // ReSharper disable once ExpressionIsAlwaysNull
                    _child = value;
                    return;
                }
                AddVisualChild(value);
                _child = value;
            }
        }

        protected override int VisualChildrenCount => _child != null ? 1 : 0;

        protected override Size ArrangeOverride(Size finalSize)
        {
            _child?.Arrange(new Rect(finalSize));
            return finalSize;
        }

        protected override Visual GetVisualChild(int index)
        {
            if (index == 0 && _child != null) return _child;
            return base.GetVisualChild(index);
        }
    }
}
