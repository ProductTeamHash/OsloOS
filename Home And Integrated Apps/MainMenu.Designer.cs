namespace OsloOS
{
    partial class MainMenu
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
            this.SwipeDownMenuButton2 = new System.Windows.Forms.Button();
            this.SwipeDownMenuButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SwipeDownMenuButton2
            // 
            this.SwipeDownMenuButton2.BackColor = System.Drawing.Color.Transparent;
            this.SwipeDownMenuButton2.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.SwipeDownMenuButton2.FlatAppearance.BorderSize = 0;
            this.SwipeDownMenuButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SwipeDownMenuButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SwipeDownMenuButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwipeDownMenuButton2.ForeColor = System.Drawing.Color.Transparent;
            this.SwipeDownMenuButton2.Location = new System.Drawing.Point(713, 27);
            this.SwipeDownMenuButton2.Name = "SwipeDownMenuButton2";
            this.SwipeDownMenuButton2.Size = new System.Drawing.Size(521, 35);
            this.SwipeDownMenuButton2.TabIndex = 1;
            this.SwipeDownMenuButton2.UseVisualStyleBackColor = false;
            this.SwipeDownMenuButton2.Click += new System.EventHandler(this.SwipeDownMenuButton2_Click);
            // 
            // SwipeDownMenuButton1
            // 
            this.SwipeDownMenuButton1.BackColor = System.Drawing.Color.Transparent;
            this.SwipeDownMenuButton1.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.SwipeDownMenuButton1.FlatAppearance.BorderSize = 0;
            this.SwipeDownMenuButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SwipeDownMenuButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SwipeDownMenuButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwipeDownMenuButton1.ForeColor = System.Drawing.Color.Transparent;
            this.SwipeDownMenuButton1.Location = new System.Drawing.Point(667, -1);
            this.SwipeDownMenuButton1.Name = "SwipeDownMenuButton1";
            this.SwipeDownMenuButton1.Size = new System.Drawing.Size(607, 28);
            this.SwipeDownMenuButton1.TabIndex = 0;
            this.SwipeDownMenuButton1.UseVisualStyleBackColor = false;
            this.SwipeDownMenuButton1.Click += new System.EventHandler(this.SwipeDownMenuButton1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OsloOS.Properties.Resources.OsloOS_MainMenu_DarkMode1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.SwipeDownMenuButton2);
            this.Controls.Add(this.SwipeDownMenuButton1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SwipeDownMenuButton2;
        private System.Windows.Forms.Button SwipeDownMenuButton1;
    }
}