using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platform_Exam_V2.Views.Admin
{
    class Routes
    {
        public void Access(string location, ref frmHome frm)
        {
            switch (location.ToLower())
            {
                case "    Add":
                    frmAddExam frmAdd = new frmAddExam();
                    frmAdd.MdiParent = frm;
                    frmAdd.Show();
                    break;
                case "     List":
                    frmListExam frmList = new frmListExam();
                    frmList.MdiParent = frm;
                    frmList.Show();
                    break;
                default:
                    MessageBox.Show("Please try again. Page cannot be opened.");
                    break;
            }
        }
    }
}
