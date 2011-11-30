using System;
using System.Collections.ObjectModel;

namespace PhoneApp71
{
    public class PileOfData
    {
        public ObservableCollection<Person> People { get; set; }

        public PileOfData()
        {
            People = new ObservableCollection<Person>();
            People.Add(new Person() { Gender = "Male", FirstName = "Chris", LastName = "Koenig" });
            People.Add(new Person() { Gender = "Female", FirstName = "Laura", LastName = "Koenig" });
            People.Add(new Person() { Gender = "Male", FirstName = "David", LastName = "Koenig" });
            People.Add(new Person() { Gender = "Female", FirstName = "Christine", LastName = "Koenig" });
            People.Add(new Person() { Gender = "Male", FirstName = "Stephen", LastName = "Koenig" });
            People.Add(new Person() { Gender = "Male", FirstName = "Brian", LastName = "Koenig" });
        }
    }
}