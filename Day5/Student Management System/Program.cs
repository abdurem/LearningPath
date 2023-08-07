using Student;

namespace Program{
    class Program_{
        public static void Main(){
            Student_[] students = new Student_[]{
                new Student_{
                    Name = "John",
                    RollNo = 1,
                    Age = 20,
                    Grade = 'A'
                },
                new Student_{
                    Name = "Jane",
                    RollNo = 2,
                    Age = 19,
                    Grade = 'B'
                },
                new Student_{
                    Name = "Jack",
                    RollNo = 3,
                    Age = 21,
                    Grade = 'C'
                },
                new Student_{
                    Name = "Jill",
                    RollNo = 4,
                    Age = 18,
                    Grade = 'D'
                }
            };

            StudentList<Student_> studentList = new StudentList<Student_>(students);

            studentList.Print();

            studentList.WriteToFile("students.json");

            StudentList<Student_> studentListFromFile = StudentList<Student_>.ReadFromFile("students.json");

            studentListFromFile.Print();

            Student_ bestStudent = StudentList<Student_>.GetBestStudent(students);
            Console.WriteLine($"Best Student: {bestStudent.Name}");

            Student_ worstStudent = StudentList<Student_>.GetWorstStudent(students);
            Console.WriteLine($"Worst Student: {worstStudent.Name}");

            Student_ oldestStudent = StudentList<Student_>.GetOldestStudent(students);
            Console.WriteLine($"Oldest Student: {oldestStudent.Name}");

            Student_ youngestStudent = StudentList<Student_>.GetYoungestStudent(students);
            Console.WriteLine($"Youngest Student: {youngestStudent.Name}");

            Student_ highestRollNoStudent = StudentList<Student_>.GetHighestRollNoStudent(students);
            Console.WriteLine($"Highest Roll No Student: {highestRollNoStudent.Name}");
        }
    }
}