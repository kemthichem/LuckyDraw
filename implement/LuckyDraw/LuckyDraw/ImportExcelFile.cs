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

        public ImportExcelFile(string fileName)
        {
            Application = new Application();
            Workbook = Application.Workbooks.Open(fileName, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Worksheet = (Worksheet)Workbook.Worksheets.get_Item(1);
            Range = Worksheet.UsedRange;
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
                    int attendee;
                    int.TryParse(attendeeIdAsString, out attendee);

                    if (!people.Any(a => a.Id == attendee))
                    {
                        people.Add(new Person
                        {
                            Id = attendee,
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

        public int GetNumberOfPeople()
        {
            return GetPeople().Max(a => a.Id);
        }
    }
}
