using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade.Classes
{
    public class Student
    {
        // Data Members
        public string ID { get; private set; }
        public string FirstName { get; private set;  }
        public string LastName { get; private set; }
        public string FullName { get => FirstName + " " + LastName;  }


        // Constructor
        public Student(int id, string firstName, string lastName)
        {
            ID = "ST00" + id;
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
