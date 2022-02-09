namespace ApolloGoldStars
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RcpIpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SlotNo = new System.Windows.Forms.NumericUpDown();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.Io9901Box = new System.Windows.Forms.CheckBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PortNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ProtocolBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SlotNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortNum)).BeginInit();
            this.SuspendLayout();
            // 
            // RcpIpTextBox
            // 
            this.RcpIpTextBox.AllowDrop = true;
            this.RcpIpTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RcpIpTextBox.Location = new System.Drawing.Point(151, 241);
            this.RcpIpTextBox.MaxLength = 15;
            this.RcpIpTextBox.Name = "RcpIpTextBox";
            this.RcpIpTextBox.PlaceholderText = "IP";
            this.RcpIpTextBox.Size = new System.Drawing.Size(248, 55);
            this.RcpIpTextBox.TabIndex = 0;
            this.RcpIpTextBox.Text = "172.30.88.72";
            this.RcpIpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RcpIpTextBox.TextChanged += new System.EventHandler(this.RcpIpTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "RCP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slot";
            // 
            // SlotNo
            // 
            this.SlotNo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SlotNo.Location = new System.Drawing.Point(151, 378);
            this.SlotNo.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SlotNo.Name = "SlotNo";
            this.SlotNo.Size = new System.Drawing.Size(62, 55);
            this.SlotNo.TabIndex = 4;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnectButton.Location = new System.Drawing.Point(203, 518);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(330, 81);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // Io9901Box
            // 
            this.Io9901Box.AutoSize = true;
            this.Io9901Box.BackColor = System.Drawing.Color.Transparent;
            this.Io9901Box.Checked = true;
            this.Io9901Box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Io9901Box.Location = new System.Drawing.Point(405, 262);
            this.Io9901Box.Name = "Io9901Box";
            this.Io9901Box.Size = new System.Drawing.Size(78, 29);
            this.Io9901Box.TabIndex = 7;
            this.Io9901Box.Text = "9901";
            this.Io9901Box.UseVisualStyleBackColor = false;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameBox.Location = new System.Drawing.Point(531, 302);
            this.UsernameBox.MaxLength = 256;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PlaceholderText = "username";
            this.UsernameBox.Size = new System.Drawing.Size(248, 55);
            this.UsernameBox.TabIndex = 8;
            this.UsernameBox.Text = "root";
            this.UsernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordBox.Location = new System.Drawing.Point(531, 379);
            this.PasswordBox.MaxLength = 256;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PlaceholderText = "Password";
            this.PasswordBox.Size = new System.Drawing.Size(248, 55);
            this.PasswordBox.TabIndex = 10;
            this.PasswordBox.Text = "Manor441";
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // PortNum
            // 
            this.PortNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PortNum.Location = new System.Drawing.Point(149, 306);
            this.PortNum.Maximum = new decimal(new int[] {
            2130,
            0,
            0,
            0});
            this.PortNum.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PortNum.Name = "PortNum";
            this.PortNum.Size = new System.Drawing.Size(110, 55);
            this.PortNum.TabIndex = 12;
            this.PortNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PortNum.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 48);
            this.label3.TabIndex = 11;
            this.label3.Text = "Port";
            // 
            // ProtocolBox
            // 
            this.ProtocolBox.FormattingEnabled = true;
            this.ProtocolBox.Items.AddRange(new object[] {
            "Telnet",
            "SSH"});
            this.ProtocolBox.Location = new System.Drawing.Point(531, 242);
            this.ProtocolBox.Name = "ProtocolBox";
            this.ProtocolBox.Size = new System.Drawing.Size(248, 33);
            this.ProtocolBox.TabIndex = 13;
            this.ProtocolBox.Text = "Telnet";
            this.ProtocolBox.SelectedIndexChanged += new System.EventHandler(this.ProtocolBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImage = global::ApolloGoldStars.Properties.Resources.ribbon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 644);
            this.Controls.Add(this.ProtocolBox);
            this.Controls.Add(this.PortNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.Io9901Box);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.SlotNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RcpIpTextBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Apollo Gold Stars";
            ((System.ComponentModel.ISupportInitialize)(this.SlotNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox RcpIpTextBox;
        private Label label1;
        private Label label2;
        private NumericUpDown SlotNo;
        private Button ConnectButton;
        private CheckBox Io9901Box;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private NumericUpDown PortNum;
        private Label label3;
        private ComboBox ProtocolBox;
    }
}