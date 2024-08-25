using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW_Assignment01.Entity
{
    public class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Bouns { get; set; }
        public double Salary { get; set; }
        public string? address { get; set; }
        public double Hour_rate { get; set; }
        public int Dept_ID { get; set; }
    }
}
