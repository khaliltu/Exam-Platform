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
    public partial class frmResult : Form
    {
        private int id;
        private int score;
        private String mail;
        public frmResult(int id, int score, String mail)
        {
            InitializeComponent();
            this.id = id;
            this.score = score;
            this.mail = mail;
        }
        public frmResult()
        {
            InitializeComponent();
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            using (var ctx = new ExamContext())
            {
                UserExam userExam = new UserExam();
                var querry = from s in ctx.Exams
                             where s.idExam == id
                             select s;
                var queryQ = from s in ctx.Questions
                             where s.idExam == id
                             select s;
                Models.Exam exam = querry.FirstOrDefault();
                int l = queryQ.ToList().Count;
                lbExam.Text = exam.name;
                lbMinScore.Text = exam.minScorPercent.ToString();
                float sc = (score * 100) / l;
                lbScore.Text = sc.ToString();
                if (sc >= exam.minScorPercent)
                {
                    lbResult.Text = "Congrats!";
                    userExam.result = "Passed";
                }
                else
                {
                    lbResult.Text = "hard luck!!!";
                    userExam.result = "Failed";
                }
                var queryU = (from s in ctx.Users
                             where s.mail == mail
                             select s.idUser).FirstOrDefault();
                userExam.date = DateTime.Today;
                userExam.idUser = queryU;
                userExam.idExam = exam.idExam;
                userExam.score = score;
                ctx.UserExams.Add(userExam);
                ctx.SaveChanges();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
