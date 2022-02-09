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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoggerCreator
            // 
            this.LoggerCreator.Location = new System.Drawing.Point(34, 154);
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
            this.PerformanceAnalyzer.Location = new System.Drawing.Point(264, 154);
            this.PerformanceAnalyzer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PerformanceAnalyzer.Name = "PerformanceAnalyzer";
            this.PerformanceAnalyzer.Size = new System.Drawing.Size(200, 65);
            this.PerformanceAnalyzer.TabIndex = 1;
            this.PerformanceAnalyzer.Text = "Performance Analyzer";
            this.PerformanceAnalyzer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 248);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Script runner";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 247);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "Apollo slideshow";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::ApolloGoldStars.Properties.Resources.ribbon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 346);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private Button button1;
        private Button button2;
    }
}