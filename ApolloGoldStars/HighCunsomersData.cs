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
    public partial class HighCunsomersData : Form
    {
        private int m_threshold;
        public HighCunsomersData(string sCardName,int threshold)
        {
            m_threshold = threshold;
            InitializeComponent();
            this.Text = sCardName + " High Cunsomers Data";
            MainForm.connection.HighObjConsumption(threshold, this.dataGridView1);


            //foreach (DataRow dr in dt.Rows)
            //{
               // this.dataGridView1.Rows.Add(new string[] { dr.ItemArray.GetValue()});
            //}
           // BindingSource bs = new BindingSource();
            //bs.DataSource = dt;
            //this.dataGridView1.DataSource = bs;
             //this.dataGridView1.DataSource = dt;
        }

        private void HighCunsomersData_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            //MainForm.connection.HighObjConsumption(m_threshold);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DataTable dt = MainForm.connection.HighObjConsumption(m_threshold, this.backgroundWorker1);
            /*
            for (int i = 1; i <= 100; i++)
            {
                MainForm.connection.HighObjConsumption(m_threshold);
                // Wait 100 milliseconds.
                Thread.Sleep(100);
                // Report progress.
                backgroundWorker1.ReportProgress(i);
            }
            */
            
        }

        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView1.Show();
        }

        private void backgroundWorker1_ProgressChanged(object sender,
            ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            PerformanceProgressBar.Value = e.ProgressPercentage;
            // Set the text.
            this.Text = e.ProgressPercentage.ToString();
        }
    }
}
