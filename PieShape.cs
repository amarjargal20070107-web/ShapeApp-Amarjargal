
using ShapeApp;
using System;
using System.Drawing;

public class PieShape : Shape
{
    private float startAngle;
    private float sweepAngle;

    public PieShape(Rectangle b, Color c)
        : base(b, c)
    {
        startAngle = 30;
        sweepAngle = 120;
    }

    public override string Name
    {
        get { return "Pie"; }
    }

    public override void Draw(Graphics g)
    {
        using (var brush = MakeFill())
        using (var pen = MakePen())
        {
            g.FillPie(brush, X, Y, Width, Height,
                startAngle, sweepAngle);

            g.DrawPie(pen, X, Y, Width, Height,
                startAngle, sweepAngle);
        }

        base.Draw(g);
    }
}
