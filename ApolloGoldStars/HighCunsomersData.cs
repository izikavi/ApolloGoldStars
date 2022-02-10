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
        public HighCunsomersData(string sCardName,int threshold)
        {
            InitializeComponent();
            this.Text = sCardName + " High Cunsomers Data";
            MainForm.connection.HighObjConsumption(threshold);
        }

        private void HighCunsomersData_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
