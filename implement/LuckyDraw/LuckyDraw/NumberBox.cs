using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyDraw
{
    class NumberBox
    {
        //atributes
        private bool mDirection; // true: up->down, false: down-up
        private float mVeloc;
        private float mAccel;
        private Size mBoxSize;
        private Size mFontSize;
        private Point mDrawPos;
        private float mYPosText;
        private int mValue;

        private int mTimeToEnd;


        //graphics
        System.Drawing.Font drawFont;
        System.Drawing.SolidBrush drawBrush;
        Bitmap mBackgroundBm;

        private const string SEGOE_UI_SEMIBOLD_FONT = "Segoe UI Semibold";
        
        //method
        public NumberBox(Point pos)
        {
            mDrawPos = pos;
            mYPosText = pos.Y;

            mValue = genRandomeNumber(0, 9);
            mYPosText = genRandomeNumber(-160, 240);

            drawFont = new System.Drawing.Font("Segoe UI Semibold", 120, FontStyle.Bold);
            drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Gray);
            mBackgroundBm = Properties.Resources.imageBlur;
            
            mDirection = true;
            mTimeToEnd = 4000;
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

        private void drawBGImage(bool isBlur)
        {

        }

        private void drawNumber(Graphics g)
        {

        }

        public void Start()
        {

        }

        public void Stop(int value)
        {

        }
        
        public void Draw(Graphics g)
        {        
            //draw image            
            // Draw using this   
            g.DrawImage(mBackgroundBm, mDrawPos.X, mDrawPos.Y);

            mValue = ++mValue % 10;
            string drawString = mValue.ToString();

            mYPosText += 80;
            if (mYPosText > 240)
            {
                mYPosText = -160;
            }            

            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            g.DrawString(drawString, drawFont, drawBrush, mDrawPos.X + 10, mYPosText, drawFormat);
        }
    }
}
