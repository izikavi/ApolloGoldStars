namespace ApolloGoldStars
{
    partial class PeractObjs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeractObjs));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foreground = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Background = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OneSecond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.ClassID,
            this.InstanceID,
            this.Foreground,
            this.Background,
            this.OneSecond,
            this.action});
            this.dataGridView1.Location = new System.Drawing.Point(8, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(802, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 150;
            // 
            // ClassID
            // 
            this.ClassID.HeaderText = "Class ID";
            this.ClassID.MinimumWidth = 8;
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            this.ClassID.Width = 150;
            // 
            // InstanceID
            // 
            this.InstanceID.HeaderText = "Instance ID";
            this.InstanceID.MinimumWidth = 8;
            this.InstanceID.Name = "InstanceID";
            this.InstanceID.ReadOnly = true;
            this.InstanceID.Width = 150;
            // 
            // Foreground
            // 
            this.Foreground.HeaderText = "Foreground";
            this.Foreground.MinimumWidth = 8;
            this.Foreground.Name = "Foreground";
            this.Foreground.ReadOnly = true;
            this.Foreground.Width = 150;
            // 
            // Background
            // 
            this.Background.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Background.HeaderText = "Background Ticks";
            this.Background.MinimumWidth = 8;
            this.Background.Name = "Background";
            this.Background.ReadOnly = true;
            this.Background.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Background.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Background.Width = 180;
            // 
            // OneSecond
            // 
            this.OneSecond.HeaderText = "One Second Tick";
            this.OneSecond.MinimumWidth = 8;
            this.OneSecond.Name = "OneSecond";
            this.OneSecond.ReadOnly = true;
            this.OneSecond.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OneSecond.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OneSecond.Width = 150;
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.MinimumWidth = 8;
            this.action.Name = "action";
            this.action.Width = 150;
            // 
            // PeractObjs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::ApolloGoldStars.Properties.Resources.ribbon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 425);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Text = "PeractObjs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ClassID;
        private DataGridViewTextBoxColumn InstanceID;
        private DataGridViewCheckBoxColumn Foreground;
        private DataGridViewTextBoxColumn Background;
        private DataGridViewTextBoxColumn OneSecond;
        private DataGridViewButtonColumn action;
    }
}