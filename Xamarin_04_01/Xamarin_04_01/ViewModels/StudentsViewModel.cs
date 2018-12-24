using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_04_01.Models;

namespace Xamarin_04_01.ViewModels
{
    class StudentsViewModel : INotifyPropertyChanged
    {

        public ICommand AddStudentCommand { set; get; }
        public ICommand DeleteStudentCommand { set; get; }

        private ObservableCollection<Student> _students;
        public ObservableCollection<Student> Students
        {
            get => _students;
            set
            {
                _students = value;
                OnPropertyChanged(nameof(Students));
            }
        }

      

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length > 0)
                    _surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }

        private int _physicScore;
        public int PhysicScore
        {
            get { return _physicScore; }
            set
            {
                if (value > 2 && value <= 5)
                    _physicScore = value;
                OnPropertyChanged(nameof(PhysicScore));
            }
        }

        private int _mathScore;
        public int MathScore
        {
            get { return _mathScore; }
            set
            {
                if (value > 2 && value <= 5)
                    _mathScore = value;
                OnPropertyChanged(nameof(MathScore));
            }
        }

        private int _infScore;
        public int InfScore
        {
            get { return _infScore; }
            set
            {
                if (value > 2 && value <= 5)
                    _infScore = value;
                OnPropertyChanged(nameof(InfScore));
            }
        }

        public StudentsViewModel()
        {
            Students = new ObservableCollection<Student>();
            AddStudentCommand = new Command(AddStudent);
            DeleteStudentCommand = new Command(DeleteStudent);
        }

        private void DeleteStudent()
        {

        }

        private void AddStudent()
        {
            var student = new Student
            {
                Surname = this.Surname,
                InfScore = this.InfScore,
                MathScore = this.MathScore,
                PhysicScore = this.PhysicScore
            };

            Students.Add(student);
        }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        #endregion
    }
}
