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
    public partial class frmListExam : Form
    {
        public frmListExam()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void frmListExam_Load(object sender, EventArgs e)
        {
            using (var context = new ExamContext())
            {
                var query = from s in context.Exams
                            select new { s.name, s.minScorPercent, s.description, s.Questions.Count };
                var exams = query.ToList();
                foreach (var ex in exams)
                {
                    string name = ex.name;
                    int minsco = ex.minScorPercent;
                    string desc = ex.description;
                    int n = ex.Count;

                    dgvExam.Rows.Add(name, minsco, desc, n);
                }

            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
           
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this Exam",
                "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int count = dgvExam.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (count > 0)
                {
                    int index = dgvExam.SelectedRows[0].Index;
                    String name = dgvExam.Rows[index].Cells[0].Value.ToString();
                    using (var context = new ExamContext())
                    {
                        var querry = from s in context.Exams
                                     where s.name.ToUpper() == name.ToUpper()
                                     select s;
                        List<Exam> exams = querry.ToList();
                        foreach (Exam ex in exams)
                        {
                            context.Exams.Remove(ex);
                            context.SaveChanges();
                        }
                    }
                }
                dgvExam.Rows.Clear();
                frmListExam_Load(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {
                dgvExam.Rows.Clear();
                frmListExam_Load(sender, e);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = dgvExam.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (count == 1)
            {
                int index = dgvExam.SelectedRows[0].Index;
                String name = dgvExam.Rows[index].Cells[0].Value.ToString();
                using (var context = new ExamContext())
                {
                    var querry = (from s in context.Exams
                                  where s.name == name
                                  select s.idExam).FirstOrDefault();
                    int id = querry;
                    frmQuestions questionsAdd = new frmQuestions(id);
                    questionsAdd.Show();

                }
            }
        }
    }
}
