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
    public partial class frmEnrollment : Form
    {
        public frmEnrollment()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddStudent frm = new frmAddStudent();
            frm.ShowDialog();
        }
    }
}
