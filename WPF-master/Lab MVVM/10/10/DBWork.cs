using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.Entity;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _10
{
    public class StudentDB
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public int group { get; set; }

        public int SpecId { get; set; }
        public Spec Spec { get; set; }

        public StudentDB(string name, int group, Spec spec)
        {
            this.name = name;
            this.group = group;
            using (StudentDBContext db = new StudentDBContext())
            {
                int specid = -1;
                List<Spec> specs = db.Specs.ToList<Spec>();
                foreach (Spec Spec in specs)
                {
                    if (spec == Spec)
                    {
                        specid = Spec.Id;
                    }
                }
                this.SpecId = specid;
            }
            this.Spec = spec;
        }
        public StudentDB()
        {

        }

    }

    public class StudentDBContext : DbContext
    {
        public DbSet<StudentDB> Students { get; set; }
        public DbSet<Spec> Specs { get; set; }

        public StudentDBContext() : base("StudentDBContext")
        {

        }

        static StudentDBContext()
        {
            Database.SetInitializer<StudentDBContext>(new StudentDBInitializer());
        }

        public class StudentDBInitializer:DropCreateDatabaseIfModelChanges<StudentDBContext>
        {
            // В этом методе можно заполнить таблицу по умолчанию
            protected override void Seed(StudentDBContext context)
            {
                List<Spec> specs = new List<Spec>();
                Spec Design = new Spec("Дизигн");
                Spec Isit = new Spec("Исит");
                Spec Mob = new Spec("Мобил");
                specs.Add(Design);
                specs.Add(Mob);
                specs.Add(Isit);

                List<StudentDB> students = new List<StudentDB>
                {
                    new StudentDB("Дима", 10, Design),
                    new StudentDB("Илья", 3, Isit),
                    new StudentDB("Филя", 7, Mob)
                };
                foreach (Spec spec in specs)
                    //          context.Specs.Add(spec);

                    foreach (StudentDB student in students)
                        context.Students.Add(student);

                context.SaveChanges();
                base.Seed(context);
            }

        }
    }

    public static class DBRepository
    {
        public static ObservableCollection<Student> ReturnData()
        {
            ObservableCollection<Student> observable = new ObservableCollection<Student>();

            using (StudentDBContext db = new StudentDBContext())
            {
                foreach (StudentDB student in db.Students)
                {
                    student.Spec = DBRepository.ReturnSpec(student);
                    observable.Add(new Student(student.name, student.group, student.Spec/*new Spec()*/));
                }
            }

            return observable;
        }
        public static void Insert(Student student)
        {
            StudentDB value = new StudentDB(student.Name, student.Group, student.spec);
            using (StudentDBContext db = new StudentDBContext())
            {
                db.Students.Add(value);
                db.SaveChanges();
            }
        }
        public static void Remove(Student student)
        {
            StudentDB value = new StudentDB(student.Name, student.Group, student.spec);
            using (StudentDBContext db = new StudentDBContext())
            {
                db.Students.Remove(value);
                db.SaveChanges();
            }
        }
        public static Spec ReturnSpec(StudentDB studentDB)
        {
            using (StudentDBContext db = new StudentDBContext())
            {
                Spec spec = new Spec();
                List<Spec> specs = db.Specs.ToList<Spec>();
                foreach (Spec Spec in specs)
                {
                    if (Spec.Id == studentDB.SpecId)
                    {
                        spec = Spec;
                    }
                }
                return spec;
            }
        }
        public static void Save(ObservableCollection<Student> students)
        {
            using(StudentDBContext db = new StudentDBContext())
            {
                ObservableCollection<Student> todb = DBRepository.ReturnData();
                foreach(Student student in students)
                {
                    if (!todb.Contains(student))
                    {
                        DBRepository.Insert(student);
                    }
                }
                db.SaveChanges();
            }
        }
    }
    
    
}

