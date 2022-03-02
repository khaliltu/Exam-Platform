using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_Exam_V2.Models
{
   public class Exam
    {

        [Key]
        public int idExam { get; set; }
        public String name { get; set; }
        public int minScorPercent { get; set; }
        public String description { get; set; }

        public ICollection<Question> Questions { get; set; }
        public ICollection<UserExam> userExams { get; set; }
    }
}
