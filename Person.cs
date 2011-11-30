using System;
using System.ComponentModel;

namespace PhoneApp71
{
    public class Person : INotifyPropertyChanged
    {
        // Fields...
        private string _Gender;
        private string _LastName;
        private string _FirstName;

        public string Gender
        {
            get { return _Gender; }
            set
            {
                if (_Gender == value)
                    return;
                _Gender = value;
                NotifyPropertyChanged("Gender");
            }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (_FirstName == value)
                    return;
                _FirstName = value;
                NotifyPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (_LastName == value)
                    return;
                _LastName = value;
                NotifyPropertyChanged("LastName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}