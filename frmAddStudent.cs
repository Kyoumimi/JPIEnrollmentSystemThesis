using System;
using System.Windows.Forms;

namespace JPIEnrollmentSystem
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void gbxPersonalInfo_Enter(object sender, EventArgs e)
        {

        }

        private void tabStudentDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        bool checkCancel = true;

        //first tab

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            checkCancel = false;
            tabStudentDetails.SelectedTab = tabPage2;
        }

        //second tab

        private void btnNext2_Click(object sender, EventArgs e)
        {
            checkCancel = false;
            tabStudentDetails.SelectedTab = tabPage3;
        }

        private void btnPrev1_Click(object sender, EventArgs e)
        {
            checkCancel = false;
            tabStudentDetails.SelectedTab = tabPage1;
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //third tab

        private void btnPrev2_Click(object sender, EventArgs e)
        {
            checkCancel = false;
            tabStudentDetails.SelectedTab = tabPage2;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tabControl1(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = checkCancel;
            checkCancel = true;
        }
    }
}
