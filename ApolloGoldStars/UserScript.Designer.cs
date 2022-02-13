namespace ApolloGoldStars
{
    partial class UserScript
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserScript));
            this.PeriodicRunButton = new System.Windows.Forms.Button();
            this.UserBoxTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeriodicRunButton
            // 
            this.PeriodicRunButton.BackgroundImage = global::ApolloGoldStars.Properties.Resources.Screenshot_2022_02_10_124704;
            this.PeriodicRunButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PeriodicRunButton.Location = new System.Drawing.Point(426, 648);
            this.PeriodicRunButton.Name = "PeriodicRunButton";
            this.PeriodicRunButton.Size = new System.Drawing.Size(320, 62);
            this.PeriodicRunButton.TabIndex = 17;
            this.PeriodicRunButton.Text = "Run";
            this.PeriodicRunButton.UseVisualStyleBackColor = true;
            // 
            // UserBoxTextBox
            // 
            this.UserBoxTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.UserBoxTextBox.Location = new System.Drawing.Point(37, 215);
            this.UserBoxTextBox.Multiline = true;
            this.UserBoxTextBox.Name = "UserBoxTextBox";
            this.UserBoxTextBox.Size = new System.Drawing.Size(709, 414);
            this.UserBoxTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ApolloGoldStars.Properties.Resources.Screenshot_2022_02_10_124704;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(37, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 62);
            this.button1.TabIndex = 21;
            this.button1.Text = "Load .txt file";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApolloGoldStars.Properties.Resources.ribbon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 744);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserBoxTextBox);
            this.Controls.Add(this.PeriodicRunButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserScript";
            this.ShowInTaskbar = false;
            this.Text = "UserScript";
            this.Load += new System.EventHandler(this.UserScript_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PeriodicRunButton;
        private TextBox UserBoxTextBox;
        private ToolTip toolTip1;
        private Button button1;
    }
}