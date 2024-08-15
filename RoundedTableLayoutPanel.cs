using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RoundedTableLayoutPanel
{
    public class RoundedTableLayoutPanel : TableLayoutPanel
    {
        private int cornerRadius = 10; // Adjust the corner radius as needed

        public RoundedTableLayoutPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = CreateRoundedRectangle(new Rectangle(0, 0, Width - 1, Height - 1), cornerRadius))
            using (Pen pen = new Pen(BackColor, 1))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath CreateRoundedRectangle(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(rectangle.Right - radius * 2, rectangle.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(rectangle.Right - radius * 2, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rectangle.X, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
