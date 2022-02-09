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
    }
}
