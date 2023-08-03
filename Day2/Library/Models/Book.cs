namespace LibraryItems{
    class Book{
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, string author, string isbn, int publicationYear){
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
        }
    }

    class MediaItem{

        private string? format;
        public string? Title { get; set; }
        public string Format {
            get{
                if (format == null){
                    return "Unknown";
                }
                return format;
            }
            set{
                if(value == "CD" || value == "DVD"){
                    format = value;
                }else{
                    throw new System.ArgumentException("Format must be CD or DVD");
                }
            }
        }
        public int Duration { get; set; }

        public MediaItem(string title, string format, int duration){
            Title = title;
            Format = format;
            Duration = duration;
        }
    }
}