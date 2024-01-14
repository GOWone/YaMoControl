using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace YaMoControlDesign.Tools.Media
{
    internal static class GeometrySourceExtensions
    {
        public static GeometryEffect GetGeometryEffect(this IGeometrySourceParameters parameters)
        {
            if (parameters is DependencyObject obj2)
            {
                var geometryEffect = GeometryEffect.GetGeometryEffect(obj2);
                if (geometryEffect != null && obj2.Equals(geometryEffect.Parent)) return geometryEffect;
            }

            return null;
        }

        public static double GetHalfStrokeThickness(this IGeometrySourceParameters parameter)
        {
            if (parameter.Stroke != null)
            {
                var strokeThickness = parameter.StrokeThickness;
                if (!double.IsNaN(strokeThickness) && !double.IsInfinity(strokeThickness))
                    return Math.Abs(strokeThickness) / 2.0;
            }

            return 0.0;
        }
    }
}
