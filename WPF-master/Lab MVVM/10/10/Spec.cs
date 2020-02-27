using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.Entity;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace _10
{
    public class Spec
    {
        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StudentDB> Students { get; set; }
        public Spec()
        {
            Students = new List<StudentDB>();
        }
        public Spec(string spec)
        {
            this.Name = spec;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
