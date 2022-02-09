namespace ApolloGoldStars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogCreatorbutton_Click(object sender, EventArgs e)
        {

        }

        private void RcpIpTextBox_TextChanged(object sender, EventArgs e)
        {
            LogCreatorbutton.Enabled = !string.IsNullOrWhiteSpace(RcpIpTextBox.Text);
            analyzerButton.Enabled = !string.IsNullOrWhiteSpace(RcpIpTextBox.Text);
        }
    }
}