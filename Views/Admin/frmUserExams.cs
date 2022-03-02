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

namespace Platform_Exam_V2.Views.Admin
{
    public partial class frmUserExams : Form
    {
        public frmUserExams()
        {
            InitializeComponent();
        }

        private void frmUserExams_Load(object sender, EventArgs e)
        {
            using ( var ctx = new ExamContext())
            {
                var query = from s in ctx.UserExams
                            select new {s.date,s.exam,s.user,s.result};
                var liste = query.ToList();
                foreach ( var v in liste)
                {
                    DateTime date = v.date;
                    String exam = v.exam.name;
                    String user = v.user.name;
                    String result = v.result;
                    dgvHistory.Rows.Add(date, exam, user, result);

                }
                
            }
        }
    }
}
