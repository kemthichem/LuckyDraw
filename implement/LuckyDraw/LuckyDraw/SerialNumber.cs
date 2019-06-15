using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;


namespace LuckyDraw
{
    class SerialNumber
    {
        const int MIN_NUMBOX = 1;
        const int WIDTH_IMAGE = 1200;
        const int OFFSET = 20;
        const int MARGIN_ONE_SIDE = 30;
        //Attributes
        private int NumberOfBox;

        int FullWidth;
        int InsideWidth;

        //graphic

        private List<NumberBox> mListNumberBox;

        public SerialNumber()
        {
            mListNumberBox = new List<NumberBox>();
            ChangeNumberBox(MIN_NUMBOX);           
        }

        public void initRandomValueList()
        {
            for (int i = 0; i < mListNumberBox.Count; i++)
            {
                //mListNumberBox[i].
            }

        }
        public int ChangeNumberBox(int numberOfBox)
        {
            mListNumberBox.Clear();

            this.NumberOfBox = numberOfBox < MIN_NUMBOX ? MIN_NUMBOX : numberOfBox;

            for (int i = 0; i < NumberOfBox; i++)
            {
                Point p = new Point((WIDTH_IMAGE + OFFSET) * i, 0);
                PointF margin = new PointF(30, 28);
                Size boxSize = new Size(WIDTH_IMAGE, 248);

                NumberBox nb = new NumberBox(p, margin, boxSize);
                mListNumberBox.Add(nb);
            }

            //full width
            InsideWidth = (NumberOfBox * WIDTH_IMAGE) + (NumberOfBox - 1) * OFFSET;
            FullWidth = InsideWidth + MARGIN_ONE_SIDE * 2;
            return FullWidth;
        }

        private void DrawBorder(Graphics g)
        {
            const float xradius = 10;
            const float yradius = 10;

            // Top rectangle.

            RectangleF rect = new RectangleF(
                1.5F, 1.5F,
                FullWidth - (1.5F * 2),
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
                FullWidth - (15*2),
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

        internal void SetRandomValList(List<string> candidateNameList)
        {
            for (int i = 0; i < mListNumberBox.Count; i++)
            {
                mListNumberBox[i].SetRandomValList(candidateNameList);
            }
        }

        public void Draw(Graphics g)
        {
            //g.Clear()
            Bitmap transparentBm = Properties.Resources.transparent;
            g.DrawImage(transparentBm, g.ClipBounds);

            DrawBorder(g);

            //draw number
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            g.SetClip(new Rectangle(MARGIN_ONE_SIDE, 28, InsideWidth, 250));
            for (int i = 0; i < mListNumberBox.Count; i++)
            {
                mListNumberBox[i].Draw(g);
            }
        }

        public void Start()
        {
            for (int i = 0; i < mListNumberBox.Count; i++)
            {
                mListNumberBox[i].Start();
            }
        }

        public void Stop(string value)
        {
            //         List<int> temp = new List<int>(this.NumberOfBox);

            //         for (int i = this.NumberOfBox; i > 0; i--)
            //         {
            //             int deci = (int)Math.Pow(10, i - 1);
            //             int val = value / deci;
            //             value -= (val * deci);

            //             temp.Add(val);
            //         }


            //         for (int i = 0; i < temp.Count; i++)
            //{
            //             if (i < mListNumberBox.Count)
            //             {
            //                 mListNumberBox[i].Stop(temp[i]);
            //             }
            //         }



            for (int i = 0; i < mListNumberBox.Count; i++)
            {

                    mListNumberBox[i].Stop(value);
            }
        }


        internal void Reset()
        {
            for (int i = 0; i < mListNumberBox.Count; i++)
            {
                mListNumberBox[i].mIsDialing = mListNumberBox[i].mIsStopping = false;
            }
        }
    }
}
