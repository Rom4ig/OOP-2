using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Lab10_11_
{
    public class Spec
    {
        public int ID;
        public ICollection<Student> Students { get; set; }
        public Spec()
        {
            Students = new List<Student>();
        }
        string spec { get; set; }
        public Spec(string spec)
        {
            this.spec = spec;
        }
    }
}
