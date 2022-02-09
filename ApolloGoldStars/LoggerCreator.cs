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
    public partial class LoggerCreator : Form
    {
        public LoggerCreator(string sCardName)
        {
            InitializeComponent();
            this.Text = sCardName + " Logger Creator";
            MainForm.connection.LogShow();
        }
    }
}
