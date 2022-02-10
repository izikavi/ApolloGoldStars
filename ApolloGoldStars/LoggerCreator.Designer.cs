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
            this.ShowErrors.BackColor = System.Drawing.Color.Transparent;
            this.ShowErrors.Location = new System.Drawing.Point(37, 157);
            this.ShowErrors.Name = "ShowErrors";
            this.ShowErrors.Size = new System.Drawing.Size(165, 29);
            this.ShowErrors.TabIndex = 0;
            this.ShowErrors.Text = "Show SW Errors\t";
            this.ShowErrors.UseVisualStyleBackColor = false;
            // 
            // ShowAlarm
            // 
            this.ShowAlarm.AutoSize = true;
            this.ShowAlarm.BackColor = System.Drawing.Color.Transparent;
            this.ShowAlarm.Location = new System.Drawing.Point(37, 204);
            this.ShowAlarm.Name = "ShowAlarm";
            this.ShowAlarm.Size = new System.Drawing.Size(229, 29);
            this.ShowAlarm.TabIndex = 1;
            this.ShowAlarm.Text = "Show Alarm on all ports";
            this.ShowAlarm.UseVisualStyleBackColor = false;
            this.ShowAlarm.CheckedChanged += new System.EventHandler(this.ShowAlarm_CheckedChanged);
            // 
            // ShowAlarmonport
            // 
            this.ShowAlarmonport.AutoSize = true;
            this.ShowAlarmonport.BackColor = System.Drawing.Color.Transparent;
            this.ShowAlarmonport.Location = new System.Drawing.Point(37, 255);
            this.ShowAlarmonport.Name = "ShowAlarmonport";
            this.ShowAlarmonport.Size = new System.Drawing.Size(203, 29);
            this.ShowAlarmonport.TabIndex = 2;
            this.ShowAlarmonport.Text = "Show Alarm on port:";
            this.ShowAlarmonport.UseVisualStyleBackColor = false;
            this.ShowAlarmonport.CheckedChanged += new System.EventHandler(this.ShowAlarmonport_CheckedChanged);
            // 
            // clearHisAll
            // 
            this.clearHisAll.AutoSize = true;
            this.clearHisAll.BackColor = System.Drawing.Color.Transparent;
            this.clearHisAll.Location = new System.Drawing.Point(424, 188);
            this.clearHisAll.Name = "clearHisAll";
            this.clearHisAll.Size = new System.Drawing.Size(176, 54);
            this.clearHisAll.TabIndex = 4;
            this.clearHisAll.Text = "Clear history\r\nbefore command";
            this.clearHisAll.UseVisualStyleBackColor = false;
            // 
            // portCheckBox
            // 
            this.portCheckBox.Location = new System.Drawing.Point(272, 255);
            this.portCheckBox.Name = "portCheckBox";
            this.portCheckBox.Size = new System.Drawing.Size(100, 31);
            this.portCheckBox.TabIndex = 5;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FileNameLabel.Location = new System.Drawing.Point(769, 202);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 25);
            this.FileNameLabel.TabIndex = 9;
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.BackColor = System.Drawing.Color.Transparent;
            this.FilePathLabel.Location = new System.Drawing.Point(770, 234);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(0, 25);
            this.FilePathLabel.TabIndex = 10;
            this.FilePathLabel.TextChanged += new System.EventHandler(this.FileNameLabel_Change);
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.BackgroundImage = global::ApolloGoldStars.Properties.Resources.Screenshot_2022_02_10_124704;
            this.openFileDialogButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.openFileDialogButton.Location = new System.Drawing.Point(679, 274);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(211, 63);
            this.openFileDialogButton.TabIndex = 11;
            this.openFileDialogButton.Text = "Select Log File";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(679, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(679, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "File Path:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Location = new System.Drawing.Point(433, 439);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(159, 29);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Show to screen";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // saveToFilecheckBox
            // 
            this.saveToFilecheckBox.AutoSize = true;
            this.saveToFilecheckBox.BackColor = System.Drawing.Color.Transparent;
            this.saveToFilecheckBox.Location = new System.Drawing.Point(272, 439);
            this.saveToFilecheckBox.Name = "saveToFilecheckBox";
            this.saveToFilecheckBox.Size = new System.Drawing.Size(125, 29);
            this.saveToFilecheckBox.TabIndex = 16;
            this.saveToFilecheckBox.Text = "Save to file";
            this.saveToFilecheckBox.UseVisualStyleBackColor = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackgroundImage = global::ApolloGoldStars.Properties.Resources.Screenshot_2022_02_10_124704;
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.GenerateButton.Location = new System.Drawing.Point(679, 421);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(192, 71);
            this.GenerateButton.TabIndex = 17;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Location = new System.Drawing.Point(36, 306);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(230, 29);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "User Debug commands:";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 306);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 90);
            this.textBox1.TabIndex = 19;
            // 
            // portClearhis
            // 
            this.portClearhis.AutoSize = true;
            this.portClearhis.BackColor = System.Drawing.Color.Transparent;
            this.portClearhis.Location = new System.Drawing.Point(424, 242);
            this.portClearhis.Name = "portClearhis";
            this.portClearhis.Size = new System.Drawing.Size(176, 54);
            this.portClearhis.TabIndex = 20;
            this.portClearhis.Text = "Clear history\r\nbefore command";
            this.portClearhis.UseVisualStyleBackColor = false;
            // 
            // LoggerCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImage = global::ApolloGoldStars.Properties.Resources.ribbon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 504);
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
            this.Controls.Add(this.portCheckBox);
            this.Controls.Add(this.clearHisAll);
            this.Controls.Add(this.ShowAlarmonport);
            this.Controls.Add(this.ShowAlarm);
            this.Controls.Add(this.ShowErrors);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private TextBox textBox1;
    }
}