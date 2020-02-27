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
      public class Student : INotifyPropertyChanged
        {
            [Key]
            public int Id { get; set; }
            private string name;
            private int group;
            

            private Spec Spec { get; set; }

            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName]string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }

            public string Specstring
        {
            get { if (Spec != null)
                    return Spec.ToString();
                else
                    return "Дизайн";
            }
            set
            {
                this.Spec = new Spec(value);
                OnPropertyChanged(Specstring);
            }
        }

            public string Name
            {
                get { return name; }
                set
                {
                    name = value;
                    OnPropertyChanged("Name;");
                }
            }
            public int Group
            {
                get { return group; }
                set
                {
                    group = value;
                    OnPropertyChanged("Group");
                }
            }
            public Spec spec
            {
                get { return Spec; }
                set
                {
                    Spec = value;
                    OnPropertyChanged("Spec");
                }
            }
            

        public Student(string name, int group, Spec spec)
            {
                this.name = name;
                this.group = group;
                this.Spec = spec;
            }
            public Student()
            {

            }
        }
    

}
