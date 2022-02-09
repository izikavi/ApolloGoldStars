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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // LoggerCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApolloGoldStars.Properties.Resources.rbbn_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoggerCreator";
            this.Text = "LoggerCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox ShowErrors;
        private CheckBox ShowAlarm;
        private CheckBox ShowAlarmonport;
        private CheckBox ShowConfiguration;
        private CheckBox checkBox1;
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
        private CheckBox checkBox3;
        private Button button1;
        private CheckBox checkBox4;
        private TextBox textBox1;
    }
}