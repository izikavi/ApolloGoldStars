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
    public partial class LoggerCreatorOutput : Form
    {
        public LoggerCreatorOutput(string sOutput, string sCardName)
        {
            InitializeComponent();
            label1.Text = sOutput;
            this.Text = sCardName+ " Logger Creator Output";
        }

        private void LoggerCreatorOutput_Load(object sender, EventArgs e)
        {

        }
    }
}
