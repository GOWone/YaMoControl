﻿using System.Windows;

namespace YaMoControlDesign.Tools.Drawing
{
    internal sealed class PathSegmentData
    {
        public PathSegmentData(Point startPoint, System.Windows.Media.PathSegment pathSegment)
        {
            PathSegment = pathSegment;
            StartPoint = startPoint;
        }

        public System.Windows.Media.PathSegment PathSegment { get; }

        public Point StartPoint { get; }
    }
}
