using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_Exam_V2.Models
{
   public class Question
    {
        [Key]
        public int idQuest { get; set; }
        public string content { get; set; }
        public string answer { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }

        public int idExam { get; set; }
        public Exam exam { get; set; }
    }
}
