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
            this.PeriodicView = new System.Windows.Forms.DataGridView();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TickNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodicRunButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 217);
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
            // PeriodicView
            // 
            this.PeriodicView.AllowUserToAddRows = false;
            this.PeriodicView.AllowUserToDeleteRows = false;
            this.PeriodicView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeriodicView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataType,
            this.TickNum,
            this.time});
            this.PeriodicView.Location = new System.Drawing.Point(539, 206);
            this.PeriodicView.Name = "PeriodicView";
            this.PeriodicView.ReadOnly = true;
            this.PeriodicView.RowHeadersWidth = 62;
            this.PeriodicView.RowTemplate.Height = 33;
            this.PeriodicView.Size = new System.Drawing.Size(336, 153);
            this.PeriodicView.TabIndex = 15;
            // 
            // DataType
            // 
            this.DataType.HeaderText = "Type";
            this.DataType.MinimumWidth = 8;
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            this.DataType.Width = 50;
            // 
            // TickNum
            // 
            this.TickNum.HeaderText = "Tick #";
            this.TickNum.MinimumWidth = 8;
            this.TickNum.Name = "TickNum";
            this.TickNum.ReadOnly = true;
            this.TickNum.Width = 50;
            // 
            // time
            // 
            this.time.HeaderText = "Time (usec)";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 80;
            // 
            // PeriodicRunButton
            // 
            this.PeriodicRunButton.Location = new System.Drawing.Point(1019, 253);
            this.PeriodicRunButton.Name = "PeriodicRunButton";
            this.PeriodicRunButton.Size = new System.Drawing.Size(112, 34);
            this.PeriodicRunButton.TabIndex = 16;
            this.PeriodicRunButton.Text = "Run";
            this.PeriodicRunButton.UseVisualStyleBackColor = true;
            this.PeriodicRunButton.Click += new System.EventHandler(this.PeriodicRunButton_Click);
            // 
            // PeformanceAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApolloGoldStars.Properties.Resources.ribbon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.PeriodicRunButton);
            this.Controls.Add(this.PeriodicView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PeriodicSec);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PeformanceAnalyzer";
            this.Text = "PeformanceAnalyzer";
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown PeriodicSec;
        private Label label2;
        private DataGridView PeriodicView;
        private Button PeriodicRunButton;
        private DataGridViewTextBoxColumn DataType;
        private DataGridViewTextBoxColumn TickNum;
        private DataGridViewTextBoxColumn time;
    }
}