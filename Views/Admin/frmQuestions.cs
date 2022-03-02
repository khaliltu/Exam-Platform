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
    public partial class frmQuestions : Form
    {
        public int id;

        private void setId(int id)
        {
            this.id = id;
        }
        public void viderChamp()
        {
            txtAnswer.Text = "";
            txtQuest.Text = "";
            txtOption2.Text = "";
            txtOption1.Text = "";

        }

        public bool champsVide()
        {
            if (txtAnswer.Text == "" ||
            txtQuest.Text == "" ||
            txtOption2.Text == "" ||
            txtOption1.Text == "")
                return true;
            return false;

        }
        public frmQuestions(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmQuestions_Load(object sender, EventArgs e)
        {
            using (var context = new ExamContext())
            {
                var query = from s in context.Exams
                            select s.name;
                var exams = query.ToList();
                foreach (String name in exams)
                {
                    cbExam.Items.Add(name);
                }
                /////////////////////////////////////////////////
                var query1 = from s in context.Questions
                             where s.idExam == this.id
                             select s;
                var questions = query1.ToList();
                foreach (var ex in questions)
                {
                    String content = ex.content;
                    String answer = ex.answer;
                    String option1 = ex.option1;
                    String option2 = ex.option2;
                    dgvQuestion.Rows.Add(content, answer, option1, option2);
                }
                viderChamp();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Question q = new Question();
            q.content = txtQuest.Text;
            q.answer = txtAnswer.Text;
            q.option1 = txtOption1.Text;
            q.option2 = txtOption2.Text;
            using (var ctx = new ExamContext())
            {
                var querry = (from s in ctx.Questions
                              where s.content.ToUpper() == txtQuest.Text.ToUpper()
                              select s).FirstOrDefault();
                if (champsVide() == false)
                {
                    if (querry == null)
                    {
                        using (var context = new ExamContext())
                        {
                            var query1 = from s in context.Exams
                                         where s.idExam == this.id
                                         select s.idExam;

                            q.idExam = query1.First();

                            context.Questions.Add(q);
                            context.SaveChanges();
                            viderChamp();
                            cbExam.Items.Clear();
                            dgvQuestion.Rows.Clear();
                            this.frmQuestions_Load(sender, e);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Question Already exist");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in the necessary information");
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Question q = new Question();
            q.content = txtQuest.Text;
            q.answer = txtAnswer.Text;
            q.option1 = txtOption1.Text;
            q.option2 = txtOption2.Text;
            using (var ctx = new ExamContext())
            {
                var querry = (from s in ctx.Questions
                              where s.content.ToUpper() == txtQuest.Text.ToUpper()
                              select s).FirstOrDefault();
                if (champsVide() == false)
                {
                    if (querry == null)
                    {
                        using (var context = new ExamContext())
                        {
                            var query1 = from s in context.Exams
                                         where s.idExam == this.id
                                         select s.idExam;

                            q.idExam = query1.First();

                            context.Questions.Add(q);
                            context.SaveChanges();
                            this.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Question Already exist");
                    }
                }
                else
                {
                    this.Close();
                }

            }
        }

        private void cbExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            String examName = cbExam.SelectedItem.ToString();
            using (var context = new ExamContext())
            {
                var querry = (from s in context.Exams
                              where s.name == examName
                              select s.idExam).FirstOrDefault();
                this.setId(querry);
                cbExam.Items.Clear();
                dgvQuestion.Rows.Clear();
                frmQuestions_Load(sender, e);


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this Question?",
               "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int count = dgvQuestion.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (count > 0)
                {
                    int index = dgvQuestion.SelectedRows[0].Index;
                    String content = dgvQuestion.Rows[index].Cells[0].Value.ToString();
                    using (var context = new ExamContext())
                    {
                        var querry = from s in context.Questions
                                     where s.content.ToUpper() == content.ToUpper()
                                     select s;
                        List<Question> quest = querry.ToList();
                        foreach (Question ex in quest)
                        {
                            context.Questions.Remove(ex);
                            context.SaveChanges();
                        }
                    }
                }
                dgvQuestion.Rows.Clear();
                frmQuestions_Load(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {
                dgvQuestion.Rows.Clear();
                frmQuestions_Load(sender, e);
            }
        }

        private void dgvQuestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
