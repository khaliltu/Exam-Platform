using Platform_Exam_V2.Models;
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
    public partial class frmUserAdd : Form
    {
        public frmUserAdd()
        {
            InitializeComponent();
        }
        public void viderChamps()
        {
            txtMail.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
        }
        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            cbRole.SelectedItem = "student";
            using (var context = new ExamContext())
            {
                var query = from s in context.Users
                            select s;
                var users = query.ToList();
                foreach (Models.User ex in users)
                {

                    string eMail = ex.mail;
                    string name = ex.name;
                    string password = ex.password;

                    dgvUser.Rows.Add(eMail, password, name);

                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = dgvUser.SelectedRows[0].Index;
            String mail = dgvUser.Rows[index].Cells[0].Value.ToString();
            using (var context = new ExamContext())
            {
                var querry = (from s in context.Users
                              where s.mail == mail
                              select s).FirstOrDefault();
                querry.mail = txtMail.Text;
                querry.name = txtName.Text;
                querry.password = txtPassword.Text;
                querry.role = cbRole.SelectedItem.ToString();
                context.SaveChanges();
                dgvUser.Rows.Clear();
                frmUserAdd_Load(sender, e);
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = dgvUser.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (count == 1)
            {
                int index = dgvUser.SelectedRows[0].Index;
                String mail = dgvUser.Rows[index].Cells[0].Value.ToString();
                using (var context = new ExamContext())
                {
                    var querry = (from s in context.Users
                                  where s.mail == mail
                                  select s).FirstOrDefault();
                    Models.User u = querry;
                    txtMail.Text = u.mail;
                    txtName.Text = u.name;
                    txtPassword.Text = u.password;
                    cbRole.SelectedItem = u.role;
                    if (u.role == "admin")
                    {
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }


                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbRole.SelectedItem.ToString() == "admin")
            {
                MessageBox.Show("You can't Delete An Admin!!!!!");
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure to delete this User?",
                    "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var context = new ExamContext())
                    {
                        var querry = (from s in context.Users
                                      where s.mail == txtMail.Text
                                      select s).FirstOrDefault();
                        context.Users.Remove(querry);
                        context.SaveChanges();
                        dgvUser.Rows.Clear();
                        viderChamps();
                        frmUserAdd_Load(sender, e);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    viderChamps();
                    dgvUser.Rows.Clear();
                    frmUserAdd_Load(sender, e);
                }
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            String mail = txtMail.Text;
            String pass = txtPassword.Text;
            String name = txtName.Text;
            String role = cbRole.SelectedItem.ToString();
            using (var context = new ExamContext())
            {
                var querry = (from s in context.Users
                              where s.mail.ToUpper() == txtMail.Text.ToUpper()
                              select s.mail).FirstOrDefault();
                if (querry != null)
                {
                    MessageBox.Show("User already Exist");
                }
                else
                {
                    if (txtMail.Text != "" && txtPassword.Text != "")
                    {
                        Models.User user = new Models.User();
                        user.mail = mail;
                        user.password = pass;
                        user.name = name;
                        user.role = role;
                        context.Users.Add(user);
                        context.SaveChanges();
                        MessageBox.Show("User Added Successfully");
                        viderChamps();
                        dgvUser.Rows.Clear();
                        frmUserAdd_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Please fill the empty entries!!!!!!");
                    }
                }

            }
        }
    }
}
