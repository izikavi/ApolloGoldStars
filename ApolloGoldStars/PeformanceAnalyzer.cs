using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ApolloGoldStars
{
    public partial class PeformanceAnalyzer : Form
    {
        public PeformanceAnalyzer(string sCardName)
        {
            InitializeComponent();
            this.Text = sCardName + " Peformance Analyzer";
        }

        private void PeriodicRunButton_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            Thread thread1 = new Thread(CalculatePerAct);
            thread1.Start();

        }

        private void CalculatePerAct()
        {
            string data = MainForm.connection.PeriodicAct(Convert.ToInt32(PeriodicSec.Value.ToString()));

            List<int> lowOfRange = new List<int>();
            List<int> highOfRange = new List<int>();
            List<int> minTime = new List<int>();
            List<int> avgTime = new List<int>();
            List<int> maxTime = new List<int>();

            string[] strings = data.Split("Periodic activities execution time:");

            for (int i = 1; i < strings.Length; i++)
            {
                string[] rowSplit = strings[i].Split(new Char[] { '=', '\t' });
                minTime.Add(Convert.ToInt32(rowSplit[1].Replace("usec,", "")));
                maxTime.Add(Convert.ToInt32(rowSplit[3].Replace("usec,", "")));
                avgTime.Add(Convert.ToInt32(rowSplit[5].Substring(0, rowSplit[5].IndexOf("usec"))));
                lowOfRange.Add(Convert.ToInt32(rowSplit[6]));
                highOfRange.Add(Convert.ToInt32(rowSplit[8].Substring(0, rowSplit[8].IndexOf("\r"))));

            }

            label3.Invoke(new MethodInvoker(delegate {
                label3.Text = "max time tick = " + maxTime.Max().ToString() + " \n" +
                              "min time tick = " + minTime.Min().ToString() + " \n" +
                              "average time tick =" + String.Format("{0:0.##}", avgTime.Average()) + " \n"+
                              "num of ticks less than 10ms = "+lowOfRange.Sum()+" \n"+
                              "num of ticks longer than 10ms = " + highOfRange.Sum() + " \n" ;
            }));
        }

        private void HighObjButton_Click(object sender, EventArgs e)
        {
            HighCunsomersData highCunsomersData = new HighCunsomersData(Connection.sCardName, Convert.ToInt32(ThresholdNum.Value.ToString()));
            //processBar process = new processBar();
            this.Hide();
            highCunsomersData.ShowDialog();
            //process.Show();
            this.Show();
        }

        private void peractObjsRegButton_Click(object sender, EventArgs e)
        {

        }
    }
}
