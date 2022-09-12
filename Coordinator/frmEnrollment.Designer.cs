
namespace JPIEnrollmentSystem
{
    partial class frmEnrollment
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
            this.panelMainEnrollment = new System.Windows.Forms.Panel();
            this.datagridStudentsEnrolled = new System.Windows.Forms.DataGridView();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGradeLvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAcadYear = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.cbAcademicYear = new System.Windows.Forms.ComboBox();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnAddExisting = new System.Windows.Forms.Button();
            this.gbxStudentsEnrolled = new System.Windows.Forms.GroupBox();
            this.panelMainEnrollment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudentsEnrolled)).BeginInit();
            this.gbxStudentsEnrolled.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainEnrollment
            // 
            this.panelMainEnrollment.Controls.Add(this.datagridStudentsEnrolled);
            this.panelMainEnrollment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainEnrollment.Location = new System.Drawing.Point(0, 101);
            this.panelMainEnrollment.Name = "panelMainEnrollment";
            this.panelMainEnrollment.Size = new System.Drawing.Size(990, 473);
            this.panelMainEnrollment.TabIndex = 5;
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
            this.datagridStudentsEnrolled.Location = new System.Drawing.Point(15, 6);
            this.datagridStudentsEnrolled.Name = "datagridStudentsEnrolled";
            this.datagridStudentsEnrolled.RowHeadersVisible = false;
            this.datagridStudentsEnrolled.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datagridStudentsEnrolled.Size = new System.Drawing.Size(963, 464);
            this.datagridStudentsEnrolled.TabIndex = 0;
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
            this.lblAcadYear.Location = new System.Drawing.Point(15, 37);
            this.lblAcadYear.Name = "lblAcadYear";
            this.lblAcadYear.Size = new System.Drawing.Size(92, 15);
            this.lblAcadYear.TabIndex = 1;
            this.lblAcadYear.Text = "Academic Year :";
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
            // cbAcademicYear
            // 
            this.cbAcademicYear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAcademicYear.FormattingEnabled = true;
            this.cbAcademicYear.Location = new System.Drawing.Point(124, 34);
            this.cbAcademicYear.Name = "cbAcademicYear";
            this.cbAcademicYear.Size = new System.Drawing.Size(114, 23);
            this.cbAcademicYear.TabIndex = 2;
            // 
            // cbTerm
            // 
            this.cbTerm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTerm.FormattingEnabled = true;
            this.cbTerm.Location = new System.Drawing.Point(299, 34);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(61, 23);
            this.cbTerm.TabIndex = 2;
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
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(125)))), ((int)(((byte)(65)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(18, 65);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(86, 30);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "ADD NEW";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnAddExisting
            // 
            this.btnAddExisting.AutoSize = true;
            this.btnAddExisting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddExisting.FlatAppearance.BorderSize = 0;
            this.btnAddExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExisting.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExisting.ForeColor = System.Drawing.Color.White;
            this.btnAddExisting.Location = new System.Drawing.Point(110, 65);
            this.btnAddExisting.Name = "btnAddExisting";
            this.btnAddExisting.Size = new System.Drawing.Size(92, 30);
            this.btnAddExisting.TabIndex = 6;
            this.btnAddExisting.Text = "ADD EXISTING";
            this.btnAddExisting.UseVisualStyleBackColor = false;
            // 
            // gbxStudentsEnrolled
            // 
            this.gbxStudentsEnrolled.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxStudentsEnrolled.Controls.Add(this.btnAddExisting);
            this.gbxStudentsEnrolled.Controls.Add(this.btnAddNew);
            this.gbxStudentsEnrolled.Controls.Add(this.btnSearch);
            this.gbxStudentsEnrolled.Controls.Add(this.textBox1);
            this.gbxStudentsEnrolled.Controls.Add(this.cbTerm);
            this.gbxStudentsEnrolled.Controls.Add(this.cbAcademicYear);
            this.gbxStudentsEnrolled.Controls.Add(this.lblTerm);
            this.gbxStudentsEnrolled.Controls.Add(this.lblAcadYear);
            this.gbxStudentsEnrolled.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxStudentsEnrolled.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStudentsEnrolled.Location = new System.Drawing.Point(0, 0);
            this.gbxStudentsEnrolled.Name = "gbxStudentsEnrolled";
            this.gbxStudentsEnrolled.Size = new System.Drawing.Size(990, 101);
            this.gbxStudentsEnrolled.TabIndex = 4;
            this.gbxStudentsEnrolled.TabStop = false;
            this.gbxStudentsEnrolled.Text = "Students Enrolled";
            // 
            // frmEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(990, 586);
            this.Controls.Add(this.panelMainEnrollment);
            this.Controls.Add(this.gbxStudentsEnrolled);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(990, 586);
            this.Name = "frmEnrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnrollment";
            this.panelMainEnrollment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudentsEnrolled)).EndInit();
            this.gbxStudentsEnrolled.ResumeLayout(false);
            this.gbxStudentsEnrolled.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMainEnrollment;
        private System.Windows.Forms.DataGridView datagridStudentsEnrolled;
        private System.Windows.Forms.Label lblAcadYear;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.ComboBox cbAcademicYear;
        private System.Windows.Forms.ComboBox cbTerm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnAddExisting;
        private System.Windows.Forms.GroupBox gbxStudentsEnrolled;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGradeLvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}