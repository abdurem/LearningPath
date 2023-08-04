namespace Tasks{

    public enum Categorie{
        Personal,
        Work,
        Errands
    }

    public class Task{
        public string? Name {get; set;}
        public string? Description {get; set;}
        public Categorie Categorie {get; set;}
        public bool IsComplete {get; set;}
    }
}