using FileOps;

namespace Student{
    class Student_{
        public string? Name { get; set; }
        public int RollNo { get; set; }
        public int Age { get; set; }
        public char? Grade {get; set;}
    }

    class StudentList<T>{
        public T[] Students { get; set; }

        public StudentList(T[] students){
            Students = students;
        }

        public void Print(){
            foreach(T student in Students){
                Console.WriteLine(student);
            }
        }

        public void WriteToFile(string fileName){
            FileOps_.WriteToJsonFile(fileName, this);
        }

        public static StudentList<T> ReadFromFile(string fileName){
            return FileOps_.ReadFromJsonFile<StudentList<T>>(fileName);
        }

        public static Student_ GetBestStudent(Student_[] students){
            Student_ bestStudent = students.OrderByDescending(student => student.Grade).First();

            return bestStudent;
        }

        public static Student_ GetWorstStudent(Student_[] students){
            Student_ worstStudent = students.OrderBy(student => student.Grade).First();

            return worstStudent;
        }

        public static Student_ GetOldestStudent(Student_[] students){
            Student_ oldestStudent = students.OrderByDescending(student => student.Age).First();

            return oldestStudent;
        }

        public static Student_ GetYoungestStudent(Student_[] students){
            Student_ youngestStudent = students.OrderBy(student => student.Age).First();

            return youngestStudent;
        }

        public static Student_ GetHighestRollNoStudent(Student_[] students){
            Student_ highestRollNoStudent = students.OrderByDescending(student => student.RollNo).First();

            return highestRollNoStudent;
        }

        public static Student_ GetLowestRollNoStudent(Student_[] students){
            Student_ lowestRollNoStudent = students.OrderBy(student => student.RollNo).First();

            return lowestRollNoStudent;
        }
    }
}