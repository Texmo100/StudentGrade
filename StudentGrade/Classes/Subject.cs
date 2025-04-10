using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade.Classes
{
    public class Subject
    {
        // Data Members
        public string ID { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }


        // Constructor
        public Subject(int id, string name, string description) 
        {
            ID = "SB00" + id;
            Name = name;
            Description = description;
        }

    }
}
