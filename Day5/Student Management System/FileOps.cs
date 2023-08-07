using System.Text.Json;

namespace FileOps{
    class FileOps_{
        public static void WriteToJsonFile(string fileName, object data){
            string jsonString = JsonSerializer.Serialize(data);
            File.WriteAllText(fileName, jsonString);
        }
        public static T ReadFromJsonFile<T>(string fileName){
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}