using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace List
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private string firstName;
        public string FirstName
        {
            get => firstName;
            set { firstName = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstName")); }
        }

        private string lastName;
        public string LastName
        {
            get => lastName;
            set { lastName = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LastName"));}
        }

        private string birthDate;
        public string BirthDate
        {
            get => birthDate;
            set { birthDate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BirthDate")); }
        }

        private string personIDNumber;
        public string PersonIDNumber
        {
            get => personIDNumber;
            set { personIDNumber = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PersonIDNumber")); }
        }

        public static ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        public static void PeopleList()
        {
            People.Add(new Person
            {
                FirstName = "Jakub",
                LastName = "Richtár",
                BirthDate = "9.9.2002",
                PersonIDNumber = "020909/0277"
            });

            People.Add(new Person
            {
                FirstName = "Bambula",
                LastName = "Kořínek",
                BirthDate = "16.5.2015",
                PersonIDNumber = "151605/5426"
            });

            People.Add(new Person
            {
                FirstName = "Jan",
                LastName = "Novák",
                BirthDate = "1.1.2000",
                PersonIDNumber = "000101/5188"
            });
        }
    }
}
