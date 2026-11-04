
using ShapeApp;
using System.Drawing;

public class PolygonShape : Shape
{
    private PointF[] points;

    public PolygonShape(Rectangle b, Color c)
        : base(b, c)
    {
        points = new PointF[]
        {
            new PointF(X + Width / 2, Y),
            new PointF(X + Width, Y + Height / 2),
            new PointF(X + Width / 2, Y + Height),
            new PointF(X, Y + Height / 2)
        };
    }

    public override string Name
    {
        get { return "Polygon"; }
    }

    public override void Draw(Graphics g)
    {
        using (var brush = MakeFill())
        using (var pen = MakePen())
        {
            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);
        }

        base.Draw(g);
    }
}
