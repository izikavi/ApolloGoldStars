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
    }
}
