namespace ApolloGoldStars
{
    partial class PeformanceAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeformanceAnalyzer));
            this.label1 = new System.Windows.Forms.Label();
            this.PeriodicSec = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.PeriodicRunButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.HighObjButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ThresholdNum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.peractObjsRegButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodic activities\r\nexecution time:";
            // 
            // PeriodicSec
            // 
            this.PeriodicSec.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeriodicSec.Location = new System.Drawing.Point(333, 237);
            this.PeriodicSec.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.PeriodicSec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeriodicSec.Name = "PeriodicSec";
            this.PeriodicSec.Size = new System.Drawing.Size(110, 55);
            this.PeriodicSec.TabIndex = 13;
            this.PeriodicSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PeriodicSec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(449, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 45);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sec";
            // 
            // PeriodicRunButton
            // 
            this.PeriodicRunButton.BackgroundImage = global::ApolloGoldStars.Properties.Resources.Screenshot_2022_02_10_124704;
            this.PeriodicRunButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PeriodicRunButton.Location = new System.Drawing.Point(333, 298);
            this.PeriodicRunButton.Name = "PeriodicRunButton";
            this.PeriodicRunButton.Size = new System.Drawing.Size(320, 62);
            this.PeriodicRunButton.TabIndex = 16;
            this.PeriodicRunButton.Text = "Run";
            this.PeriodicRunButton.UseVisualStyleBackColor = true;
            this.PeriodicRunButton.Click += new System.EventHandler(this.PeriodicRunButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 17;
            // 
            // HighObjButton
            // 
            this.HighObjButton.BackgroundImage = global::ApolloGoldStars.Properties.Resources.Screenshot_2022_02_10_124704;
            this.HighObjButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HighObjButton.Location = new System.Drawing.Point(331, 468);
            this.HighObjButton.Name = "HighObjButton";
            this.HighObjButton.Size = new System.Drawing.Size(320, 62);
            this.HighObjButton.TabIndex = 18;
            this.HighObjButton.Text = "Run";
            this.HighObjButton.UseVisualStyleBackColor = true;
            this.HighObjButton.Click += new System.EventHandler(this.HighObjButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 90);
            this.label4.TabIndex = 19;
            this.label4.Text = "High objects\r\nconsumption:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(449, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 45);
            this.label5.TabIndex = 21;
            this.label5.Text = "μs Threshold";
            // 
            // ThresholdNum
            // 
            this.ThresholdNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThresholdNum.Location = new System.Drawing.Point(333, 408);
            this.ThresholdNum.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.ThresholdNum.Name = "ThresholdNum";
            this.ThresholdNum.Size = new System.Drawing.Size(110, 55);
            this.ThresholdNum.TabIndex = 20;
            this.ThresholdNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThresholdNum.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(28, 607);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 90);
            this.label7.TabIndex = 23;
            this.label7.Text = "Show objects\r\nperact registration";
            // 
            // peractObjsRegButton
            // 
            this.peractObjsRegButton.BackgroundImage = global::ApolloGoldStars.Properties.Resources.Screenshot_2022_02_10_124704;
            this.peractObjsRegButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.peractObjsRegButton.Location = new System.Drawing.Point(331, 635);
            this.peractObjsRegButton.Name = "peractObjsRegButton";
            this.peractObjsRegButton.Size = new System.Drawing.Size(320, 62);
            this.peractObjsRegButton.TabIndex = 22;
            this.peractObjsRegButton.Text = "Run";
            this.peractObjsRegButton.UseVisualStyleBackColor = true;
            this.peractObjsRegButton.Click += new System.EventHandler(this.peractObjsRegButton_Click);
            // 
            // PeformanceAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApolloGoldStars.Properties.Resources.ribbon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 748);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.peractObjsRegButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ThresholdNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HighObjButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PeriodicRunButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PeriodicSec);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PeformanceAnalyzer";
            this.Text = "PeformanceAnalyzer";
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown PeriodicSec;
        private Label label2;
        private Button PeriodicRunButton;
        private Label label3;
        private Button HighObjButton;
        private Label label4;
        private Label label5;
        private NumericUpDown ThresholdNum;
        private Label label7;
        private Button peractObjsRegButton;
    }
}