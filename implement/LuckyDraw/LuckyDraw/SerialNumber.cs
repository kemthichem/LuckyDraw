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

            mBgColor = Color.Transparent;


            for (int i = 0; i < numberOfBox; i++)
            {
                Point p = new Point(200 * i, 0);
                PointF margin = new PointF(30, 28);

                NumberBox nb = new NumberBox(p, margin);
                mListNumberBox.Add(nb);
            }
        }

        public void Draw(Graphics g)
        {
            g.Clear(mBgColor);
            //Draw border
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
            }


            //return;


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
            List<int> temp = new List<int>(4);
            temp.Add(1);temp.Add(9);temp.Add(2);temp.Add(5);

            for (int i = 0; i < temp.Count; i++)
			{
                if (i < mListNumberBox.Count)
                {
                    mListNumberBox[i].Stop(temp[i]);
                }                
            }

            //isDialing = false;
        }

    }
}
