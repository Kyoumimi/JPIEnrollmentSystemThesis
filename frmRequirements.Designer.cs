
namespace JPIEnrollmentSystem
{
    partial class frmRequirements
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
            this.gbxStudentsEnrolled = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxTerm = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblAcadYear = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colR1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colR2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colR3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colR4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gbxStudentsEnrolled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxStudentsEnrolled
            // 
            this.gbxStudentsEnrolled.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxStudentsEnrolled.Controls.Add(this.btnSearch);
            this.gbxStudentsEnrolled.Controls.Add(this.textBox1);
            this.gbxStudentsEnrolled.Controls.Add(this.cbxTerm);
            this.gbxStudentsEnrolled.Controls.Add(this.comboBox1);
            this.gbxStudentsEnrolled.Controls.Add(this.lblTerm);
            this.gbxStudentsEnrolled.Controls.Add(this.lblAcadYear);
            this.gbxStudentsEnrolled.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxStudentsEnrolled.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStudentsEnrolled.Location = new System.Drawing.Point(0, 0);
            this.gbxStudentsEnrolled.Name = "gbxStudentsEnrolled";
            this.gbxStudentsEnrolled.Size = new System.Drawing.Size(990, 77);
            this.gbxStudentsEnrolled.TabIndex = 5;
            this.gbxStudentsEnrolled.TabStop = false;
            this.gbxStudentsEnrolled.Text = "Student Requirements";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(205)))), ((int)(((byte)(97)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(914, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(633, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 23);
            this.textBox1.TabIndex = 3;
            // 
            // cbxTerm
            // 
            this.cbxTerm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTerm.FormattingEnabled = true;
            this.cbxTerm.Location = new System.Drawing.Point(293, 34);
            this.cbxTerm.Name = "cbxTerm";
            this.cbxTerm.Size = new System.Drawing.Size(61, 23);
            this.cbxTerm.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(241, 37);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(39, 15);
            this.lblTerm.TabIndex = 1;
            this.lblTerm.Text = "Term :";
            // 
            // lblAcadYear
            // 
            this.lblAcadYear.AutoSize = true;
            this.lblAcadYear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcadYear.Location = new System.Drawing.Point(9, 37);
            this.lblAcadYear.Name = "lblAcadYear";
            this.lblAcadYear.Size = new System.Drawing.Size(92, 15);
            this.lblAcadYear.TabIndex = 1;
            this.lblAcadYear.Text = "Academic Year :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentID,
            this.colFullname,
            this.colR1,
            this.colR2,
            this.colR3,
            this.colR4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(797, 491);
            this.dataGridView1.TabIndex = 6;
            // 
            // colStudentID
            // 
            this.colStudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStudentID.FillWeight = 10F;
            this.colStudentID.HeaderText = "STUDENT ID";
            this.colStudentID.MinimumWidth = 30;
            this.colStudentID.Name = "colStudentID";
            // 
            // colFullname
            // 
            this.colFullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFullname.FillWeight = 50F;
            this.colFullname.HeaderText = "NAME";
            this.colFullname.Name = "colFullname";
            // 
            // colR1
            // 
            this.colR1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colR1.HeaderText = "R1";
            this.colR1.Name = "colR1";
            this.colR1.Width = 27;
            // 
            // colR2
            // 
            this.colR2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colR2.HeaderText = "R2";
            this.colR2.Name = "colR2";
            this.colR2.Width = 27;
            // 
            // colR3
            // 
            this.colR3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colR3.HeaderText = "R3";
            this.colR3.Name = "colR3";
            this.colR3.Width = 27;
            // 
            // colR4
            // 
            this.colR4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colR4.HeaderText = "R4";
            this.colR4.Name = "colR4";
            this.colR4.Width = 27;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(815, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(163, 70);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "R1: Form138\nR2: PSA Birth Certificate\nR3: Certificate of Good Moral\nR4: 2x2 ID Pi" +
    "cture";
            // 
            // frmRequirements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 586);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxStudentsEnrolled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(990, 586);
            this.Name = "frmRequirements";
            this.Text = "frmRequirements";
            this.gbxStudentsEnrolled.ResumeLayout(false);
            this.gbxStudentsEnrolled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStudentsEnrolled;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxTerm;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblAcadYear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colR1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colR2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colR3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colR4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}