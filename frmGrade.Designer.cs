
namespace JPIEnrollmentSystem
{
    partial class frmGrade
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
            this.lblGrade = new System.Windows.Forms.Label();
            this.panelTopGrade = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGrade.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(0, 5);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblGrade.Size = new System.Drawing.Size(162, 23);
            this.lblGrade.TabIndex = 3;
            this.lblGrade.Text = "STUDENT GRADES";
            // 
            // panelTopGrade
            // 
            this.panelTopGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.panelTopGrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopGrade.Location = new System.Drawing.Point(0, 0);
            this.panelTopGrade.Name = "panelTopGrade";
            this.panelTopGrade.Size = new System.Drawing.Size(800, 5);
            this.panelTopGrade.TabIndex = 2;
            // 
            // frmGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.panelTopGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGrade";
            this.Text = "frmGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Panel panelTopGrade;
    }
}