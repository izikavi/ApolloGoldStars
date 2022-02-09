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
        string m_sCardName = "";
        public LoggerCreator(string sCardName)
        {
            InitializeComponent();
            this.Text = sCardName + " Logger Creator";
            m_sCardName = sCardName;
            FileNameLabel.Hide();
            FilePathLabel.Hide();
            saveToFilecheckBox.Enabled = !string.IsNullOrWhiteSpace(FileNameLabel.Text);
            saveToFilecheckBox.Checked = !string.IsNullOrWhiteSpace(FileNameLabel.Text);
            //string sLogShow  = MainForm.connection.LogShow();
            //sLogShow = sLogShow.Replace("\0","");
            //label1.Text = sLogShow.Substring(sLogShow.IndexOf("\n"));

            //MessageBox.Show(sLogShow);

        }

        private void openFileDialogButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileNameLabel.Show();
                FilePathLabel.Show();
                FileNameLabel.Text = saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf("\\")+1);
                FilePathLabel.Text = saveFileDialog1.FileName;
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            string sOutput = "";
            if(ShowErrors.Checked)
            {
                sOutput += MainForm.connection.LogShow();
            }
            if(ShowAlarm.Checked)
            {
                sOutput += MainForm.connection.AlaramAll(clearHisAll.Checked);
            }
            if(ShowAlarmonport.Checked)
            {
                List<string> list = portCheckBox.Text.Split(",").ToList();
                sOutput += MainForm.connection.AlaramPortList(portClearhis.Checked, list);
            }

            if(UserCommandsCheckBox.Checked && userCommandsTextBox.Text!= "")
            {
                sOutput += MainForm.connection.UserDbgCommands(userCommandsTextBox.Text.Split("\r\n").ToList());
            }


            if (saveToFilecheckBox.Checked)
            {
                SaveToFile(sOutput);
            }
            if(ShowToScreenCheckBox.Checked)
            {
                LoggerCreatorOutput loggerCreatorOutput = new LoggerCreatorOutput(sOutput, m_sCardName);
                this.Hide();
                loggerCreatorOutput.ShowDialog();
                this.Show();
            }
        }

        private void LoggerCreator_Load(object sender, EventArgs e)
        {
        }

        private void FileNameLabel_Change(object sender, EventArgs e)
        {
            saveToFilecheckBox.Enabled = !string.IsNullOrWhiteSpace(FileNameLabel.Text);
            saveToFilecheckBox.Checked = !string.IsNullOrWhiteSpace(FileNameLabel.Text);
        }

        private void SaveToFile(string sOutput)
        {
            string path = FilePathLabel.Text; // This text is added only once to the file.

            string createText = sOutput; 
            File.WriteAllText(path, createText, Encoding.UTF8);
            MessageBox.Show("file " + path + " successfully created");
        }
    }
}
