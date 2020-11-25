
namespace OsloOS.Home_And_Integrated_Apps
{
    partial class background
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
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.ForeColor = System.Drawing.Color.Transparent;
            this.button_WOC1.Location = new System.Drawing.Point(662, -73);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC1.Size = new System.Drawing.Size(617, 136);
            this.button_WOC1.TabIndex = 0;
            this.button_WOC1.TextColor = System.Drawing.Color.Transparent;
            this.button_WOC1.UseVisualStyleBackColor = false;
            // 
            // background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OsloOS.Properties.Resources.OsloOS_MainMenu_DarkMode1;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.button_WOC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "background";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "background";
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}