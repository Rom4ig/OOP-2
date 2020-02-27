using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _10
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Student selectedStudent;
        public ObservableCollection<Student> StudentsCollection { get; set; }

        // команда добавления нового объекта
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Student student = new Student();
                      StudentsCollection.Insert(0, student); ;
                      selectedStudent = student;
                  }));
            }
        }

        // команда удаления
        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      Student student = obj as Student;
                      if (student != null)
                      {
                          StudentsCollection.Remove(student);
                      }
                  },
                 (obj) => StudentsCollection.Count > 0));
            }
        }
        private RelayCommand DBCommand;
        public RelayCommand DbCommand
        {
            get
            {
                return DBCommand ??
                    (DBCommand = new RelayCommand(obj =>
                    {
                        DBRepository.Save(StudentsCollection);
                    }));
            }
        }

        public Student SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                OnPropertyChanged("SelectedStudent");
            }
        }

        public ApplicationViewModel()
        {
            StudentsCollection = DBRepository.ReturnData();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

}