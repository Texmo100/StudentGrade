using StudentGrade.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade.Utils
{
    public static class GradeUtils
    {
        public static float CalculateAverageGradeForStudent(List<Grade> grades, string studentId)
        {
            List<Grade> studentGrades = grades.Where(grade => grade.StudentId == studentId).ToList();

            if (studentGrades == null)
            {
                return 0;
            }

            float averageGrade = 0;

            foreach (Grade grade in studentGrades)
            {
                averageGrade += grade.StudentGrade;
            }

            return averageGrade / studentGrades.Count;
        }

        public static void DisplaySubjects(List<Subject> subjects)
        {
            Console.WriteLine("----------------------------");
            foreach (Subject sb in subjects)
            {
                Console.WriteLine($"{sb.ID}: {sb.Name} - {sb.Description}");
            }
            Console.WriteLine("----------------------------");
        }

        public static void DisplayStudents(List<Student> students)
        {
            Console.WriteLine("----------------------------");
            foreach (Student st in students)
            {
                Console.WriteLine($"{st.ID}: {st.FullName}");
            }
            Console.WriteLine("----------------------------");
        }

        public static void DisplayGrades(List<Grade> grades)
        {
            Console.WriteLine("----------------------------");
            foreach (Grade grade in grades)
            {
                Console.WriteLine($"{grade.SubjectId}: {grade.StudentId} => {grade.StudentGrade}");
            }
            Console.WriteLine("----------------------------");
        }

    }
}
