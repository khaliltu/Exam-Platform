using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_Exam_V2.Models
{
    public class User
    {

        [Key]
        public int idUser { get; set; }
        public String mail { get; set; }
        public String password { get; set; }
        public String name { get; set; }
        public String role { get; set; }

        public ICollection<UserExam> userExams { get; set; }

        public bool isAdmin()
        {
            if (this.role == "admin")
                return true;
            return false;
        }
    }
}
