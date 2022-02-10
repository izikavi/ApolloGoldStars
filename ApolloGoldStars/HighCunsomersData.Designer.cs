namespace ApolloGoldStars
{
    partial class HighCunsomersData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighCunsomersData));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExceptionsPerSec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.PerformanceProgressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.instance,
            this.period,
            this.max,
            this.avg,
            this.ExceptionsPerSec});
            this.dataGridView1.Location = new System.Drawing.Point(16, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1376, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Class name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // instance
            // 
            this.instance.HeaderText = "Instance ID";
            this.instance.MinimumWidth = 8;
            this.instance.Name = "instance";
            this.instance.Width = 150;
            // 
            // period
            // 
            this.period.HeaderText = "Period";
            this.period.MinimumWidth = 8;
            this.period.Name = "period";
            this.period.ReadOnly = true;
            this.period.Width = 150;
            // 
            // max
            // 
            this.max.HeaderText = "Max time";
            this.max.MinimumWidth = 8;
            this.max.Name = "max";
            this.max.ReadOnly = true;
            this.max.Width = 150;
            // 
            // avg
            // 
            this.avg.HeaderText = "Avg time";
            this.avg.MinimumWidth = 8;
            this.avg.Name = "avg";
            this.avg.ReadOnly = true;
            this.avg.Width = 150;
            // 
            // ExceptionsPerSec
            // 
            this.ExceptionsPerSec.HeaderText = "Exceptions per 1sec";
            this.ExceptionsPerSec.MinimumWidth = 8;
            this.ExceptionsPerSec.Name = "ExceptionsPerSec";
            this.ExceptionsPerSec.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(650, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = " ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PerformanceProgressBar
            // 
            this.PerformanceProgressBar.Location = new System.Drawing.Point(16, 207);
            this.PerformanceProgressBar.Name = "PerformanceProgressBar";
            this.PerformanceProgressBar.Size = new System.Drawing.Size(1376, 71);
            this.PerformanceProgressBar.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // HighCunsomersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApolloGoldStars.Properties.Resources.ribbon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 815);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PerformanceProgressBar);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HighCunsomersData";
            this.Text = "HighCunsomersData";
            this.Load += new System.EventHandler(this.HighCunsomersData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn instance;
        private DataGridViewTextBoxColumn period;
        private DataGridViewTextBoxColumn max;
        private DataGridViewTextBoxColumn avg;
        private DataGridViewTextBoxColumn ExceptionsPerSec;
        private Label label1;
        private ProgressBar PerformanceProgressBar;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}