
namespace JPIEnrollmentSystem
{
    partial class frmTeacher
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
            this.lblTeacher = new System.Windows.Forms.Label();
            this.panelTopTeacher = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTeacher.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.Location = new System.Drawing.Point(0, 5);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTeacher.Size = new System.Drawing.Size(127, 23);
            this.lblTeacher.TabIndex = 3;
            this.lblTeacher.Text = "TEACHER LIST";
            // 
            // panelTopTeacher
            // 
            this.panelTopTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.panelTopTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTeacher.Location = new System.Drawing.Point(0, 0);
            this.panelTopTeacher.Name = "panelTopTeacher";
            this.panelTopTeacher.Size = new System.Drawing.Size(800, 5);
            this.panelTopTeacher.TabIndex = 2;
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.panelTopTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTeacher";
            this.Text = "frmTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Panel panelTopTeacher;
    }
}