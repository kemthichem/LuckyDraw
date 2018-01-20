using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyDraw
{
    public partial class ListAwardsFrm : Form
    {
        private List<Person> list;
        private string curId;
        private Form1 mainFrm;
        public ListAwardsFrm(Form1 form, List<Person> list, string id)
        {
            mainFrm = form;
            this.list = list;
            curId = id;
            InitializeComponent();
        }

        private void ListAwardsFrm_Load(object sender, EventArgs e)
        {
            SortableList<Person> persons = new SortableList<Person>(this.list);
            dataGridView1.DataSource = persons;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == curId.ToString())
                {
                    row.Selected = true;
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            mainFrm.SaveArchivedPerson();
        }
    }
}
