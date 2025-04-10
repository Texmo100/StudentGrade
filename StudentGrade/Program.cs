using StudentGrade.Classes;
using StudentGrade.Utils;

namespace StudentGrade
{
    public class Showcase
    {
        public static void Main(string[] args)
        {
            // Subjects available
            List<Subject> subjects = new List<Subject>()
            {
                new Subject(1, "Linear Algebra", "Working with vectors and matrices"),
                new Subject(2, "Geometry", "Working with shapes and planes"),
                new Subject(3, "Calculus", "Working with sophisticated equations")
            };

            // Students in college
            List<Student> students = new List<Student>();

            // Grades
            List<Grade> grades = new List<Grade>();

            MenuExecutor(subjects, students, grades);

        }

        // Functions
        public static void MenuExecutor(List<Subject> subjects, List<Student> students, List<Grade> grades)
        {
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("                    MENU                     ");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("[type exit] Exit");
                Console.WriteLine("[1] Add Students");
                if (students.Count > 0)
                {
                    Console.WriteLine("[2] Assign student to subject");
                    Console.WriteLine("[3] Add grade");
                    Console.WriteLine("[4] Calculate average");
                    Console.WriteLine("[5] Display Student records with their grades");
                }
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("\n");

                string option = HelperUtils.StringWriter("option: ");

                if (students.Count > 0)
                {
                    switch (option)
                    {
                        case "1":
                            AddStudents(students);
                            break;
                        case "2":
                            AddStudentToSubject(subjects, students, grades);
                            break;
                        case "3":
                            AddGradeToStudentSubject(subjects, grades);
                            break;
                        case "4":
                            DisplayAverageGradeForStudent(students, grades);
                            break;
                        case "5":
                            GradeUtils.DisplayGrades(grades);
                            break;
                        default:
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine(" Please enter a valid option ");
                            Console.WriteLine("-----------------------------");
                            break;
                    }
                }
                else
                {
                    switch (option)
                    {
                        case "1":
                            AddStudents(students);
                            break;
                        default:
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine(" Please enter a valid option ");
                            Console.WriteLine("-----------------------------");
                            break;
                    }
                }
            }
        }

        public static void AddStudents(List<Student> students)
        {
            do
            {
                string studentFirstName = HelperUtils.StringWriter("firstname ");
                if (studentFirstName == "0") break;

                string studentLastName = HelperUtils.StringWriter("lastname: ");
                if (studentLastName == "0") break;

                students.Add(new Student(students.Count + 1, studentFirstName, studentLastName));
                break;
            } while (true);
        }

        public static void AddStudentToSubject(List<Subject> subjects, List<Student> students, List<Grade> grades)
        {
            do 
            {
                GradeUtils.DisplaySubjects(subjects);
                string selectedSubjectId = HelperUtils.StringWriter("Id of the subject: ");
                if(selectedSubjectId == "0") break;
                Subject selectedSubject = subjects.Where(subject => subject.ID == selectedSubjectId).First();
                if (selectedSubject == null)
                {
                    Console.WriteLine("Subject does not exist: Please select a valid one");
                    continue;
                }

                GradeUtils.DisplayStudents(students);
                string selectedStudentId = HelperUtils.StringWriter("Id of the student: ");
                if (selectedStudentId == "0") break;
                Student selectedStudent = students.Where(student => student.ID == selectedStudentId).First();
                if (selectedStudent == null)
                {
                    Console.WriteLine("Student does not exist: Please select a valid one");
                    continue;
                }

                grades.Add(new Grade(grades.Count + 1, selectedSubject.ID, selectedStudent.ID, 0));
                break;

            } while(true);
        }

        public static void AddGradeToStudentSubject(List<Subject> subjects, List<Grade> grades)
        {
            do
            {
                GradeUtils.DisplaySubjects(subjects);
                string selectedSubjectId = HelperUtils.StringWriter("Id of the subject: ");
                if (selectedSubjectId == "0") break;
                Subject selectedSubject = subjects.Where(c => c.ID == selectedSubjectId).First();
                if (selectedSubject == null)
                {
                    Console.WriteLine("Subject does not exist: Please select a valid one");
                    continue;
                }

                List<Grade> gradesInSubject = grades.Where(grade => grade.SubjectId == selectedSubjectId).ToList();
                
                GradeUtils.DisplayGrades(gradesInSubject);
                string selectedStudentId = HelperUtils.StringWriter("Id of the student: ");
                if (selectedStudentId == "0") break;
                Grade selectedStudentGrade = gradesInSubject.Where(grade => grade.StudentId == selectedStudentId).First();
                if (selectedStudentGrade == null)
                {
                    Console.WriteLine("Student does not exist: Please select a valid one");
                    continue;
                }

                float newStudentGrade = HelperUtils.FloatWriter("grade: ");
                selectedStudentGrade.StudentGrade = newStudentGrade;
                break;

            } while (true);
        }

        public static void DisplayAverageGradeForStudent(List<Student> students, List<Grade> grades)
        {
            do
            {
                GradeUtils.DisplayStudents(students);
                string selectedStudentId = HelperUtils.StringWriter("Id of the student: ");
                if (selectedStudentId == "0") break;

                float studentAverageGrade = GradeUtils.CalculateAverageGradeForStudent(grades, selectedStudentId);
                if (studentAverageGrade > 0)
                {
                    Console.WriteLine($"Average grade for - {selectedStudentId} : {studentAverageGrade}");
                }
                else 
                {
                    Console.WriteLine("The calculation returns 0: This is because the student has no grade assigned yet or the provided ID was not correct");
                }

                break;

            } while(true);

        }

    }
}