using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApolloGoldStars
{
    public partial class LogForm : Form
    {
        public LogForm(string sCardName)
        {
            InitializeComponent();
            this.Text = sCardName;
            //m_con = con;
        }

        private void LoggerCreator_Click(object sender, EventArgs e)
        {
            LoggerCreator loggerCreator = new LoggerCreator(this.Text);
            this.Hide();
            loggerCreator.ShowDialog();
            this.Show();
        }

        private void PerformanceAnalyzer_Click(object sender, EventArgs e)
        {
            PeformanceAnalyzer performanceAnalyzer = new PeformanceAnalyzer(this.Text);
            this.Hide();
            performanceAnalyzer.ShowDialog();
            this.Show();
        }

        private void Scriptbutton_Click(object sender, EventArgs e)
        {
            UserScript userScript = new UserScript();
            this.Hide();
            userScript.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application oPPT;
            Presentations objPresSet;
            Presentation objPres;
            SlideShowView oSlideShowView;
            oPPT = new Application();
            // Show PowerPoint to the user.
            oPPT.Visible = MsoTriState.msoTrue;
            objPresSet = oPPT.Presentations;
            objPres = objPresSet.Open("C:\Users\iavinoam\Downloads\Techthon22- Apollo Gold star.pptx", MsoTriState.msoFalse,
                    MsoTriState.msoTrue, MsoTriState.msoTrue);
        }
    }
}
