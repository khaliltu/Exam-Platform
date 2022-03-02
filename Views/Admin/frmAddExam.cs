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
    public partial class frmAddExam : Form
    {
        public frmAddExam()
        {
            InitializeComponent();
        }
        public void viderChamps()
        {
            txtDesc.Text = "";
            txtName.Text = "";
            txtMinScore.Text = "";
        }
        private void frmAddExam_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            exam.name = txtName.Text;
            exam.minScorPercent = Int32.Parse(txtMinScore.Text);
            exam.description = txtDesc.Text;
            using (var context = new ExamContext())
            {
                context.Exams.Add(exam);
                context.SaveChanges();
                viderChamps();
                frmAddExam_Load(sender, e);
            }
        }
    }
}
