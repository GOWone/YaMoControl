using System.Windows.Media;

namespace YaMoControlDesign.Tools.Media
{
    public interface IGeometrySourceParameters
    {
        Stretch Stretch { get; }

        Brush Stroke { get; }

        double StrokeThickness { get; }
    }

}
