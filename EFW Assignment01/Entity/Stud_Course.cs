using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW_Assignment01.Entity
{
    public class Stud_Course
    {
        [Key]
        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }
        public int Grade { get; set; }

    }
}
