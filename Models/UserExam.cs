using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_Exam_V2.Models
{
   public class UserExam
    {
        [Key]
        public int idUserExam { get; set; }
        public DateTime date { get; set; }
        public String result { get; set; }
        public int score { get; set; }

        public int idUser { get; set; }
        public User user { get; set; }

        public int idExam { get; set; }
        public Exam exam { get; set; }
    }
}
