using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Linq;

namespace LuckyDraw
{
    public class ImportExcelFile
    {
        public Range Range;
        public Application Application;
        public Workbook Workbook;
        public Worksheet Worksheet;
        public string Path;

        public ImportExcelFile(string path)
        {
            //Path = path;
            Path = path;
        }

        private bool InitializeReadFile()
        {
            try
            {
                Application = new Application();
                Workbook = Application.Workbooks.Open(Path, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Worksheet = (Worksheet)Workbook.Worksheets.get_Item(1);
                Range = Worksheet.UsedRange;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool InitializeSaveFile()
        {
            try
            {
                object misValue = System.Reflection.Missing.Value;
                Application = new Application();
                Workbook = Application.Workbooks.Add(misValue);
                Worksheet = (Worksheet)Workbook.Worksheets.get_Item(1);
                return true;
            }
            catch
            {
                return false;
            }
        }


        private void Realease()
        {
            Workbook.Close(true, null, null);
            Application.Quit();

            Marshal.ReleaseComObject(Worksheet);
            Marshal.ReleaseComObject(Workbook);
            Marshal.ReleaseComObject(Application);
        }

        public List<Person> GetPeople()
        {
            var people = new List<Person>();

            if (!InitializeReadFile())
            {
                return people;
            }

            var totalRows = Range.Rows.Count;
            for (var row = 2; row <= totalRows; row++)
            {
                string attendeeIdAsString;
                string attendeeName;
                string attendeeInfor;
                try
                {
                    attendeeIdAsString = (string)(Range.Cells[row, 1] as Range).Value2.ToString();
                    attendeeName = (string)(Range.Cells[row, 2] as Range).Value2.ToString();
                    attendeeInfor = (string)(Range.Cells[row, 3] as Range).Value2.ToString();

                    if (!people.Any(a => a.Id == attendeeIdAsString))
                    {
                        people.Add(new Person
                        {
                            Id = attendeeIdAsString,
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

            Realease();

            return people;
        }

        public bool SaveAward(List<Person> personList, string savePath)
        {

            Worksheet.Cells[1, 1] = "ID";
            Worksheet.Cells[1, 2] = "Name";
            Worksheet.Cells[1, 3] = "Infor";
            Worksheet.Cells[1, 4] = "Award";

            if (personList == null) return false;
            





            //xlWorkBook.SaveAs("d:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //Marshal.ReleaseComObject(xlWorkSheet);
            //Marshal.ReleaseComObject(xlWorkBook);
            //Marshal.ReleaseComObject(xlApp);
            return true;
        }
    }
}
