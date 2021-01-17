
namespace Shop
{
    partial class Sample
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
            this.Left_Sample_panel = new System.Windows.Forms.Panel();
            this.Left_Top_Sample_Panel = new System.Windows.Forms.Panel();
            this.Sample_Home_Picturebox = new System.Windows.Forms.PictureBox();
            this.Right_Sample_Panel = new System.Windows.Forms.Panel();
            this.Sample_Right_Top_Panel = new System.Windows.Forms.Panel();
            this.UserName_Label = new System.Windows.Forms.Label();
            this.Left_Sample_panel.SuspendLayout();
            this.Left_Top_Sample_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sample_Home_Picturebox)).BeginInit();
            this.Right_Sample_Panel.SuspendLayout();
            this.Sample_Right_Top_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Left_Sample_panel
            // 
            this.Left_Sample_panel.Controls.Add(this.Left_Top_Sample_Panel);
            this.Left_Sample_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Sample_panel.Location = new System.Drawing.Point(0, 0);
            this.Left_Sample_panel.Name = "Left_Sample_panel";
            this.Left_Sample_panel.Size = new System.Drawing.Size(250, 700);
            this.Left_Sample_panel.TabIndex = 0;
            // 
            // Left_Top_Sample_Panel
            // 
            this.Left_Top_Sample_Panel.Controls.Add(this.Sample_Home_Picturebox);
            this.Left_Top_Sample_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Left_Top_Sample_Panel.Location = new System.Drawing.Point(0, 0);
            this.Left_Top_Sample_Panel.Name = "Left_Top_Sample_Panel";
            this.Left_Top_Sample_Panel.Size = new System.Drawing.Size(250, 100);
            this.Left_Top_Sample_Panel.TabIndex = 0;
            // 
            // Sample_Home_Picturebox
            // 
            this.Sample_Home_Picturebox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sample_Home_Picturebox.Image = global::Shop.Properties.Resources.Home;
            this.Sample_Home_Picturebox.Location = new System.Drawing.Point(0, 0);
            this.Sample_Home_Picturebox.Name = "Sample_Home_Picturebox";
            this.Sample_Home_Picturebox.Size = new System.Drawing.Size(250, 100);
            this.Sample_Home_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sample_Home_Picturebox.TabIndex = 1;
            this.Sample_Home_Picturebox.TabStop = false;
            // 
            // Right_Sample_Panel
            // 
            this.Right_Sample_Panel.Controls.Add(this.Sample_Right_Top_Panel);
            this.Right_Sample_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Right_Sample_Panel.Location = new System.Drawing.Point(250, 0);
            this.Right_Sample_Panel.Name = "Right_Sample_Panel";
            this.Right_Sample_Panel.Size = new System.Drawing.Size(750, 700);
            this.Right_Sample_Panel.TabIndex = 1;
            // 
            // Sample_Right_Top_Panel
            // 
            this.Sample_Right_Top_Panel.Controls.Add(this.UserName_Label);
            this.Sample_Right_Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sample_Right_Top_Panel.Location = new System.Drawing.Point(0, 0);
            this.Sample_Right_Top_Panel.Name = "Sample_Right_Top_Panel";
            this.Sample_Right_Top_Panel.Size = new System.Drawing.Size(750, 100);
            this.Sample_Right_Top_Panel.TabIndex = 1;
            // 
            // UserName_Label
            // 
            this.UserName_Label.AutoSize = true;
            this.UserName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.UserName_Label.Location = new System.Drawing.Point(6, 36);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(102, 29);
            this.UserName_Label.TabIndex = 3;
            this.UserName_Label.Text = "Sample";
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.Right_Sample_Panel);
            this.Controls.Add(this.Left_Sample_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample";
            this.Left_Sample_panel.ResumeLayout(false);
            this.Left_Top_Sample_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sample_Home_Picturebox)).EndInit();
            this.Right_Sample_Panel.ResumeLayout(false);
            this.Sample_Right_Top_Panel.ResumeLayout(false);
            this.Sample_Right_Top_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Left_Sample_panel;
        public System.Windows.Forms.Panel Left_Top_Sample_Panel;
        public System.Windows.Forms.Panel Right_Sample_Panel;
        public System.Windows.Forms.Panel Sample_Right_Top_Panel;
        public System.Windows.Forms.Label UserName_Label;
        public System.Windows.Forms.PictureBox Sample_Home_Picturebox;
    }
}