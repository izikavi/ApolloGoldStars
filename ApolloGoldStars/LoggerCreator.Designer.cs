namespace ApolloGoldStars
{
    partial class LoggerCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowErrors = new System.Windows.Forms.CheckBox();
            this.ShowAlarm = new System.Windows.Forms.CheckBox();
            this.ShowAlarmonport = new System.Windows.Forms.CheckBox();
            this.ShowConfiguration = new System.Windows.Forms.CheckBox();
            this.clearHisAll = new System.Windows.Forms.CheckBox();
            this.portCheckBox = new System.Windows.Forms.TextBox();
            this.ShowPerfomanceMonitorting = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.ShowBIT = new System.Windows.Forms.CheckBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.saveToFilecheckBox = new System.Windows.Forms.CheckBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.portClearhis = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ShowErrors
            // 
            this.ShowErrors.AutoSize = true;
            this.ShowErrors.Location = new System.Drawing.Point(48, 31);
            this.ShowErrors.Name = "ShowErrors";
            this.ShowErrors.Size = new System.Drawing.Size(108, 19);
            this.ShowErrors.TabIndex = 0;
            this.ShowErrors.Text = "Show SW Errors\t";
            this.ShowErrors.UseVisualStyleBackColor = true;
            // 
            // ShowAlarm
            // 
            this.ShowAlarm.AutoSize = true;
            this.ShowAlarm.Location = new System.Drawing.Point(48, 56);
            this.ShowAlarm.Name = "ShowAlarm";
            this.ShowAlarm.Size = new System.Drawing.Size(90, 19);
            this.ShowAlarm.TabIndex = 1;
            this.ShowAlarm.Text = "Show Alarm";
            this.ShowAlarm.UseVisualStyleBackColor = true;
            // 
            // ShowAlarmonport
            // 
            this.ShowAlarmonport.AutoSize = true;
            this.ShowAlarmonport.Location = new System.Drawing.Point(48, 81);
            this.ShowAlarmonport.Name = "ShowAlarmonport";
            this.ShowAlarmonport.Size = new System.Drawing.Size(132, 19);
            this.ShowAlarmonport.TabIndex = 2;
            this.ShowAlarmonport.Text = "Show Alarm on port";
            this.ShowAlarmonport.UseVisualStyleBackColor = true;
            // 
            // ShowConfiguration
            // 
            this.ShowConfiguration.AutoSize = true;
            this.ShowConfiguration.Location = new System.Drawing.Point(48, 106);
            this.ShowConfiguration.Name = "ShowConfiguration";
            this.ShowConfiguration.Size = new System.Drawing.Size(135, 19);
            this.ShowConfiguration.TabIndex = 3;
            this.ShowConfiguration.Text = "Show Configuration \t";
            this.ShowConfiguration.UseVisualStyleBackColor = true;
            // 
            // clearHisAll
            // 
            this.clearHisAll.AutoSize = true;
            this.clearHisAll.Location = new System.Drawing.Point(139, 56);
            this.clearHisAll.Name = "clearHisAll";
            this.clearHisAll.Size = new System.Drawing.Size(138, 19);
            this.clearHisAll.TabIndex = 4;
            this.clearHisAll.Text = "clearhis before almall";
            this.clearHisAll.UseVisualStyleBackColor = true;
            // 
            // portCheckBox
            // 
            this.portCheckBox.Location = new System.Drawing.Point(182, 77);
            this.portCheckBox.Name = "portCheckBox";
            this.portCheckBox.Size = new System.Drawing.Size(100, 23);
            this.portCheckBox.TabIndex = 5;
            // 
            // ShowPerfomanceMonitorting
            // 
            this.ShowPerfomanceMonitorting.AutoSize = true;
            this.ShowPerfomanceMonitorting.Location = new System.Drawing.Point(48, 131);
            this.ShowPerfomanceMonitorting.Name = "ShowPerfomanceMonitorting";
            this.ShowPerfomanceMonitorting.Size = new System.Drawing.Size(189, 19);
            this.ShowPerfomanceMonitorting.TabIndex = 6;
            this.ShowPerfomanceMonitorting.Text = "Show Perfomance Monitorting\t";
            this.ShowPerfomanceMonitorting.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(48, 156);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(101, 19);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Show Statuses\t";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // ShowBIT
            // 
            this.ShowBIT.AutoSize = true;
            this.ShowBIT.Location = new System.Drawing.Point(48, 181);
            this.ShowBIT.Name = "ShowBIT";
            this.ShowBIT.Size = new System.Drawing.Size(77, 19);
            this.ShowBIT.TabIndex = 8;
            this.ShowBIT.Text = "Show BIT \t";
            this.ShowBIT.UseVisualStyleBackColor = true;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(598, 28);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 15);
            this.FileNameLabel.TabIndex = 9;
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(599, 60);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(0, 15);
            this.FilePathLabel.TabIndex = 10;
            this.FilePathLabel.TextChanged += new System.EventHandler(this.FileNameLabel_Change);
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(585, 92);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(96, 23);
            this.openFileDialogButton.TabIndex = 11;
            this.openFileDialogButton.Text = "Select Log File";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "File Path";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(397, 296);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 19);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Show to screen";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // saveToFilecheckBox
            // 
            this.saveToFilecheckBox.AutoSize = true;
            this.saveToFilecheckBox.Location = new System.Drawing.Point(289, 296);
            this.saveToFilecheckBox.Name = "saveToFilecheckBox";
            this.saveToFilecheckBox.Size = new System.Drawing.Size(83, 19);
            this.saveToFilecheckBox.TabIndex = 16;
            this.saveToFilecheckBox.Text = "Save to file";
            this.saveToFilecheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(639, 292);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 17;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(48, 206);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(153, 19);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "User Debug commands:";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 204);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 61);
            this.textBox1.TabIndex = 19;
            // 
            // portClearhis
            // 
            this.portClearhis.AutoSize = true;
            this.portClearhis.Location = new System.Drawing.Point(304, 81);
            this.portClearhis.Name = "portClearhis";
            this.portClearhis.Size = new System.Drawing.Size(138, 19);
            this.portClearhis.TabIndex = 20;
            this.portClearhis.Text = "clearhis before almall";
            this.portClearhis.UseVisualStyleBackColor = true;
            // 
            // LoggerCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.portClearhis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.saveToFilecheckBox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openFileDialogButton);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.ShowBIT);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.ShowPerfomanceMonitorting);
            this.Controls.Add(this.portCheckBox);
            this.Controls.Add(this.clearHisAll);
            this.Controls.Add(this.ShowConfiguration);
            this.Controls.Add(this.ShowAlarmonport);
            this.Controls.Add(this.ShowAlarm);
            this.Controls.Add(this.ShowErrors);
            this.Name = "LoggerCreator";
            this.Text = "LoggerCreator";
            this.Load += new System.EventHandler(this.LoggerCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox ShowErrors;
        private CheckBox ShowAlarm;
        private CheckBox ShowAlarmonport;
        private CheckBox ShowConfiguration;
        private CheckBox clearHisAll;
        private TextBox portCheckBox;
        private CheckBox ShowPerfomanceMonitorting;
        private CheckBox checkBox6;
        private CheckBox ShowBIT;
        private Label FileNameLabel;
        private Label FilePathLabel;
        private Button openFileDialogButton;
        private Label label1;
        private Label label2;
        private CheckBox checkBox2;
        private CheckBox saveToFilecheckBox;
        private Button GenerateButton;
        private CheckBox checkBox4;
        private TextBox textBox1;
        private CheckBox portClearhis;
    }
}