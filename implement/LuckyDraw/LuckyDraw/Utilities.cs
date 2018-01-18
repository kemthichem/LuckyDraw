using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyDraw
{
    class Utilities
    {
        static public int genRandomeNumber(int min, int max)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int rInt = r.Next(min, max); //for ints
            return rInt;
        }
        static public long getNowTimeAtMilisecond()
        {
            long time = (long)(DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
            return time;
        }
    }
}
