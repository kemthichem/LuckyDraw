using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyDraw
{
    class LuckyDrawController
    {
        public bool IsDialing;
        public List<Person> PersonList;
        public List<Person> AwardPersonList;

        public LuckyDrawController()
        {
            IsDialing = false;
        }
        public void AddAward()
        {

        }
        public void RemoveAward()
        {

        }
        public void EditAward()
        {

        }

        public void StartLucky()
        {
           IsDialing = true;
        }
        public int Dial()
        {
            IsDialing = false;
            return Utilities.genRandomeNumber(1, 1000);
        }

        public void Stop()
        {
            IsDialing = false;
        }

        public void LoadDataBase(string path)
        {

        }

    }
}
