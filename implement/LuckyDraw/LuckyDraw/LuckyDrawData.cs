using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyDraw
{
    public class LuckyDrawData
    {
        public LuckyDrawData(string path)
        {

        }
        public List<Person> GetListPersonFormDatabase()
        {
            List<Person> PersonList = new List<Person>();

            Person p1 = new Person();
            p1.Id = "0001";
            p1.Name = "Huỳnh Văn Thân";
            p1.Info = "GCS/ICT";
            PersonList.Add(p1);

            Person p2 = new Person();
            p2.Id = "0002";
            p2.Name = "Lê Phước Thạch";
            p2.Info = "GCS/EMB";
            PersonList.Add(p2);

            Person p3 = new Person();
            p3.Id = "0008";
            p3.Name = "Lê Văn Sáng";
            p3.Info = "TMA/EMB";
            PersonList.Add(p3);

            Person p4 = new Person();
            p4.Id = "0009";
            p4.Name = "Trí Phạm";
            p4.Info = "TMA/EMB1";
            PersonList.Add(p4);

            Person p5 = new Person();
            p5.Id = "0005";
            p5.Name = "Nhật Linh";
            p5.Info = "TMA/EMB2";
            PersonList.Add(p5);

            //PersonList.Clear();
            return PersonList;
        }
        public bool SaveListPersonToDatabase(List<Person> personList, string savePath)
        {
            return true;
        }
    }
}
