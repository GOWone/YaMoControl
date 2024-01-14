using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaMoControlDesign.Tools.Media
{
    public interface IArcGeometrySourceParameters : IGeometrySourceParameters
    {
        double ArcThickness { get; }

        UnitType ArcThicknessUnit { get; }

        double EndAngle { get; }

        double StartAngle { get; }
    }
}
