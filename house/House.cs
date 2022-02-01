using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house
{
    public class House
    {
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
        public int VerticalWindowsCount { get; set; }
        public int HorizontalWindowsCount { get; set; }
        public int Height { get; set; }
        public Point Location { get; set; }
        public House()
        {
            ForeColor = Color.Chocolate;
            BackColor = Color.Tomato;
            VerticalWindowsCount = 3;
            HorizontalWindowsCount = 2;
            Height = 150;
            Location = new Point();
        }

        public House(Color foreColor, Color backColor, int verticalWindowsCount, int horizontalWindowsCount, int height)
        {
            ForeColor = foreColor;
            BackColor = backColor;
            VerticalWindowsCount = verticalWindowsCount;
            HorizontalWindowsCount = horizontalWindowsCount;
            Height = height;
        }
        public void Draw(Graphics graphics)
        {
            float window = Height / (VerticalWindowsCount * 2F + 3F);
            float width = HorizontalWindowsCount * 2F + 1;
            Brush brush = new SolidBrush(BackColor);
            Brush brushFront = new SolidBrush(ForeColor);
            graphics.FillRectangle(brush, Location.X, Location.Y, width, Height);
            graphics.FillRectangle(brushFront, Location.X + (width - window)/2,Location.Y,window,window*2);
        }
    }
}
