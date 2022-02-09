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
            this.SuspendLayout();
            // 
            // LoggerCreator
            // 
            this.LoggerCreator.Location = new System.Drawing.Point(60, 28);
            this.LoggerCreator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoggerCreator.Name = "LoggerCreator";
            this.LoggerCreator.Size = new System.Drawing.Size(196, 65);
            this.LoggerCreator.TabIndex = 0;
            this.LoggerCreator.Text = "Logger Createor";
            this.LoggerCreator.UseVisualStyleBackColor = true;
            this.LoggerCreator.Click += new System.EventHandler(this.LoggerCreator_Click);
            // 
            // PerformanceAnalyzer
            // 
            this.PerformanceAnalyzer.Location = new System.Drawing.Point(329, 28);
            this.PerformanceAnalyzer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PerformanceAnalyzer.Name = "PerformanceAnalyzer";
            this.PerformanceAnalyzer.Size = new System.Drawing.Size(200, 65);
            this.PerformanceAnalyzer.TabIndex = 1;
            this.PerformanceAnalyzer.Text = "Performance Analyzer";
            this.PerformanceAnalyzer.UseVisualStyleBackColor = true;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImage = global::ApolloGoldStars.Properties.Resources.rbbn_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(896, 487);
            this.Controls.Add(this.PerformanceAnalyzer);
            this.Controls.Add(this.LoggerCreator);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button LoggerCreator;
        private Button PerformanceAnalyzer;
    }
}