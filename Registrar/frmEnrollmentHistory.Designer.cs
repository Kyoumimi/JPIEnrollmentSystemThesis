
namespace JPIEnrollmentSystem
{
    partial class frmEnrollmentHistory
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
            this.datagridStudentsEnrolled = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gBoxEnrollmentHistory = new System.Windows.Forms.GroupBox();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGradeLvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAcadYear = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblStrand = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudentsEnrolled)).BeginInit();
            this.gBoxEnrollmentHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridStudentsEnrolled
            // 
            this.datagridStudentsEnrolled.AllowUserToAddRows = false;
            this.datagridStudentsEnrolled.AllowUserToResizeColumns = false;
            this.datagridStudentsEnrolled.AllowUserToResizeRows = false;
            this.datagridStudentsEnrolled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridStudentsEnrolled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridStudentsEnrolled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridStudentsEnrolled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colStudentID,
            this.colFullname,
            this.colGradeLvl,
            this.colStrand,
            this.colDate,
            this.colStatus});
            this.datagridStudentsEnrolled.Location = new System.Drawing.Point(15, 107);
            this.datagridStudentsEnrolled.Name = "datagridStudentsEnrolled";
            this.datagridStudentsEnrolled.RowHeadersVisible = false;
            this.datagridStudentsEnrolled.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datagridStudentsEnrolled.Size = new System.Drawing.Size(963, 467);
            this.datagridStudentsEnrolled.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(638, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 23);
            this.textBox1.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(205)))), ((int)(((byte)(97)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(917, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 25);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // gBoxEnrollmentHistory
            // 
            this.gBoxEnrollmentHistory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gBoxEnrollmentHistory.Controls.Add(this.btnClear);
            this.gBoxEnrollmentHistory.Controls.Add(this.btnConfirm);
            this.gBoxEnrollmentHistory.Controls.Add(this.comboBox4);
            this.gBoxEnrollmentHistory.Controls.Add(this.lblStrand);
            this.gBoxEnrollmentHistory.Controls.Add(this.comboBox3);
            this.gBoxEnrollmentHistory.Controls.Add(this.lblGrade);
            this.gBoxEnrollmentHistory.Controls.Add(this.lblTerm);
            this.gBoxEnrollmentHistory.Controls.Add(this.comboBox2);
            this.gBoxEnrollmentHistory.Controls.Add(this.comboBox1);
            this.gBoxEnrollmentHistory.Controls.Add(this.lblAcadYear);
            this.gBoxEnrollmentHistory.Controls.Add(this.textBox1);
            this.gBoxEnrollmentHistory.Controls.Add(this.btnSearch);
            this.gBoxEnrollmentHistory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxEnrollmentHistory.Location = new System.Drawing.Point(1, 1);
            this.gBoxEnrollmentHistory.Name = "gBoxEnrollmentHistory";
            this.gBoxEnrollmentHistory.Size = new System.Drawing.Size(990, 100);
            this.gBoxEnrollmentHistory.TabIndex = 6;
            this.gBoxEnrollmentHistory.TabStop = false;
            this.gBoxEnrollmentHistory.Text = "Enrollment History";
            // 
            // colNumber
            // 
            this.colNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNumber.HeaderText = "#";
            this.colNumber.Name = "colNumber";
            this.colNumber.Width = 39;
            // 
            // colStudentID
            // 
            this.colStudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStudentID.HeaderText = "STUDENT ID";
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.Width = 98;
            // 
            // colFullname
            // 
            this.colFullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFullname.HeaderText = "FULLNAME";
            this.colFullname.Name = "colFullname";
            // 
            // colGradeLvl
            // 
            this.colGradeLvl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGradeLvl.HeaderText = "GRADE ";
            this.colGradeLvl.Name = "colGradeLvl";
            this.colGradeLvl.Width = 73;
            // 
            // colStrand
            // 
            this.colStrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStrand.HeaderText = "STRAND";
            this.colStrand.Name = "colStrand";
            this.colStrand.Width = 77;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDate.HeaderText = "DATE";
            this.colDate.Name = "colDate";
            this.colDate.Width = 61;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.FillWeight = 40F;
            this.colStatus.HeaderText = "STATUS";
            this.colStatus.Name = "colStatus";
            // 
            // lblAcadYear
            // 
            this.lblAcadYear.AutoSize = true;
            this.lblAcadYear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcadYear.Location = new System.Drawing.Point(20, 41);
            this.lblAcadYear.Name = "lblAcadYear";
            this.lblAcadYear.Size = new System.Drawing.Size(92, 15);
            this.lblAcadYear.TabIndex = 6;
            this.lblAcadYear.Text = "Academic Year :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(310, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(114, 23);
            this.comboBox2.TabIndex = 7;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(259, 41);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(39, 15);
            this.lblTerm.TabIndex = 8;
            this.lblTerm.Text = "Term :";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(20, 72);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(46, 15);
            this.lblGrade.TabIndex = 9;
            this.lblGrade.Text = "Grade :";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(118, 71);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(114, 23);
            this.comboBox3.TabIndex = 10;
            // 
            // lblStrand
            // 
            this.lblStrand.AutoSize = true;
            this.lblStrand.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrand.Location = new System.Drawing.Point(259, 72);
            this.lblStrand.Name = "lblStrand";
            this.lblStrand.Size = new System.Drawing.Size(49, 15);
            this.lblStrand.TabIndex = 11;
            this.lblStrand.Text = "Strand :";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(310, 69);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(114, 23);
            this.comboBox4.TabIndex = 12;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(125)))), ((int)(((byte)(65)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(446, 46);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(86, 30);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(536, 46);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 30);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // frmEnrollmentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 586);
            this.Controls.Add(this.gBoxEnrollmentHistory);
            this.Controls.Add(this.datagridStudentsEnrolled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(990, 586);
            this.Name = "frmEnrollmentHistory";
            this.Text = "frmEnrollmentHistory";
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudentsEnrolled)).EndInit();
            this.gBoxEnrollmentHistory.ResumeLayout(false);
            this.gBoxEnrollmentHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridStudentsEnrolled;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gBoxEnrollmentHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGradeLvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label lblAcadYear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblStrand;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
    }
}