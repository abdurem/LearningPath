using TaskManager;

namespace Program{
    class Program_{
        public static void Main(){
            TaskManager_ taskManager = new();
            taskManager.Display();
            taskManager.Add();
            taskManager.Display();
            taskManager.Filter();
        }
    }
}