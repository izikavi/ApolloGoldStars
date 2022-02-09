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
            //TextReader reder = File.OpenText(@"c:\temp\MyTest.txt");
            string[] readText = File.ReadAllLines(@"c:\temp\MyTest.txt");
            string text = "";
            foreach (string s in readText)
            {
                text += s;
            }
            //richTextBox1.Text = reder.ReadToEnd().ToString();
            richTextBox1.Text = text;
            
        }
    }
}
