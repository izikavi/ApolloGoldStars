namespace ApolloGoldStars
{
    partial class Form1
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
            this.RcpIpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SlotNo = new System.Windows.Forms.NumericUpDown();
            this.LogCreatorbutton = new System.Windows.Forms.Button();
            this.analyzerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SlotNo)).BeginInit();
            this.SuspendLayout();
            // 
            // RcpIpTextBox
            // 
            this.RcpIpTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RcpIpTextBox.Location = new System.Drawing.Point(236, 85);
            this.RcpIpTextBox.MaxLength = 15;
            this.RcpIpTextBox.Name = "RcpIpTextBox";
            this.RcpIpTextBox.PlaceholderText = "IP";
            this.RcpIpTextBox.Size = new System.Drawing.Size(248, 55);
            this.RcpIpTextBox.TabIndex = 0;
            this.RcpIpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RcpIpTextBox.TextChanged += new System.EventHandler(this.RcpIpTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "RCP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slot";
            // 
            // SlotNo
            // 
            this.SlotNo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SlotNo.Location = new System.Drawing.Point(236, 162);
            this.SlotNo.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SlotNo.Name = "SlotNo";
            this.SlotNo.Size = new System.Drawing.Size(62, 55);
            this.SlotNo.TabIndex = 4;
            // 
            // LogCreatorbutton
            // 
            this.LogCreatorbutton.Enabled = false;
            this.LogCreatorbutton.Location = new System.Drawing.Point(618, 97);
            this.LogCreatorbutton.Name = "LogCreatorbutton";
            this.LogCreatorbutton.Size = new System.Drawing.Size(127, 39);
            this.LogCreatorbutton.TabIndex = 5;
            this.LogCreatorbutton.Text = "Create Log File";
            this.LogCreatorbutton.UseVisualStyleBackColor = true;
            this.LogCreatorbutton.Click += new System.EventHandler(this.LogCreatorbutton_Click);
            // 
            // analyzerButton
            // 
            this.analyzerButton.Enabled = false;
            this.analyzerButton.Location = new System.Drawing.Point(618, 162);
            this.analyzerButton.Name = "analyzerButton";
            this.analyzerButton.Size = new System.Drawing.Size(127, 39);
            this.analyzerButton.TabIndex = 6;
            this.analyzerButton.Text = "Analyzer";
            this.analyzerButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 277);
            this.Controls.Add(this.analyzerButton);
            this.Controls.Add(this.LogCreatorbutton);
            this.Controls.Add(this.SlotNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RcpIpTextBox);
            this.Name = "Form1";
            this.Text = "Apollo Gold Stars";
            ((System.ComponentModel.ISupportInitialize)(this.SlotNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private TextBox RcpIpTextBox;
        private Label label1;
        private Label label2;
        private NumericUpDown SlotNo;
        private Button LogCreatorbutton;
        private Button analyzerButton;
    }
}