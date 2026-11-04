
using ShapeApp;
using System.Drawing;

public class RectangleShape : Shape
{
    public RectangleShape(Rectangle b, Color c)
        : base(b, c)
    {
    }

    public override string Name
    {
        get { return "Тэгш өнцөгт"; }
    }

    public override void Draw(Graphics g)
    {
        using (var brush = MakeFill())
        using (var pen = MakePen())
        {
            g.FillRectangle(brush, X, Y, Width, Height);
            g.DrawRectangle(pen, X, Y, Width, Height);
        }

        base.Draw(g);
    }
}
