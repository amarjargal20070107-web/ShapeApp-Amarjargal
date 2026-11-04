
using ShapeApp;
using System.Drawing;

public class CurveShape : Shape
{
    private PointF[] points;

    public CurveShape(Rectangle b, Color c)
        : base(b, c)
    {
        points = new PointF[]
        {
            new PointF(X, Y + Height),
            new PointF(X + Width / 3, Y),
            new PointF(X + Width * 2 / 3, Y + Height),
            new PointF(X + Width, Y)
        };
    }

    public override string Name
    {
        get { return "Curve"; }
    }

    public override void Draw(Graphics g)
    {
        using (var pen = MakePen())
        {
            g.DrawCurve(pen, points);
        }

        base.Draw(g);
    }
}
