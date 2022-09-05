
namespace JPIEnrollmentSystem
{
    partial class frmStudent
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.panelTopStudent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStudent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(0, 5);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblStudent.Size = new System.Drawing.Size(199, 23);
            this.lblStudent.TabIndex = 3;
            this.lblStudent.Text = "STUDENT MASTER LIST";
            // 
            // panelTopStudent
            // 
            this.panelTopStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.panelTopStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopStudent.Location = new System.Drawing.Point(0, 0);
            this.panelTopStudent.Name = "panelTopStudent";
            this.panelTopStudent.Size = new System.Drawing.Size(800, 5);
            this.panelTopStudent.TabIndex = 2;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.panelTopStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Panel panelTopStudent;
    }
}