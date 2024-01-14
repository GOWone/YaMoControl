﻿using System;

namespace YaMoControlDesign.Tools.Media
{
    internal class DrawingPropertyChangedEventArgs : EventArgs
    {
        public bool IsAnimated { get; set; }

        public DrawingPropertyMetadata Metadata { get; set; }
    }
}
