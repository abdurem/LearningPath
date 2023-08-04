namespace Student{
    class Student_<T>{
        public string? Name { get; set; }
        public int Age { get; set; }
        public int RollNo { get; init; }
        public string? Grade { get; set; }
    }

    class StudentList<T>{
        private Student_<T>[] _students;
        private int _count;
        public StudentList(int capacity){
            _students = new Student_<T>[capacity];
            _count = 0;
        }
        public void Add(Student_<T> student){
            _students[_count] = student;
            _count++;
        }
        public Student_<T> Get(int index){
            return _students[index];
        }
        public int Count(){
            return _count;
        }

        public Student_<T> Search(string name){
            
            Student_<T> student = (Student_<T>)(from stud in _students
            where stud.Name == name
            select stud);

            return student;
        }

        public Student_<T> Search(int rollNo){
            
            Student_<T> student = (Student_<T>)(from stud in _students
            where stud.RollNo == rollNo
            select stud);

            return student;
        }
    }
}