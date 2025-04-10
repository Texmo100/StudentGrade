using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade.Classes
{
    public class Grade
    {
        // Data Members
        public string ID { get; private set; }
        public string SubjectId { get; }
        public string StudentId { get; }
        public float StudentGrade { get; set; }

        // Constructor
        public Grade(int id, string subjectId, string studentId, float studentGrade)
        {
            ID = "G00" + id;
            SubjectId = subjectId;
            StudentId = studentId;
            StudentGrade = studentGrade;
        }
    }
}
