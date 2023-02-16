using FiguresMathfOperations.Domain.Interface.Figure;

namespace FiguresMathfOperations.Domain.Interface.CustomFigures
{
    public interface ITriangle : IFigure
    {
        double[] _sides { get; set; }

        bool IsRectangle();
    }
}
