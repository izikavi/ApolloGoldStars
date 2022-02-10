namespace ApolloGoldStars
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.LoggerCreator = new System.Windows.Forms.Button();
            this.PerformanceAnalyzer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Scriptbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoggerCreator
            // 
            this.LoggerCreator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LoggerCreator.BackgroundImage = global::ApolloGoldStars.Properties.Resources.Screenshot_2022_02_10_124704;
            this.LoggerCreator.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LoggerCreator.Location = new System.Drawing.Point(12, 189);
            this.LoggerCreator.Name = "LoggerCreator";
            this.LoggerCreator.Size = new System.Drawing.Size(219, 141);
            this.LoggerCreator.TabIndex = 0;
            this.LoggerCreator.Text = "Logger\r\nCreateor";
            this.LoggerCreator.UseVisualStyleBackColor = false;
            this.LoggerCreator.Click += new System.EventHandler(this.LoggerCreator_Click);
            // 
            // PerformanceAnalyzer
            // 
            this.PerformanceAnalyzer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PerformanceAnalyzer.BackgroundImage = global::ApolloGoldStars.Properties.Resources.Screenshot_2022_02_10_124704;
            this.PerformanceAnalyzer.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PerformanceAnalyzer.Location = new System.Drawing.Point(262, 189);
            this.PerformanceAnalyzer.Name = "PerformanceAnalyzer";
            this.PerformanceAnalyzer.Size = new System.Drawing.Size(229, 141);
            this.PerformanceAnalyzer.TabIndex = 1;
            this.PerformanceAnalyzer.Text = "Performance Analyzer";
            this.PerformanceAnalyzer.UseVisualStyleBackColor = false;
            this.PerformanceAnalyzer.Click += new System.EventHandler(this.PerformanceAnalyzer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImage = global::ApolloGoldStars.Properties.Resources.Screenshot_2022_02_10_124704;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(264, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 141);
            this.button1.TabIndex = 3;
            this.button1.Text = "Application Support";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Scriptbutton
            // 
            this.Scriptbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Scriptbutton.BackgroundImage = global::ApolloGoldStars.Properties.Resources.Screenshot_2022_02_10_124704;
            this.Scriptbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Scriptbutton.Location = new System.Drawing.Point(12, 375);
            this.Scriptbutton.Name = "Scriptbutton";
            this.Scriptbutton.Size = new System.Drawing.Size(219, 141);
            this.Scriptbutton.TabIndex = 2;
            this.Scriptbutton.Text = "Run User\r\nScript";
            this.Scriptbutton.UseVisualStyleBackColor = false;
            // 
            // LogForm
            // 
            this.BackgroundImage = global::ApolloGoldStars.Properties.Resources.ribbon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Scriptbutton);
            this.Controls.Add(this.PerformanceAnalyzer);
            this.Controls.Add(this.LoggerCreator);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button LoggerCreator;
        private Button PerformanceAnalyzer;
        private Button button1;
        private Button Scriptbutton;
    }
}