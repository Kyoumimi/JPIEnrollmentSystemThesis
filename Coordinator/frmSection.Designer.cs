
namespace JPIEnrollmentSystem
{
    partial class frmSection
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
            this.lblSection = new System.Windows.Forms.Label();
            this.panelTopSection = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSection.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(0, 5);
            this.lblSection.Name = "lblSection";
            this.lblSection.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblSection.Size = new System.Drawing.Size(97, 23);
            this.lblSection.TabIndex = 3;
            this.lblSection.Text = "SECTIONS";
            // 
            // panelTopSection
            // 
            this.panelTopSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.panelTopSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSection.Location = new System.Drawing.Point(0, 0);
            this.panelTopSection.Name = "panelTopSection";
            this.panelTopSection.Size = new System.Drawing.Size(800, 5);
            this.panelTopSection.TabIndex = 2;
            // 
            // frmSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.panelTopSection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSection";
            this.Text = "frmSection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Panel panelTopSection;
    }
}