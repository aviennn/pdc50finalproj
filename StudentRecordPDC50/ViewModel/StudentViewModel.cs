using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRecordPDC50.Model;
using StudentRecordPDC50.Services;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StudentRecordPDC50.ViewModel
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private string _idno;
        private string _name;
        private string _gender;
        private string _college;
        private string _course;
        private string _yearlevel;

        public string Idno
        {
            get => _idno;
            set
            {
                _idno = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged();
            }
        }

        public string College
        {
            get => _college;
            set
            {
                _college = value;
                OnPropertyChanged();
            }
        }

        public string Course
        {
            get => _course;
            set
            {
                _course = value;
                OnPropertyChanged();
            }
        }

        public string Yearlevel
        {
            get => _yearlevel;
            set
            {
                _yearlevel = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
