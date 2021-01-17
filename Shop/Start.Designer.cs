namespace Shop
{
    partial class Start
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
            this.Logo_Startform_label = new System.Windows.Forms.Label();
            this.Version_Startform_label = new System.Windows.Forms.Label();
            this.Startform_picturebox = new System.Windows.Forms.PictureBox();
            this.progressbar_startform_timer = new System.Windows.Forms.Timer(this.components);
            this.Startform_Progressbar = new XanderUI.XUIFlatProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Startform_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo_Startform_label
            // 
            this.Logo_Startform_label.AutoSize = true;
            this.Logo_Startform_label.BackColor = System.Drawing.Color.SlateBlue;
            this.Logo_Startform_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo_Startform_label.ForeColor = System.Drawing.Color.GhostWhite;
            this.Logo_Startform_label.Location = new System.Drawing.Point(221, 9);
            this.Logo_Startform_label.Name = "Logo_Startform_label";
            this.Logo_Startform_label.Size = new System.Drawing.Size(158, 33);
            this.Logo_Startform_label.TabIndex = 10;
            this.Logo_Startform_label.Text = "TOKRI.PK";
            // 
            // Version_Startform_label
            // 
            this.Version_Startform_label.AutoSize = true;
            this.Version_Startform_label.BackColor = System.Drawing.Color.SlateBlue;
            this.Version_Startform_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version_Startform_label.ForeColor = System.Drawing.Color.GhostWhite;
            this.Version_Startform_label.Location = new System.Drawing.Point(244, 51);
            this.Version_Startform_label.Name = "Version_Startform_label";
            this.Version_Startform_label.Size = new System.Drawing.Size(100, 20);
            this.Version_Startform_label.TabIndex = 11;
            this.Version_Startform_label.Text = "Version 1.0";
            // 
            // Startform_picturebox
            // 
            this.Startform_picturebox.Image = global::Shop.Properties.Resources.iconfinder_Cart_383986;
            this.Startform_picturebox.Location = new System.Drawing.Point(150, 100);
            this.Startform_picturebox.Name = "Startform_picturebox";
            this.Startform_picturebox.Size = new System.Drawing.Size(300, 200);
            this.Startform_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Startform_picturebox.TabIndex = 13;
            this.Startform_picturebox.TabStop = false;
            // 
            // progressbar_startform_timer
            // 
            this.progressbar_startform_timer.Tick += new System.EventHandler(this.progressbar_startform_timer_Tick);
            // 
            // Startform_Progressbar
            // 
            this.Startform_Progressbar.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.Startform_Progressbar.BorderColor = System.Drawing.Color.Black;
            this.Startform_Progressbar.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.Startform_Progressbar.InocmpletedColor = System.Drawing.Color.White;
            this.Startform_Progressbar.Location = new System.Drawing.Point(0, 385);
            this.Startform_Progressbar.MaxValue = 100;
            this.Startform_Progressbar.Name = "Startform_Progressbar";
            this.Startform_Progressbar.ShowBorder = true;
            this.Startform_Progressbar.Size = new System.Drawing.Size(600, 15);
            this.Startform_Progressbar.TabIndex = 14;
            this.Startform_Progressbar.Text = "xuiFlatProgressBar1";
            this.Startform_Progressbar.Value = 50;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.Startform_Progressbar);
            this.Controls.Add(this.Startform_picturebox);
            this.Controls.Add(this.Version_Startform_label);
            this.Controls.Add(this.Logo_Startform_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Startform_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Logo_Startform_label;
        private System.Windows.Forms.Label Version_Startform_label;
        private System.Windows.Forms.PictureBox Startform_picturebox;
        private System.Windows.Forms.Timer progressbar_startform_timer;
        private XanderUI.XUIFlatProgressBar Startform_Progressbar;
    }
}