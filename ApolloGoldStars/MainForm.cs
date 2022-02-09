using System.Text;
using System.Net.Sockets;
using System.Net;

namespace ApolloGoldStars
{

    public partial class MainForm : Form
    {
        public static Connection? connection;
        public MainForm()
        {
            InitializeComponent();
            this.ConnectButton.Enabled = !string.IsNullOrWhiteSpace(RcpIpTextBox.Text) && !string.IsNullOrWhiteSpace(ProtocolBox.Text);
        }

        private void RcpIpTextBox_TextChanged(object sender, EventArgs e)
        {
            ConnectButton.Enabled = !string.IsNullOrWhiteSpace(RcpIpTextBox.Text) && !string.IsNullOrWhiteSpace(ProtocolBox.Text);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string host = RcpIpTextBox.Text.Trim();
            int port = Convert.ToInt32(PortNum.Value.ToString());
            int slot = Convert.ToInt32(SlotNo.Value.ToString());
            bool is9901 = Io9901Box.Checked;
            //Protocol protocol = ProtocolBox.SelectedItem.ToString().Equals("Telnet", StringComparison.Ordinal) ? Protocol.Telnet : Protocol.SSH;

            try
            {
                MainForm.connection = new Connection(host, port, slot, is9901, UsernameBox.Text, PasswordBox.Text);
                //con.Login(UsernameBox.Text, PasswordBox.Text, 100);
                //LogForm logForm = new LogForm(con);
                LogForm logForm = new LogForm(Connection.sCardName + " - Slot " + slot);
                this.Hide();
                logForm.ShowDialog();
                this.Show();
            }
            catch (SocketException err)
            {
                MessageBox.Show(err.Message, "Connection error");
            }
        }

        private void ProtocolBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectButton.Enabled = !string.IsNullOrWhiteSpace(RcpIpTextBox.Text) && !string.IsNullOrWhiteSpace(ProtocolBox.Text);
            if (ProtocolBox.SelectedIndex == 0) // Telnet
            {
                this.PortNum.Maximum = new decimal(new int[] {
                2200,
                0,
                0,
                0});
                this.PortNum.Minimum = new decimal(new int[] {
                21,
                0,
                0,
                0});
                this.PortNum.Value = new decimal(new int[] {
                23,
                0,
                0,
                0});
            }
            else if (ProtocolBox.SelectedIndex == 1) // SSH
            {
                this.PortNum.Maximum = new decimal(new int[] {
                2222,
                0,
                0,
                0});
                this.PortNum.Minimum = new decimal(new int[] {
                22,
                0,
                0,
                0});
                this.PortNum.Value = new decimal(new int[] {
                22,
                0,
                0,
                0});
            }
        }
        private void OnKeyPress(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                //enter key has been pressed
                // add your code
            }

        }
    }
}