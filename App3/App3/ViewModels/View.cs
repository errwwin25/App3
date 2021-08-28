using App3.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace App3.ViewModels
{
    public class View : Student
    {
        private Data _data;
        public View()
        {
            _data = new Data
            {
                StudentID = 1423,
                Name = "Erwin",
                CourseCode = 04,
                CourseTitle = "Xamarin",
                NoUnits = 3,
                DateofAttendance = 28

            };
        }
        public int StudentID
        {
            get { return _data.StudentID; }
            set { _data.StudentID = value;
                OnPropertyChanged("StudentID");
                OnPropertyChanged("Info");
            }
        }
        public string Name
        {
            get { return _data.Name; }
            set { _data.Name = value;
                OnPropertyChanged("Name");
                OnPropertyChanged("Info");
            }
        }
        public int CourseCode
        {
            get { return _data.CourseCode; }
            set
            {
                _data.CourseCode = value;
                OnPropertyChanged("CourseCode");
                OnPropertyChanged("Info");
            }
        }
        public string CourseTitle
        {
            get { return _data.CourseTitle; }
            set
            {
                _data.CourseTitle = value;
                OnPropertyChanged("CourseTitle");
                OnPropertyChanged("Info");
            }
        }
        public int NoUnits
        {
            get { return _data.NoUnits; }
            set
            {
                _data.NoUnits = value;
                OnPropertyChanged("NoUnits");
                OnPropertyChanged("Info");
            }
        }
        public int DateofAttendance
        {
            get { return _data.DateofAttendance; }
            set
            {
                _data.DateofAttendance = value;
                OnPropertyChanged("DateofAttendance");
                OnPropertyChanged("Info");
            }
        }
        public string Info
        {
            get { return _data.PersonInfo(); }
        }
    }
}
