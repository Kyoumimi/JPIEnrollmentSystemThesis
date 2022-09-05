
namespace JPIEnrollmentSystem
{
    partial class frmClassList
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
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbxGradeLvl = new System.Windows.Forms.ComboBox();
            this.cbxStrand = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxTerm = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblAcadYear = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdviser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxStudentsEnrolled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxStudentsEnrolled
            // 
            this.gbxStudentsEnrolled.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxStudentsEnrolled.Controls.Add(this.label21);
            this.gbxStudentsEnrolled.Controls.Add(this.label20);
            this.gbxStudentsEnrolled.Controls.Add(this.cbxGradeLvl);
            this.gbxStudentsEnrolled.Controls.Add(this.cbxStrand);
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
            this.gbxStudentsEnrolled.Size = new System.Drawing.Size(990, 101);
            this.gbxStudentsEnrolled.TabIndex = 5;
            this.gbxStudentsEnrolled.TabStop = false;
            this.gbxStudentsEnrolled.Text = "Students Enrolled";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(247, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 15);
            this.label21.TabIndex = 7;
            this.label21.Text = "Grade :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(14, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 15);
            this.label20.TabIndex = 8;
            this.label20.Text = "Strand :";
            // 
            // cbxGradeLvl
            // 
            this.cbxGradeLvl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGradeLvl.FormattingEnabled = true;
            this.cbxGradeLvl.Location = new System.Drawing.Point(299, 64);
            this.cbxGradeLvl.Name = "cbxGradeLvl";
            this.cbxGradeLvl.Size = new System.Drawing.Size(61, 23);
            this.cbxGradeLvl.TabIndex = 5;
            // 
            // cbxStrand
            // 
            this.cbxStrand.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStrand.FormattingEnabled = true;
            this.cbxStrand.Location = new System.Drawing.Point(124, 64);
            this.cbxStrand.Name = "cbxStrand";
            this.cbxStrand.Size = new System.Drawing.Size(114, 23);
            this.cbxStrand.TabIndex = 6;
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
            this.cbxTerm.Location = new System.Drawing.Point(299, 34);
            this.cbxTerm.Name = "cbxTerm";
            this.cbxTerm.Size = new System.Drawing.Size(61, 23);
            this.cbxTerm.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(247, 37);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(39, 15);
            this.lblTerm.TabIndex = 1;
            this.lblTerm.Text = "Term :";
            // 
            // lblAcadYear
            // 
            this.lblAcadYear.AutoSize = true;
            this.lblAcadYear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcadYear.Location = new System.Drawing.Point(15, 37);
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
            this.colSectionName,
            this.colAdviser,
            this.colNumStudents});
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(966, 467);
            this.dataGridView1.TabIndex = 6;
            // 
            // colSectionName
            // 
            this.colSectionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSectionName.FillWeight = 60F;
            this.colSectionName.HeaderText = "SECTION NAME";
            this.colSectionName.Name = "colSectionName";
            // 
            // colAdviser
            // 
            this.colAdviser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAdviser.FillWeight = 30F;
            this.colAdviser.HeaderText = "ADVISER";
            this.colAdviser.Name = "colAdviser";
            // 
            // colNumStudents
            // 
            this.colNumStudents.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNumStudents.FillWeight = 15F;
            this.colNumStudents.HeaderText = "NO. OF STUDENTS";
            this.colNumStudents.Name = "colNumStudents";
            // 
            // frmClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 586);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxStudentsEnrolled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(990, 586);
            this.Name = "frmClassList";
            this.Text = "frmClassList";
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
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbxGradeLvl;
        private System.Windows.Forms.ComboBox cbxStrand;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdviser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumStudents;
    }
}