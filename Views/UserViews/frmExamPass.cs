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
    public partial class frmExamPass : Form
    {
        private String mail;
        private int id;
        private List<Models.Question> questions = new List<Models.Question>();
        private Models.Exam exam;
        private int index;
        private int length;
        private List<string> answers = new List<string>();
        private int score;
        private bool f = false;
        private void getAnswers(Models.Question q)
        {
            this.answers.Add(q.answer);
            this.answers.Add(q.option1);
            this.answers.Add(q.option2);
        }
        private Random rng = new Random();
        private void melange(IList<string> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        public frmExamPass()
        {
            InitializeComponent();
        }
        public frmExamPass(int id, String mail)
        {
            InitializeComponent();
            this.id = id;
            this.mail = mail;
        }

        private void btnNext_Load(object sender, EventArgs e)
        {
            using (var ctx = new ExamContext())
            {
                var querry = from s in ctx.Exams
                             where s.idExam == id
                             select s;
                var queryQ = from s in ctx.Questions
                             where s.idExam == id
                             select s;

                exam = querry.FirstOrDefault();
                questions = queryQ.ToList();
                length = questions.Count;
                index = 0; score = 0;
                getAnswers(questions[index]);
                melange(answers);
                lbExam.Text = exam.name;
                lbQuestion.Text = questions[index].content;
                rboption1.Text = answers[0];
                rboption2.Text = answers[1];
                rboption3.Text = answers[2];
                btnNext.Text = "next";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var button = gbAnswer.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            if (button == null)
                MessageBox.Show("Please select an option");
            else
            {
                string userA = button.Text;
                if (userA == questions[index].answer)
                {
                    score++;
                }
                if (++index == length)
                {
                    frmResult frm = new frmResult(id, score,mail);
                    frm.Show();
                    this.Close();
                }
                else
                {
                    answers.Clear();
                    getAnswers(questions[index]);
                    melange(answers);
                    lbQuestion.Text = questions[index].content;
                    rboption1.Text = answers[0];
                    rboption2.Text = answers[1];
                    rboption3.Text = answers[2];
                    foreach (RadioButton rb in gbAnswer.Controls.OfType<RadioButton>().ToList())
                    {
                        rb.Checked = false;
                    }
                    if (index == length - 1)
                    {
                        btnNext.Text = "Finish Exam";
                    }
                }
            }
        }

        private void gbAnswer_Enter(object sender, EventArgs e)
        {

        }
    }
}
