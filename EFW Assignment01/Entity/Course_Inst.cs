using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW_Assignment01.Entity
{
    public class Course_Inst
    {
        [Key]
        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        public int Evaluate { get; set; }
    }
}
