namespace HelloWorld{
    class MyGradeCalculator{

        private string name;
        private readonly int numCourses;
        private readonly double[] grades;
        static void Main(string[] args){
            Console.WriteLine("Welcome to Grade Calculator!");
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("Please enter the number of courses: ");
            int numCourses = Convert.ToInt32(Console.ReadLine());

            MyGradeCalculator grade = new (name, numCourses);

            double gpa = grade.CalculateGrade();

            Console.WriteLine("Your GPA is: " + gpa);
        }

        public MyGradeCalculator(string name, int numCourses){
            this.name = name;
            this.numCourses = numCourses;
            this.grades = new double[numCourses];
        }

        public double CalculateGrade(){
            for(int i = 0; i < numCourses; i++){
                Console.WriteLine("Please enter the grade for course " + (i+1) + ": ");
                var grade = Convert.ToInt32(Console.ReadLine());
                if( grade > 100 || grade < 0){
                    Console.WriteLine("Invalid grade. Please enter a valid grade: ");
                    i--;
                    continue;
                }
                else if(grade >= 85){
                    grades[i] = 4;
                }
                else if(grade >= 80){
                    grades[i] = 3.75;
                }
                else if(grade >= 75){
                    grades[i] = 3.5;
                }
                else if(grade >= 70){
                    grades[i] = 3;
                }
                else if(grade >= 65){
                    grades[i] = 2.75;
                }
                else if(grade >= 60){
                    grades[i] = 2.5;
                }
                else if(grade >= 55){
                    grades[i] = 2;
                }
                else if(grade >= 50){
                    grades[i] = 1.75;
                }
                else if(grade >= 45){
                    grades[i] = 1.5;
                }
                else if(grade >= 40){
                    grades[i] = 1;
                }
                else{
                    grades[i] = 0;
                }
            }

            double total = 0;
            for(int i = 0; i < numCourses; i++){
                total += grades[i];
            }

            double gpa = total / numCourses;

            return gpa;
        }
        
    }
}