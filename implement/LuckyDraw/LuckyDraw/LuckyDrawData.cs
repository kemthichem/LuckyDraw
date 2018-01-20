using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyDraw
{
    public class LuckyDrawData
    {
        public string Path { get; set; }
        public LuckyDrawData(string path)
        {
            Path = path;
        }
        public List<Person> GetListPersonFormDatabase()
        {
            var personList = new List<Person>();
            var importExcelFile = new ImportExcelFile(Path);

            personList = importExcelFile.GetPeople();
            
            return personList;
        }
        public bool SaveListPersonToDatabase(List<Person> personList, string savePath)
        {
            return true;
        }
    }
}
