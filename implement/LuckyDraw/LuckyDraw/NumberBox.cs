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
        private string mValue;
        private long mTimeToEnd;

        private List<string> mRandomValList;
        
        //graphics
        System.Drawing.Font drawFont;
        System.Drawing.SolidBrush drawBrush;
        Bitmap mBackgroundBm;
        Bitmap mBackgroundBlurBm;

        private const string SEGOE_UI_SEMIBOLD_FONT = "Segoe UI Semibold";

        //method
        public NumberBox(Point pos, PointF margin, Size boxSize)
        {
            mDrawPos = pos;
            mMargin = margin;
            mYPosText = pos.Y;

            mYPosText = Utilities.genRandomeNumber(-160, 241);

            drawFont = new System.Drawing.Font("Segoe UI Semibold", 40, FontStyle.Bold);
            drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Gray);
            mBackgroundBm = Properties.Resources.imageBox;
            mBackgroundBlurBm = Properties.Resources.imageBlur;

            mDirection = 1;
            mTimeToEnd = 800;

            mBoxSize = boxSize;
            mFontSize = mBoxSize;

            mRandomValList = new List<string>();

            mValue = string.Empty;
        }

        private void drawBGImage(Graphics g, bool isBlur)
        {
            //draw image
            // Draw using this
            PointF drawP = convertToGlobal(mDrawPos.X , mDrawPos.Y);
            if (isBlur)
                g.DrawImage(mBackgroundBlurBm, drawP.X, drawP.Y, drawP.X + mBoxSize.Width, drawP.Y + mBoxSize.Height);
            else
                g.DrawImage(mBackgroundBm, drawP.X, drawP.Y, drawP.X + mBoxSize.Width, drawP.Y + mBoxSize.Height);
        }

        public void Start()
        {
            drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DarkGray);

            mIsDialing = true;
            mIsStopping = false;
            mDirection = 1;
        }

        public void Stop(string value)
        {
            //change font
            drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);

            float standardY = (mBoxSize.Height - mFontSize.Height)/2;
            //value = value % 10;

            //calculate distance
            //calculate near 
            mDirection = (mYPosText > standardY) ? -1 : 1;
            float distance = Math.Abs(mYPosText - standardY);

            mVeloc = (distance / mTimeToEnd) * Utilities.INTERVAL_DRAW_TIME * 2.0F;
            mValue = value;

            mIsDialing = false;
            mIsStopping = true;
}

        internal void SetRandomValList(List<string> candidateNameList)
        {
            mRandomValList = candidateNameList;
        }

        public void Draw(Graphics g)
        {

            float max = mBoxSize.Height - (mFontSize.Height - 114)/2;
            float min = - (114 + (mFontSize.Height - 114)/2);

            drawBGImage(g, false);
            if (mIsDialing)
            {
                drawBGImage(g, true);

                int randomIndex = Utilities.genRandomeNumber(0, mRandomValList.Count);
                if (randomIndex < mRandomValList.Count)
                    mValue = mRandomValList[randomIndex];
                //mValue = ++mValue % 10;

                mVeloc = Utilities.genRandomeNumber(40, 50);
                mYPosText += mVeloc;
                if (mYPosText > max)
                {
                    mYPosText = min;
                }
            }
            else if (mIsStopping)
            {
                mYPosText += mVeloc * mDirection;
                //Debug.WriteLine("mYPosText: " + mYPosText.ToString());
                float standardY = (mBoxSize.Height - mFontSize.Height) / 2;
                if ((1 == mDirection && mYPosText > standardY)||
                    (-1 == mDirection && mYPosText < standardY))
                {

                    mYPosText = standardY;
                    mVeloc = 0;
                   // mYPosText = (mBoxSize.Height - mFontSize.Height) / 2;                    
                }
                
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
                mFontSize = g.MeasureString(mValue, drawFont);
                string drawString = mValue.ToString();
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                PointF drawP = convertToGlobal(mDrawPos.X + (mBoxSize.Width - mFontSize.Width) / 2, mYPosText);
                g.DrawString(drawString, drawFont, drawBrush, drawP.X, drawP.Y, drawFormat);
            }

            //Pen pen = new Pen(drawBrush);

           // PointF drawR = convertToGlobal(mDrawPos.X + (mBoxSize.Width - mFontSize.Width) / 2, mYPosText);
           // g.DrawRectangle(pen, drawR.X, drawR.Y, mFontSize.Width, mFontSize.Height);
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
