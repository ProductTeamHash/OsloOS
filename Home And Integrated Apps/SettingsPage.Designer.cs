
namespace OsloOS.Home_And_Integrated_Apps
{
    partial class SettingsPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.GeneralSettings = new System.Windows.Forms.Button();
            this.WallpaperSettings = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.UpdatePage = new System.Windows.Forms.Button();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.WallpaperPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.UpdatePage);
            this.panel1.Controls.Add(this.About);
            this.panel1.Controls.Add(this.WallpaperSettings);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.GeneralSettings);
            this.panel1.Location = new System.Drawing.Point(-5, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 1090);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Corbel Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(3, 960);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(317, 126);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // GeneralSettings
            // 
            this.GeneralSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.GeneralSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.GeneralSettings.FlatAppearance.BorderSize = 0;
            this.GeneralSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneralSettings.Font = new System.Drawing.Font("Corbel Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GeneralSettings.Location = new System.Drawing.Point(3, 3);
            this.GeneralSettings.Name = "GeneralSettings";
            this.GeneralSettings.Size = new System.Drawing.Size(317, 126);
            this.GeneralSettings.TabIndex = 1;
            this.GeneralSettings.Text = "General";
            this.GeneralSettings.UseVisualStyleBackColor = false;
            this.GeneralSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // WallpaperSettings
            // 
            this.WallpaperSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.WallpaperSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.WallpaperSettings.FlatAppearance.BorderSize = 0;
            this.WallpaperSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WallpaperSettings.Font = new System.Drawing.Font("Corbel Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WallpaperSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.WallpaperSettings.Location = new System.Drawing.Point(3, 135);
            this.WallpaperSettings.Name = "WallpaperSettings";
            this.WallpaperSettings.Size = new System.Drawing.Size(317, 126);
            this.WallpaperSettings.TabIndex = 4;
            this.WallpaperSettings.Text = "Wallpaper";
            this.WallpaperSettings.UseVisualStyleBackColor = false;
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.About.Cursor = System.Windows.Forms.Cursors.Default;
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Corbel Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.About.Location = new System.Drawing.Point(3, 399);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(317, 126);
            this.About.TabIndex = 5;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.button4_Click);
            // 
            // UpdatePage
            // 
            this.UpdatePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(4)))), ((int)(((byte)(68)))));
            this.UpdatePage.Cursor = System.Windows.Forms.Cursors.Default;
            this.UpdatePage.FlatAppearance.BorderSize = 0;
            this.UpdatePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePage.Font = new System.Drawing.Font("Corbel Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpdatePage.Location = new System.Drawing.Point(3, 267);
            this.UpdatePage.Name = "UpdatePage";
            this.UpdatePage.Size = new System.Drawing.Size(317, 126);
            this.UpdatePage.TabIndex = 6;
            this.UpdatePage.Text = "Update";
            this.UpdatePage.UseVisualStyleBackColor = false;
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.BackColor = System.Drawing.Color.Transparent;
            this.GeneralPanel.Controls.Add(this.button_WOC1);
            this.GeneralPanel.Controls.Add(this.label1);
            this.GeneralPanel.Controls.Add(this.WallpaperPanel);
            this.GeneralPanel.Location = new System.Drawing.Point(304, 0);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(1626, 1084);
            this.GeneralPanel.TabIndex = 2;
            // 
            // WallpaperPanel
            // 
            this.WallpaperPanel.BackColor = System.Drawing.Color.LightGray;
            this.WallpaperPanel.Location = new System.Drawing.Point(3, 0);
            this.WallpaperPanel.Name = "WallpaperPanel";
            this.WallpaperPanel.Size = new System.Drawing.Size(0, 0);
            this.WallpaperPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel Light", 48F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mix Mode:";
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Crimson;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Corbel Light", 30F);
            this.button_WOC1.Location = new System.Drawing.Point(357, 61);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Crimson;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(182, 74);
            this.button_WOC1.TabIndex = 2;
            this.button_WOC1.Text = "Off";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::OsloOS.Properties.Resources.gradiant_for_olsoos;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GeneralPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsPage";
            this.panel1.ResumeLayout(false);
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button GeneralSettings;
        private System.Windows.Forms.Button WallpaperSettings;
        private System.Windows.Forms.Button UpdatePage;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Panel WallpaperPanel;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.Label label1;
    }
}