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
    public partial class PeformanceAnalyzer : Form
    {

        public PeformanceAnalyzer(string sCardName)
        {
            InitializeComponent();
            this.Text = sCardName + " Peformance Analyzer";
        }

        private void PeformanceAnalyzer_Load(object sender, EventArgs e)
        {

        }

        private void PeriodicRunButton_Click(object sender, EventArgs e)
        {
            string data = MainForm.connection.PeriodicAct(Convert.ToInt32(PeriodicSec.Value.ToString()));
            List<int> minTick = new List<int>();
            List<int> minTime = new List<int>();
            List<int> maxTick = new List<int>();
            List<int> maxTime = new List<int>();

            for (int i = 0; i < PeriodicSec.Value; i++)
            {

            }

        }
    }
}
