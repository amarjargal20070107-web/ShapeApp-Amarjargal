
using ShapeApp;
using System.Drawing;

public class CircleShape : Shape
{
    public CircleShape(Rectangle b, Color c)
        : base(b, c)
    {
    }

    public override string Name
    {
        get { return "Дугуй"; }
    }

    public override void Draw(Graphics g)
    {
        using (var brush = MakeFill())
        using (var pen = MakePen())
        {
            g.FillEllipse(brush, X, Y, Width, Height);
            g.DrawEllipse(pen, X, Y, Width, Height);
        }

        base.Draw(g);
    }
}
