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
            dataGridView1.Hide();
        }

        private void HighCunsomersData_Shown(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MainForm.connection.HighObjConsumption(m_threshold, this.dataGridView1, this.backgroundWorker1);
        }

        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView1.Show();
            PerformanceProgressBar.Hide();
            label1.Hide();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            PerformanceProgressBar.Value = e.ProgressPercentage;
            // Set the text.
            this.label1.Text = e.ProgressPercentage.ToString() + "%";
        }
    }
}
