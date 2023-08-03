using Librarys;
using LibraryItems;

namespace Program{
    class Program{
        public static void Main(){
            Book[] books = new Book[5]; 
            
            books[0] = new Book("The Fellowship of the Ring", "J.R.R. Tolkien", "978-0547928210", 1954);
            books[1] = new Book("The Two Towers", "J.R.R. Tolkien", "978-0547928203", 1954);
            books[2] = new Book("The Return of the King", "J.R.R. Tolkien", "978-0547928197", 1955);
            books[3] = new Book("The Hobbit", "J.R.R. Tolkien", "978-0547928227", 1937);
            books[4] = new Book("The Silmarillion", "J.R.R. Tolkien", "978-0547928227", 1977);

            MediaItem[] mediaItems = new MediaItem[5];

            mediaItems[0] = new MediaItem("The Fellowship of the Ring", "DVD", 178);
            mediaItems[1] = new MediaItem("The Two Towers", "DVD", 179);
            mediaItems[2] = new MediaItem("The Return of the King", "DVD", 201);
            mediaItems[3] = new MediaItem("The Hobbit", "DVD", 169);
            mediaItems[4] = new MediaItem("The Silmarillion", "DVD", 0);

            Library library = new ("Abrihot", "123 Fake Street", books, mediaItems);

            Console.WriteLine("Welcome to the Abrihot Library Cataloge!");
            Console.WriteLine("Please enter a command:");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Add a media item");
            Console.WriteLine("3. Remove a book");
            Console.WriteLine("4. Remove a media item");
            Console.WriteLine("5. List Cateloge");
            Console.WriteLine("6. Exit");


            while(true){   

                Console.Write("Please enter a command: ");
                string? input = Console.ReadLine();
                switch (Convert.ToInt32(input)){
                    case 1:
                        Console.WriteLine("Please enter the title of the book:");
                        string? title = Console.ReadLine();

                        
                        while (title == null || title == ""){
                            Console.WriteLine("Please enter the title of the book:");
                            title = Console.ReadLine();
                        }

                        Console.WriteLine("Please enter the author of the book:");
                        string? author = Console.ReadLine();

                        while (author == null || author == ""){
                            Console.WriteLine("Please enter the author of the book:");
                            author = Console.ReadLine();
                        }

                        Console.WriteLine("Please enter the ISBN of the book:");
                        string? isbn = Console.ReadLine();

                        while (isbn == null || isbn == ""){
                            Console.WriteLine("Please enter the ISBN of the book:");
                            isbn = Console.ReadLine();
                        }

                        Console.WriteLine("Please enter the publication year of the book:");
                        int publicationYear = Convert.ToInt32(Console.ReadLine());

                        Book book = new (title, author, isbn, publicationYear);
                        library.AddBook(book);
                        
                        break;
                    
                    case 2:
                        Console.WriteLine("Please enter the title of the media item:");
                        string? mediaTitle = Console.ReadLine();

                        while (mediaTitle == null || mediaTitle == ""){
                            Console.WriteLine("Please enter the title of the media item:");
                            mediaTitle = Console.ReadLine();
                        }

                        Console.WriteLine("Please enter the format of the media item:");
                        string? format = Console.ReadLine();

                        while (format == null || format == ""){
                            Console.WriteLine("Please enter the format of the media item:");
                            format = Console.ReadLine();
                        }

                        Console.WriteLine("Please enter the duration of the media item:");
                        int duration = Convert.ToInt32(Console.ReadLine());

                        MediaItem mediaItem = new (mediaTitle, format, duration);
                        library.AddMediaItem(mediaItem);

                        break;
                    
                    case 3:
                        Console.WriteLine("Please enter the title of the book you would like to remove:");
                        string? removeTitle = Console.ReadLine();

                        while (removeTitle == null || removeTitle == ""){
                            Console.WriteLine("Please enter the title of the book you would like to remove:");
                            removeTitle = Console.ReadLine();
                        }

                        library.RemoveBook(library.Books[Array.FindIndex(library.Books, book => book.Title == removeTitle)]);
                        
                        break;
                    
                    case 4:
                        Console.WriteLine("Please enter the title of the media item you would like to remove:");
                        string? removeMediaTitle = Console.ReadLine();

                        while (removeMediaTitle == null || removeMediaTitle == ""){
                            Console.WriteLine("Please enter the title of the media item you would like to remove:");
                            removeMediaTitle = Console.ReadLine();
                        }

                        library.RemoveMediaItem(library.MediaItems[Array.FindIndex(library.MediaItems, mediaItem => mediaItem.Title == removeMediaTitle)]);
                        
                        break;
                    
                    case 5:
                        Console.WriteLine(library.Cataloge());
                        break;
                    
                    case 6:
                        Environment.Exit(0);
                        break;
                    
                    default:
                        Console.WriteLine("Please enter a valid command");
                        break;
                }
            }

        }
    }
}