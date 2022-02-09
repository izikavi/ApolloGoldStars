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
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicSec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodic activities\r\nexecution time:";
            // 
            // PeriodicSec
            // 
            this.PeriodicSec.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeriodicSec.Location = new System.Drawing.Point(233, 142);
            this.PeriodicSec.Margin = new System.Windows.Forms.Padding(2);
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
            this.PeriodicSec.Size = new System.Drawing.Size(77, 39);
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
            this.label2.Location = new System.Drawing.Point(314, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sec";
            // 
            // PeriodicRunButton
            // 
            this.PeriodicRunButton.Location = new System.Drawing.Point(713, 152);
            this.PeriodicRunButton.Margin = new System.Windows.Forms.Padding(2);
            this.PeriodicRunButton.Name = "PeriodicRunButton";
            this.PeriodicRunButton.Size = new System.Drawing.Size(78, 20);
            this.PeriodicRunButton.TabIndex = 16;
            this.PeriodicRunButton.Text = "Run";
            this.PeriodicRunButton.UseVisualStyleBackColor = true;
            this.PeriodicRunButton.Click += new System.EventHandler(this.PeriodicRunButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 17;
            // 
            // PeformanceAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApolloGoldStars.Properties.Resources.ribbon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PeriodicRunButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PeriodicSec);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeformanceAnalyzer";
            this.Text = "PeformanceAnalyzer";
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown PeriodicSec;
        private Label label2;
        private Button PeriodicRunButton;
        private Label label3;
    }
}