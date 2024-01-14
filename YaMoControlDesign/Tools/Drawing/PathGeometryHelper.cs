using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace YaMoControlDesign.Tools.Drawing
{
    internal static class PathGeometryHelper
    {
        public static bool IsStroked(this PathSegment pathSegment) => pathSegment.IsStroked;

        public static PathGeometry AsPathGeometry(this Geometry original)
        {
            if (original == null)
            {
                return null;
            }

            if (!(original is PathGeometry geometry))
            {
                return PathGeometry.CreateFromGeometry(original);
            }
            return geometry;
        }

        internal static Geometry FixPathGeometryBoundary(Geometry geometry) => geometry;
    }
}
