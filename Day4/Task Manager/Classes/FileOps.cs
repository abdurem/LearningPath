using System;

namespace TaskManager
{
    class FileOps
    {
        const string FilePath = "tasks.csv";
        
        // Load tasks from file
        public async Task LoadTasksAsync(Tasks.Task taskManager)
        {
            try
            {
                // Check if file exists
                if (File.Exists(FilePath))
                {
                    string[] lines = await File.ReadAllLinesAsync(FilePath);

                    // Read each line and create a task object
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        
                        // Check if the line has 4 parts
                        if (parts.Length == 4)
                        {
                            Tasks.Categorie categorie = new ();
                            
                            // Check if the category is valid
                            if (Enum.TryParse(parts[2], out categorie))
                            {

                                // Check if the IsComplete value is valid
                                if (bool.TryParse(parts[3], out bool isComplete))
                                {
                                    Tasks.Task task = new()
                                    {
                                        Name = parts[0],
                                        Description = parts[1],
                                        Categorie = categorie,
                                        IsComplete = isComplete
                                    };

                                    taskManager.tasks.Add(task);
                                }
                                else
                                {
                                    Console.WriteLine($"Error parsing 'IsComplete' value: {parts[3]}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Error parsing 'Category' value: {parts[2]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Invalid line format: {line}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading tasks: {ex.Message}");
            }
        }


        // Save tasks to file
        public void SaveTasks(Tasks.Task taskManager)
        {
            // Check if there are any tasks
            if (taskManager.tasks.Count == 0)
            {
                return;
            }

            // Create a new file or overwrite the existing file
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (Tasks.Task task in taskManager.tasks)
                {
                    // Create a line with task details
                    string line = $"{task.Name},{task.Description},{task.Category},{task.IsComplete}";
                    writer.WriteLine(line);
                }
            }
        }
        
    }
}