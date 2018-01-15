﻿using System;
using System.Collections.Generic;
using System.Drawing;
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

            mBgColor = Color.FromArgb(153, 158, 162);


            for (int i = 0; i < numberOfBox; i++)
            {
                Point p = new Point(200 * i, 0);

                NumberBox nb = new NumberBox(p);
                mListNumberBox.Add(nb);
            }
        }

        public void update(Graphics g)
        {
            if (isDialing)
            {
                g.Clear(mBgColor);
                g.TextRenderingHint = TextRenderingHint.AntiAlias;

                for (int i = 0; i < mListNumberBox.Count; i++)
                {
                    mListNumberBox[i].Draw(g);
                }
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
                mListNumberBox[i].Stop(temp[i]);
            }

            //isDialing = false;
        }

    }
}
