using Platform_Exam_V2.Models;
using Platform_Exam_V2.Views.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platform_Exam_V2.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bntLogin_Click(object sender, EventArgs e)
        {

            string mail = txtMail.Text;
            string pass = txtPassword.Text;
            using (var context = new ExamContext())
            {
                var query = from st in context.Users
                            where st.mail.ToUpper() == mail.ToUpper()
                            select st;

                var user = query.FirstOrDefault<Models.User>();
                if (user != null)
                {
                    if (user.isAdmin())
                    {
                        
                        frmHome ah = new frmHome();
                        ah.Show();
                        
                    }
                    else
                    {
                        frmUserHome userHome = new frmUserHome(mail);
                        userHome.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Entries do not match a valid user");
                }
            }
        }
    }
}
