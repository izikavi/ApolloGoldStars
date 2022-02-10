using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApolloGoldStars
{
    public partial class PeractObjs : Form
    {
        public PeractObjs(string sCardName)
        {
            InitializeComponent();

            this.Text = sCardName + " Peract Objs";

            MainForm.connection.PeractObjs(this.dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value == "Delete")
            {
                dataGridView1.Rows[e.RowIndex].Cells[6].Value = "Add";
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].Cells[6].Value = "Delete";
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void PeractObjs_Load(object sender, EventArgs e)
        {
            dataGridView1.Width =
                        dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
                        + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 30;
            this.Width = dataGridView1.Width + 10;
        }
    }
}
