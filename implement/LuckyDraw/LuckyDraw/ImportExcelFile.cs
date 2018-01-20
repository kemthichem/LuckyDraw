using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Linq;

namespace LuckyDraw
{
    public class ImportExcelFile
    {
        public Application Application;
        public Workbook Workbook;
        public Worksheet Worksheet;
        public string Path;

        public ImportExcelFile(string path)
        {
            Path = path;
        }

        public List<Person> GetPeople()
        {
            var people = new List<Person>();
            try
            {
                Application = new Application();
                Workbook = Application.Workbooks.Open(Path, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Worksheet = (Worksheet)Workbook.Worksheets.get_Item(1);
            }
            catch
            {
                return people;
            }
            
            var range = Worksheet.UsedRange;
            
            var totalRows = range.Rows.Count;
            for (var row = 2; row <= totalRows; row++)
            {
                string attendeeId;
                string attendeeName;
                string attendeeInfor;
                try
                {
                    attendeeId = (string)(range.Cells[row, 1] as Range).Value2.ToString();
                    attendeeName = (string)(range.Cells[row, 2] as Range).Value2.ToString();
                    attendeeInfor = (string)(range.Cells[row, 3] as Range).Value2.ToString();

                    if (!people.Any(a => a.Id == attendeeId))
                    {
                        people.Add(new Person
                        {
                            Id = attendeeId,
                            Name = attendeeName,
                            Info = attendeeInfor,
                            AwardName = string.Empty
                        });
                    }
                }
                catch
                {
                }
            }

            Workbook.Close(true, null, null);
            Application.Quit();
            ReleaseComObject(Worksheet, Workbook, Application);

            return people;
        }

        public bool SaveAward(List<Person> personList)
        {
            if (personList == null) return false;

            try
            {
                object misValue = System.Reflection.Missing.Value;
                Application = new Application();
                Workbook = Application.Workbooks.Add(misValue);
                Worksheet = (Worksheet)Workbook.Worksheets.get_Item(1);

                Worksheet.Cells[1, 1] = "ID";
                Worksheet.Cells[1, 2] = "NAME";
                Worksheet.Cells[1, 3] = "INFOR";
                Worksheet.Cells[1, 4] = "AWARD";

                if (personList.Any())
                {
                    for (var i = 0; i < personList.Count; i++)
                    {
                        Worksheet.Cells[i + 2, 1] = personList[i].Id;
                        Worksheet.Cells[i + 2, 2] = personList[i].Name;
                        Worksheet.Cells[i + 2, 3] = personList[i].Info;
                        Worksheet.Cells[i + 2, 4] = personList[i].AwardName;
                    }
                }

                Workbook.SaveAs(Path, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                Workbook.Close(true, misValue, misValue);
                Application.Quit();

                ReleaseComObject(Worksheet, Workbook, Application);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ReleaseComObject(Worksheet worksheet, Workbook workbook, Application application)
        {
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(application);
        }
    }
}
