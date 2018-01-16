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

        //graphic
        private Color mBgColor;

        private List<NumberBox> mListNumberBox;

        public SerialNumber(int numberOfBox)
        {
            isDialing = false;

            mListNumberBox = new List<NumberBox>();

            mBgColor = Color.Green;


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
            //Draw border
            const float xradius = 10;
            const float yradius = 10;

            // Top rectangle.
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.Yellow, 3))
            {
                RectangleF rect = new RectangleF(2, 2, 836,300);
                GraphicsPath path = ExtendGraphics.MakeRoundedRect(
                    rect, xradius, yradius, true, true, true, true);
                g.FillPath(Brushes.Transparent, path);
                g.DrawPath(pen, path);
            }

            using (Pen pen = new Pen(Color.SlateBlue, 3))
            {
                RectangleF rect = new RectangleF(2, 2, 836, 300);
                GraphicsPath path = ExtendGraphics.MakeRoundedRect(
                    rect, xradius, yradius, true, true, true, true);
                g.FillPath(Brushes.Transparent, path);
                g.DrawPath(pen, path);
            }

            using (Pen pen = new Pen(Color.DarkSlateBlue, 10))
            {
                RectangleF rect1 = new RectangleF(15, 15, 810, 274);
                GraphicsPath path = ExtendGraphics.MakeRoundedRect(
                    rect1, xradius, yradius, true, true, true, true);
                g.FillPath(Brushes.Transparent, path);
                g.DrawPath(pen, path);
            }
        }

        public void Draw(Graphics g)
        {
            g.Clear(mBgColor);
            //return;

           
            //draw number
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            for (int i = 0; i < mListNumberBox.Count; i++)
            {
                mListNumberBox[i].Draw(g);
            }

            DrawBorder(g);
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
            List<int> temp = new List<int>(4);
            temp.Add(1);temp.Add(9);temp.Add(2);temp.Add(5);

            for (int i = 0; i < temp.Count; i++)
			{
                mListNumberBox[i].Stop(temp[i]);
            }

            //isDialing = false;
        }

    }
}
