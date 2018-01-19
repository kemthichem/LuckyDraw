using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LuckyDraw
{
    class SerialNumber
    {
        //Attributes
        private bool isDialing;
        private int NumberOfBox;

        //graphic
        private Color mBgColor;

        private List<NumberBox> mListNumberBox;

        public SerialNumber(int numberOfBox)
        {
            NumberOfBox = numberOfBox;
            isDialing = false;

            mListNumberBox = new List<NumberBox>();

            mBgColor = Color.Transparent;


            for (int i = 0; i < numberOfBox; i++)
            {
                Point p = new Point(200 * i, 0);
                PointF margin = new PointF(30, 28);

                NumberBox nb = new NumberBox(p, margin);
                mListNumberBox.Add(nb);
            }
        }
        private void DrawBorder(Graphics g)
        {
            const float xradius = 10;
            const float yradius = 10;

            // Top rectangle.

            RectangleF rect = new RectangleF(
                2, 2,
                836,
                300);

            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.Yellow, 3))
            {
                GraphicsPath path = ExtendGraphics.MakeRoundedRect(
                    rect, xradius, yradius, true, true, true, true);
                g.FillPath(Brushes.SlateBlue, path);
                g.DrawPath(pen, path);
                path.Dispose();
            }

            RectangleF rect1 = new RectangleF(
                15, 15,
                810,
                274);
            using (Pen pen = new Pen(Color.DarkSlateBlue, 0))
            {
                GraphicsPath path = ExtendGraphics.MakeRoundedRect(
                    rect1, xradius, yradius, true, true, true, true);
                g.FillPath(Brushes.DarkSlateBlue, path);
                g.DrawPath(pen, path);
                path.Dispose();
            }

        }

        public void Draw(Graphics g)
        {
            g.Clear(mBgColor);
            //Draw border
            DrawBorder(g);

            //draw number
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            g.SetClip(new Rectangle(30, 28, 780, 248));
            for (int i = 0; i < mListNumberBox.Count; i++)
            {
                mListNumberBox[i].Draw(g);
            }
        }

        public void Start()
        {
            isDialing = true;
            for (int i = 0; i < mListNumberBox.Count; i++)
            {
                mListNumberBox[i].Start();
            }
        }

        public void Stop(int value)
        {
            List<int> temp = new List<int>(this.NumberOfBox);

            for (int i = this.NumberOfBox; i > 0; i--)
            {
                int deci = (int)Math.Pow(10, i - 1);
                int val = value / deci;
                value -= (val * deci);

                temp.Add(val);
            }


            for (int i = 0; i < temp.Count; i++)
			{
                if (i < mListNumberBox.Count)
                {
                    mListNumberBox[i].Stop(temp[i]);
                }                
            }
        }

    }
}
