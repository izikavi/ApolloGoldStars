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
            if (e.RowIndex == -1)
            {
                return;
            }
            string strData = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + MainForm.connection.ConvertToCorrectFormat(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value == "Delete")
            {
                MainForm.connection.DeleteFromPerAct(strData);
                dataGridView1.Rows[e.RowIndex].Cells[6].Value = "Add";
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
            }
            else
            {
                MainForm.connection.AddtoPerAct(strData);
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

        private void PeractObjs_FormClosing(Object sender, FormClosingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    string strData = row.Cells[1].Value.ToString() + " " + MainForm.connection.ConvertToCorrectFormat(row.Cells[2].Value.ToString());
                    if (row.Cells[6].Value == "Add")
                    {
                        MainForm.connection.AddtoPerAct(strData);
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "error");
                }
            }
        }
    }
}
