using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPIEnrollmentSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void loadForm(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void hideSubMenu()
        {
            if (panelDataEntrySubMenu.Visible == true)
                panelDataEntrySubMenu.Visible = false;
            if (panelRecordsSubMenu.Visible == true)
                panelRecordsSubMenu.Visible = false;
            if (panelMaintenanceSubMenu.Visible == true)
                panelMaintenanceSubMenu.Visible = false;
            if (panelSettingsSubMenu.Visible == true)
                panelSettingsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenuPanel)
        {
            if (subMenuPanel.Visible == false)
            {
                hideSubMenu();
                subMenuPanel.Visible = true;
            }
            else
            {
                subMenuPanel.Visible = false;
            }
        }
        
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(15, 153, 166);
            hideSubMenu();
            loadForm(new frmDashboard());
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            btnEnrollment.BackColor = Color.FromArgb(15, 153, 166);
            hideSubMenu();
            loadForm(new frmEnrollment());
        }

        private void btnDataEntry_Click(object sender, EventArgs e)
        {
            btnDataEntry.BackColor = Color.FromArgb(15, 153, 166);
            showSubMenu(panelDataEntrySubMenu);
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            btnRecords.BackColor = Color.FromArgb(15, 153, 166);
            showSubMenu(panelRecordsSubMenu);
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            btnMaintenance.BackColor = Color.FromArgb(15, 153, 166);
            showSubMenu(panelMaintenanceSubMenu);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(15, 153, 166);
            showSubMenu(panelSettingsSubMenu);
        }

        //SUBMENUS

        private void btnStudent_Click(object sender, EventArgs e)
        {
            btnStudent.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmStudent());
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            btnTeacher.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmTeacher());
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            btnGrade.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmGrade());
        }

        private void btnStudentRecords_Click(object sender, EventArgs e)
        {
            btnStudentRecords.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmStudentRecords());
        }

        private void btnEnrollmentHistory_Click(object sender, EventArgs e)
        {
            btnEnrollmentHistory.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmEnrollmentHistory());
        }

        private void btnClassList_Click(object sender, EventArgs e)
        {
            btnClassList.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmClassList());
        }

        private void btnRequirements_Click(object sender, EventArgs e)
        {
            btnRequirements.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmRequirements());
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            btnArchive.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmArchive());
        }

        private void btnSchoolYear_Click(object sender, EventArgs e)
        {
            btnSchoolYear.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmSchoolYear());
        }

        private void btnStrand_Click(object sender, EventArgs e)
        {
            btnStrand.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmStrand());
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            btnSection.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmSection());
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            btnSubjects.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmSubjects());
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            btnUserSettings.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmSubjects());
        }

        private void btnSchoolSettings_Click(object sender, EventArgs e)
        {
            btnSchoolSettings.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmSubjects());
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            btnBackupRestore.BackColor = Color.FromArgb(15, 153, 166);
            loadForm(new frmSubjects());
        }

        #region LeaveMethods

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(74, 78, 77);
        }

        private void btnEnrollment_Leave(object sender, EventArgs e)
        {
            btnEnrollment.BackColor = Color.FromArgb(74, 78, 77);
        }

        private void btnDataEntry_Leave(object sender, EventArgs e)
        {
            btnDataEntry.BackColor = Color.FromArgb(74, 78, 77);
        }

        private void btnRecords_Leave(object sender, EventArgs e)
        {
            btnRecords.BackColor = Color.FromArgb(74, 78, 77);
        }

        private void btnMaintenance_Leave(object sender, EventArgs e)
        {
            btnMaintenance.BackColor = Color.FromArgb(74, 78, 77);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(74, 78, 77);
        }

        private void btnStudent_Leave(object sender, EventArgs e)
        {
            btnStudent.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnTeacher_Leave(object sender, EventArgs e)
        {
            btnTeacher.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnGrade_Leave(object sender, EventArgs e)
        {
            btnGrade.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnStudentRecords_Leave(object sender, EventArgs e)
        {
            btnStudentRecords.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnEnrollmentHistory_Leave(object sender, EventArgs e)
        {
            btnEnrollmentHistory.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnClassList_Leave(object sender, EventArgs e)
        {
            btnClassList.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnRequirements_Leave(object sender, EventArgs e)
        {
            btnRequirements.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnArchive_Leave(object sender, EventArgs e)
        {
            btnArchive.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnSchoolYear_Leave(object sender, EventArgs e)
        {
            btnSchoolYear.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnStrand_Leave(object sender, EventArgs e)
        {
            btnStrand.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnSection_Leave(object sender, EventArgs e)
        {
            btnSection.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnSubjects_Leave(object sender, EventArgs e)
        {
            btnSubjects.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnUserSettings_Leave(object sender, EventArgs e)
        {
            btnUserSettings.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnSchoolSettings_Leave(object sender, EventArgs e)
        {
            btnSchoolSettings.BackColor = Color.FromArgb(127, 132, 131);
        }

        private void btnBackupRestore_Leave(object sender, EventArgs e)
        {
            btnBackupRestore.BackColor = Color.FromArgb(127, 132, 131);
        }




        #endregion
        private void lblUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
