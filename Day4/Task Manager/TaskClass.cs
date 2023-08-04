namespace TaskClass{

    public enum Category{
        Personal,
        Work,
        Errands
    }
    class Task_{
        public string? Title {get; set;}
        public Category Category {get; set;}
        public bool IsComplete {get; set;}
    }
}