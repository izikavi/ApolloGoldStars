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
    public partial class LogForm : Form
    {
        private TelnetConnection m_con;

        public LogForm(string sCardName)//(TelnetConnection con)
        {
            InitializeComponent();
            this.Text = sCardName;
            //m_con = con;
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            //m_con.Login(); // TODO: write the login and build the form
        }

        private void LoggerCreator_Click(object sender, EventArgs e)
        {
            LoggerCreator loggerCreator = new LoggerCreator(this.Text);
            this.Hide();
            loggerCreator.ShowDialog();
            this.Show();
        }
    }
}
