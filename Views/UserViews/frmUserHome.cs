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

namespace Platform_Exam_V2.Views.User
{
    public partial class frmUserHome : Form
    {
        private String mail;
        public frmUserHome(String mail)
        {
            InitializeComponent();
            this.mail = mail;
        }

        private void frmUserHome_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            using (var context = new ExamContext())
            {
                var query = from s in context.Exams
                            select s.name;
                var exams = query.ToList();
                foreach (String name in exams)
                {
                    cbExam.Items.Add(name);
                }

            }
        }

        private void cbExam_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnStart.Enabled = true;
            string name = cbExam.SelectedItem.ToString();
            using (var context = new ExamContext())
            {
                var query = from s in context.Exams
                            where s.name == name
                            select new { s.name, s.minScorPercent, s.description, s.Questions.Count };
                var lis = query.FirstOrDefault();
                lbDesc.Text = lis.description;
                lbMinScore.Text = lis.minScorPercent.ToString();
                lbNbrQuest.Text = lis.Count.ToString();


            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int id;
            using (var context = new ExamContext())
            {
                var query = from s in context.Exams
                            where s.name == cbExam.SelectedItem.ToString()
                            select s.idExam;
                id = query.FirstOrDefault();
                frmExamPass frmExamPass = new frmExamPass(id, mail);
                frmExamPass.Show();

            }
        }
    }
}
