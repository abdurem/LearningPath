using TaskClass;
using FileOps;

namespace TaskManager{
    class TaskManager_{
        readonly List<Task_> tasks = new (){
            new Task_ {Title = "Task 1", Category = Category.Personal, IsComplete = false},
            new Task_ {Title = "Task 2", Category = Category.Work, IsComplete = false},
            new Task_ {Title = "Task 3", Category = Category.Errands, IsComplete = false},
        };

        public void Display(){
            foreach (var task in tasks){
                Console.WriteLine($"{task.Title} - {task.Category} - {task.IsComplete}");
            }
        }

        public void Add(){
            Console.WriteLine("Enter the title of the task:");
            string? title = Console.ReadLine();

            while (string.IsNullOrEmpty(title)){
                Console.WriteLine("Please enter a valid title:");
                title = Console.ReadLine();
            }

            Console.WriteLine("Enter the category of the task:");
            string? category = Console.ReadLine();

            while (string.IsNullOrEmpty(category) && !Enum.IsDefined(typeof(Category), category)){
                Console.WriteLine("Please enter a valid category:");
                category = Console.ReadLine();
            }
            
            Console.WriteLine("Enter the completion status of the task:");
            string? isComplete = Console.ReadLine();

            while (!bool.TryParse(isComplete, out _)){
                Console.WriteLine("Please enter a valid completion status:");
                isComplete = Console.ReadLine();
            }

            tasks.Add(new Task_ {Title = title, Category = (Category)Enum.Parse(typeof(Category), category), IsComplete = bool.Parse(isComplete)});

            FileOps_ fileSave = new();
            fileSave.Save(tasks);
        }

        public List<Task_> Filter(){
            Console.WriteLine("Enter the category of the task:");
            string? category = Console.ReadLine();

            while (string.IsNullOrEmpty(category) && !Enum.IsDefined(typeof(Category), category)){
                Console.WriteLine("Please enter a valid category:");
                category = Console.ReadLine();
            }

            return tasks.Where(task => task.Category == (Category)Enum.Parse(typeof(Category), category)).ToList();
        }

        public void Delete(){
            Console.WriteLine("Enter the title of the task:");
            string? title = Console.ReadLine();

            while (string.IsNullOrEmpty(title)){
                Console.WriteLine("Please enter a valid title:");
                title = Console.ReadLine();
            }

            tasks.RemoveAll(task => task.Title == title);

            FileOps_ fileSave = new();
            fileSave.Save(tasks);
        }

        public void Update(){
            Console.WriteLine("Enter the title of the task:");
            string? title = Console.ReadLine();

            while (string.IsNullOrEmpty(title)){
                Console.WriteLine("Please enter a valid title:");
                title = Console.ReadLine();
            }

            Console.WriteLine("Enter the new title of the task:");
            string? newTitle = Console.ReadLine();

            while (string.IsNullOrEmpty(newTitle)){
                Console.WriteLine("Please enter a valid title:");
                newTitle = Console.ReadLine();
            }

            Console.WriteLine("Enter the new category of the task:");
            string? category = Console.ReadLine();

            while (string.IsNullOrEmpty(category) && !Enum.IsDefined(typeof(Category), category)){
                Console.WriteLine("Please enter a valid category:");
                category = Console.ReadLine();
            }

            Console.WriteLine("Enter the new completion status of the task:");
            string? isComplete = Console.ReadLine();

            while (!bool.TryParse(isComplete, out _)){
                Console.WriteLine("Please enter a valid completion status:");
                isComplete = Console.ReadLine();
            }

            tasks.RemoveAll(task => task.Title == title);
            tasks.Add(new Task_ {Title = newTitle, Category = (Category)Enum.Parse(typeof(Category), category), IsComplete = bool.Parse(isComplete)});

            FileOps_ fileSave = new();
            fileSave.Save(tasks);
        }
    }
}