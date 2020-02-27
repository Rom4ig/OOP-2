using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.Entity;

namespace Lab10_11_
{
    public class Student : INotifyPropertyChanged
    {
        public int Id { get; set; }
        private string name;
        private int group;

        private int? specID;
        private Spec spec;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
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
        public Spec Spec
        {
            get { return spec; }
            set
            {
                spec = value;
                OnPropertyChanged("Spec");
            }
        }

        public Student(string name, int group, Spec spec)
        {
            this.name = name;
            this.group = group;
            this.spec = spec;
        }
    }
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }


        public class StudentInitializer
            : DropCreateDatabaseAlways<StudentContext>
        {
            // В этом методе можно заполнить таблицу по умолчанию
            protected override void Seed(StudentContext context)
            {
                List<Spec> spec = new List<Spec>
                {
                    new Spec("Дизигн"),
                    new Spec("Исит"),
                    new Spec("Мобил")
                };

                List<Student> students = new List<Student>
                {
                    new Student("Дима", 10, spec.ElementAt(0)),
                    new Student("Илья", 3, spec.ElementAt(1)),
                    new Student("Филя", 7, spec.ElementAt(2))
                };

                foreach (Student student in students)
                    context.Students.Add(student);

                context.SaveChanges();
                base.Seed(context);
            }

        }
    }
}
