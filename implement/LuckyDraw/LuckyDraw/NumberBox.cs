using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LuckyDraw
{
    class NumberBox
    {
        //
        private PointF mMargin;

        //attributes
        private int mDirection; // 1: up->down, -1: down-up
        private float mVeloc;
        private Size mBoxSize;
        private SizeF mFontSize;
        private Point mDrawPos;
        private float mYPosText;
        private int mValue;

        private long mTimeToEnd;

        private long mStopTime;

        //graphics
        System.Drawing.Font drawFont;
        System.Drawing.SolidBrush drawBrush;
        Bitmap mBackgroundBm;
        Bitmap mBackgroundBlurBm;

        private const string SEGOE_UI_SEMIBOLD_FONT = "Segoe UI Semibold";
        
        //method
        public NumberBox(Point pos, PointF margin)
        {
            mDrawPos = pos;
            mMargin = margin;
            mYPosText = pos.Y;

            mValue = genRandomeNumber(0, 9);
            mYPosText = genRandomeNumber(-160, 240);

            drawFont = new System.Drawing.Font("Segoe UI Semibold", 120, FontStyle.Bold);
            drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Gray);
            mBackgroundBm = Properties.Resources.imageBox;
            mBackgroundBlurBm = Properties.Resources.imageBlur;

            mDirection = 1;
            mTimeToEnd = 1500;

            mBoxSize = new Size(180, 248);
            mFontSize = mBoxSize;
        }

        static bool genRandomDirect()
        {
            return true;
        }
        static int genRandomeNumber(int min, int max)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int rInt = r.Next(min, max); //for ints
            return rInt;
        }
        static long getNowTimeAtMilisecond()
        {
            long time = (long)(DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
            return time;
        }

        private void drawBGImage(Graphics g, bool isBlur)
        {
            //draw image            
            // Draw using this
            PointF drawP = convertToGlobal(mDrawPos.X , mDrawPos.Y);

            if (isBlur)
                g.DrawImage(mBackgroundBlurBm, drawP.X, drawP.Y);
            else
                g.DrawImage(mBackgroundBm, drawP.X, drawP.Y);
        }

        private void drawNumber(Graphics g)
        {

        }

        public void Start()
        {
            drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Gray);

            mIsDialing = true;
            mIsStopping = false;
            mDirection = 1;
        }

        public void Stop(int value)
        {
            //change font
            drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            float standardY = (mBoxSize.Height - mFontSize.Height)/2;
            value = value % 10;

            //calculate distance
            //calculate near 
            mDirection = (mYPosText > standardY) ? -1 : 1;
            float distance = Math.Abs(mYPosText - standardY);
            mStopTime = getNowTimeAtMilisecond();
            mVeloc = (distance / mTimeToEnd) * 30;
            mValue = value;

            mIsDialing = false;
            mIsStopping = true;
        }
        
        public void Draw(Graphics g)
        {

            float max = mBoxSize.Height - (mFontSize.Height - 114)/2;
            float min = - (114 + (mFontSize.Height - 114)/2);

            drawBGImage(g, false);
            if (mIsDialing)
            {
                drawBGImage(g, true);

                mValue = ++mValue % 10;


                mVeloc = genRandomeNumber(50, 120);
                mYPosText += mVeloc;
                if (mYPosText > max)
                {
                    mYPosText = min;
                }
            }
            else if (mIsStopping)
            {
                Debug.WriteLine("Milisecond: " + getNowTimeAtMilisecond().ToString());

                if ((getNowTimeAtMilisecond() - mStopTime) >= mTimeToEnd)
                {
                    //mIsStopping = false;
                    mVeloc = 0;
                    mYPosText = (mBoxSize.Height - mFontSize.Height) / 2;
                }
                mYPosText += mVeloc * mDirection;
                if (mYPosText > max)
                {
                    mYPosText = min;
                }
                if (mYPosText < min)
                {
                    mYPosText = max;
                }
            }

            if (mIsDialing || mIsStopping)
            {
                string drawString = mValue.ToString();
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                PointF drawP = convertToGlobal(mDrawPos.X + (mBoxSize.Width - mFontSize.Width) / 2, mYPosText);
                g.DrawString(drawString, drawFont, drawBrush, drawP.X, drawP.Y, drawFormat);
            }

            Pen pen = new Pen(drawBrush);
           // g.DrawRectangle(pen, mDrawPos.X + (mBoxSize.Width - mFontSize.Width) / 2, mYPosText, mFontSize.Width, mFontSize.Height);

            mFontSize = g.MeasureString("1", drawFont);
        }

        private PointF convertToGlobal(float X, float Y)
        {
            //return new PointF(X , Y );
            return new PointF(X + mMargin.X, Y + mMargin.Y);
        }

        public bool mIsStopping { get; set; }

        public bool mIsDialing { get; set; }
    }
}
