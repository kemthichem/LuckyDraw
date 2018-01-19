using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyDraw
{
    class Award
    {
        public Award(int id, string name, int count)
        {
            this.ID = id;
            this.Name = name;
            this.Count = count;
        }

        public Award(int id, string name)
        {
            this.ID = id;
            this.Name = name;
            this.Count = 0;
        }

        public int ID {get; set;}
        public string Name { get; set; }
        public int Count { get; set; }
        public void PlusOne()
        {
            this.Count++;
        }
        public void Reset()
        {
            this.Count = 0;
        }
    }
}
