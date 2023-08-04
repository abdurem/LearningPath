using Tasks;

namespace TaskManager{
    class TaskManager{
        public List<Tasks.Task> Tasks {get; set;} = new ();
        private const string _path = "tasks.cvs";

        public void AddTask(Tasks.Task task){
            string? name, description, categorie;

            do{
                Console.Write("Task Name: ");
                name = Console.ReadLine();
            }while(string.IsNullOrEmpty(name));

            do{
                Console.Write("Task Description: ");
                description = Console.ReadLine();
            }while(string.IsNullOrEmpty(description));

            do{
                Console.Write("Task Categorie (Personal, Work, Errands): ");
                categorie = Console.ReadLine();
            }while(string.IsNullOrEmpty(categorie) || !Enum.TryParse(categorie, out Categorie _));

            Tasks.Task newTask = new (){
                Name = name,
                Description = description,
                Categorie = (Categorie)Enum.Parse(typeof(Categorie), categorie),
                IsComplete = false
            };

            Tasks.Add(newTask);

            File_Operations file = new File_Operations();
            
        }
    }   
}