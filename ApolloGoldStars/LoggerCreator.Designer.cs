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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggerCreator));
            this.ShowErrors = new System.Windows.Forms.CheckBox();
            this.ShowAlarm = new System.Windows.Forms.CheckBox();
            this.ShowAlarmonport = new System.Windows.Forms.CheckBox();
            this.clearHisAll = new System.Windows.Forms.CheckBox();
            this.portCheckBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.saveToFilecheckBox = new System.Windows.Forms.CheckBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.UserBox = new System.Windows.Forms.CheckBox();
            this.UserBoxTextBox = new System.Windows.Forms.TextBox();
            this.portClearhis = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ShowErrors
            // 
            this.ShowErrors.AutoSize = true;
            this.ShowErrors.BackColor = System.Drawing.Color.Transparent;
            this.ShowErrors.Location = new System.Drawing.Point(26, 94);
            this.ShowErrors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowErrors.Name = "ShowErrors";
            this.ShowErrors.Size = new System.Drawing.Size(108, 19);
            this.ShowErrors.TabIndex = 0;
            this.ShowErrors.Text = "Show SW Errors\t";
            this.ShowErrors.UseVisualStyleBackColor = false;
            // 
            // ShowAlarm
            // 
            this.ShowAlarm.AutoSize = true;
            this.ShowAlarm.BackColor = System.Drawing.Color.Transparent;
            this.ShowAlarm.Location = new System.Drawing.Point(26, 122);
            this.ShowAlarm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowAlarm.Name = "ShowAlarm";
            this.ShowAlarm.Size = new System.Drawing.Size(152, 19);
            this.ShowAlarm.TabIndex = 1;
            this.ShowAlarm.Text = "Show Alarm on all ports";
            this.ShowAlarm.UseVisualStyleBackColor = false;
            this.ShowAlarm.CheckedChanged += new System.EventHandler(this.ShowAlarm_CheckedChanged);
            // 
            // ShowAlarmonport
            // 
            this.ShowAlarmonport.AutoSize = true;
            this.ShowAlarmonport.BackColor = System.Drawing.Color.Transparent;
            this.ShowAlarmonport.Location = new System.Drawing.Point(26, 153);
            this.ShowAlarmonport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowAlarmonport.Name = "ShowAlarmonport";
            this.ShowAlarmonport.Size = new System.Drawing.Size(135, 19);
            this.ShowAlarmonport.TabIndex = 2;
            this.ShowAlarmonport.Text = "Show Alarm on port:";
            this.ShowAlarmonport.UseVisualStyleBackColor = false;
            this.ShowAlarmonport.CheckedChanged += new System.EventHandler(this.ShowAlarmonport_CheckedChanged);
            // 
            // clearHisAll
            // 
            this.clearHisAll.AutoSize = true;
            this.clearHisAll.BackColor = System.Drawing.Color.Transparent;
            this.clearHisAll.Location = new System.Drawing.Point(297, 113);
            this.clearHisAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearHisAll.Name = "clearHisAll";
            this.clearHisAll.Size = new System.Drawing.Size(118, 34);
            this.clearHisAll.TabIndex = 4;
            this.clearHisAll.Text = "Clear history\r\nbefore command";
            this.clearHisAll.UseVisualStyleBackColor = false;
            // 
            // portCheckBox
            // 
            this.portCheckBox.Location = new System.Drawing.Point(190, 153);
            this.portCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.portCheckBox.Name = "portCheckBox";
            this.portCheckBox.Size = new System.Drawing.Size(71, 23);
            this.portCheckBox.TabIndex = 5;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FileNameLabel.Location = new System.Drawing.Point(538, 121);
            this.FileNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 15);
            this.FileNameLabel.TabIndex = 9;
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.BackColor = System.Drawing.Color.Transparent;
            this.FilePathLabel.Location = new System.Drawing.Point(539, 140);
            this.FilePathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(0, 15);
            this.FilePathLabel.TabIndex = 10;
            this.FilePathLabel.TextChanged += new System.EventHandler(this.FileNameLabel_Change);
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.BackgroundImage = global::ApolloGoldStars.Properties.Resources.Screenshot_2022_02_10_124704;
            this.openFileDialogButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.openFileDialogButton.Location = new System.Drawing.Point(475, 164);
            this.openFileDialogButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(148, 38);
            this.openFileDialogButton.TabIndex = 11;
            this.openFileDialogButton.Text = "Select Log File";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(475, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(475, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "File Path:";
            // 
            // ShowScreenCheckBox
            // 
            this.ShowScreenCheckBox.AutoSize = true;
            this.ShowScreenCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ShowScreenCheckBox.Location = new System.Drawing.Point(303, 263);
            this.ShowScreenCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowScreenCheckBox.Name = "ShowScreenCheckBox";
            this.ShowScreenCheckBox.Size = new System.Drawing.Size(106, 19);
            this.ShowScreenCheckBox.TabIndex = 15;
            this.ShowScreenCheckBox.Text = "Show to screen";
            this.ShowScreenCheckBox.UseVisualStyleBackColor = false;
            // 
            // saveToFilecheckBox
            // 
            this.saveToFilecheckBox.AutoSize = true;
            this.saveToFilecheckBox.BackColor = System.Drawing.Color.Transparent;
            this.saveToFilecheckBox.Location = new System.Drawing.Point(190, 263);
            this.saveToFilecheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveToFilecheckBox.Name = "saveToFilecheckBox";
            this.saveToFilecheckBox.Size = new System.Drawing.Size(83, 19);
            this.saveToFilecheckBox.TabIndex = 16;
            this.saveToFilecheckBox.Text = "Save to file";
            this.saveToFilecheckBox.UseVisualStyleBackColor = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackgroundImage = global::ApolloGoldStars.Properties.Resources.Screenshot_2022_02_10_124704;
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.GenerateButton.Location = new System.Drawing.Point(475, 253);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(134, 43);
            this.GenerateButton.TabIndex = 17;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // UserBox
            // 
            this.UserBox.AutoSize = true;
            this.UserBox.BackColor = System.Drawing.Color.Transparent;
            this.UserBox.Location = new System.Drawing.Point(25, 186);
            this.UserBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(153, 19);
            this.UserBox.TabIndex = 18;
            this.UserBox.Text = "User Debug commands:";
            this.UserBox.UseVisualStyleBackColor = false;
            // 
            // UserBoxTextBox
            // 
            this.UserBoxTextBox.Location = new System.Drawing.Point(190, 184);
            this.UserBoxTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserBoxTextBox.Multiline = true;
            this.UserBoxTextBox.Name = "UserBoxTextBox";
            this.UserBoxTextBox.Size = new System.Drawing.Size(225, 56);
            this.UserBoxTextBox.TabIndex = 19;
            // 
            // portClearhis
            // 
            this.portClearhis.AutoSize = true;
            this.portClearhis.BackColor = System.Drawing.Color.Transparent;
            this.portClearhis.Location = new System.Drawing.Point(297, 145);
            this.portClearhis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.portClearhis.Name = "portClearhis";
            this.portClearhis.Size = new System.Drawing.Size(118, 34);
            this.portClearhis.TabIndex = 20;
            this.portClearhis.Text = "Clear history\r\nbefore command";
            this.portClearhis.UseVisualStyleBackColor = false;
            // 
            // LoggerCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImage = global::ApolloGoldStars.Properties.Resources.ribbon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 302);
            this.Controls.Add(this.portClearhis);
            this.Controls.Add(this.UserBoxTextBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.saveToFilecheckBox);
            this.Controls.Add(this.ShowScreenCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openFileDialogButton);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.portCheckBox);
            this.Controls.Add(this.clearHisAll);
            this.Controls.Add(this.ShowAlarmonport);
            this.Controls.Add(this.ShowAlarm);
            this.Controls.Add(this.ShowErrors);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private CheckBox clearHisAll;
        private TextBox portCheckBox;
        private Label FileNameLabel;
        private Label FilePathLabel;
        private Button openFileDialogButton;
        private Label label1;
        private Label label2;
        private CheckBox ShowToScreenCheckBox;
        private CheckBox saveToFilecheckBox;
        private Button GenerateButton;
        private CheckBox UserCommandsCheckBox;
        private TextBox userCommandsTextBox;
        private CheckBox portClearhis;
        private CheckBox ShowScreenCheckBox;
        private CheckBox UserBox;
        private TextBox UserBoxTextBox;
    }
}