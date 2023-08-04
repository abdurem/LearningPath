using TaskClass;

namespace FileOps{
    class FileOps_{
        private readonly string _path = "tasks.cvs";

        public void Save(List<Task_> tasks){
            using StreamWriter sw = new(_path);
            foreach (var task in tasks)
            {
                sw.WriteLine($"{task.Title},{task.Category},{task.IsComplete}");
            }
        }

        public List<Task_> Load(){
            List<Task_> tasks = new();
            using StreamReader sr = new(_path);
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] values = line.Split(',');
                tasks.Add(new Task_ {Title = values[0], Category = (Category)Enum.Parse(typeof(Category), values[1]), IsComplete = bool.Parse(values[2])});
            }
            return tasks;
        }

        public void Delete(){
            File.Delete(_path);
        }

        public bool Exists(){
            return File.Exists(_path);
        }

    }
}