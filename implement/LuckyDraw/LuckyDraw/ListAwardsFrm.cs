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
        public ListAwardsFrm(List<Person> list)
        {
            this.list = list;
            InitializeComponent();
        }

        private void ListAwardsFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.list;
        }
    }
}
