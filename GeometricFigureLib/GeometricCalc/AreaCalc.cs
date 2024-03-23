using GeometricFigureLib.GeometricTypes;

namespace GeometricFigureLib.GeometricCalc
{
    public static class AreaCalc
    {
        public static double GetFigureArea(IFigure figure)
        {
            return figure.GetArea();
        }
    }
}
