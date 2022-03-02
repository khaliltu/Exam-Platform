using Platform_Exam_V2.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Windows.Forms;

namespace Platform_Exam_V2.Views
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        
        
       
        


        private void frmHome_Load(object sender, EventArgs e)
        {
            frmAddExam frmAddExam = new frmAddExam();

            frmAddExam.MdiParent = this;
            frmAddExam.Show();
            frmAddExam.WindowState = FormWindowState.Maximized;
        }

        public void DisposeAllInActiveForms()
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }



        }
        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            frmAddExam frmAddExam = new frmAddExam();
            
            frmAddExam.MdiParent = this;
            frmAddExam.Show();
            frmAddExam.WindowState = FormWindowState.Maximized;
      
        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            
            frmListExam frmListExam = new frmListExam();
            
            frmListExam.MdiParent = this;
            frmListExam.Show();
            frmListExam.WindowState = FormWindowState.Maximized;
            
        }

        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            frmUserAdd frmUserAdd = new frmUserAdd();
            frmUserAdd.MdiParent = this;
            frmUserAdd.Show();
            frmUserAdd.WindowState = FormWindowState.Maximized;
        }

        private void btnListUserExams_Click(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            frmUserExams frmUserExam = new frmUserExams();
            frmUserExam.MdiParent = this;
            frmUserExam.Show();
            frmUserExam.WindowState = FormWindowState.Maximized;
        }
    }
}
