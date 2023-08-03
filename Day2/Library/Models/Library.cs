using LibraryItems;

namespace Librarys{
    class Library{
    public string Name { get; set; }
    public string Address { get; set; }
    public Book[] Books { get; set; }
    public MediaItem[] MediaItems { get; set; }

    public Library(string name, string address, Book[] books, MediaItem[] mediaItems){
        Name = name;
        Address = address;
        Books = books;
        MediaItems = mediaItems;
    }

    public void AddBook(Book book){
        Book[] newBooks = new Book[Books.Length + 1];
        for(int i = 0; i < Books.Length; i++){
            newBooks[i] = Books[i];
        }
        newBooks[Books.Length] = book;
        Books = newBooks;
    }

    public void AddMediaItem(MediaItem mediaItem){
        MediaItem[] newMediaItems = new MediaItem[MediaItems.Length + 1];
        for(int i = 0; i < MediaItems.Length; i++){
            newMediaItems[i] = MediaItems[i];
        }
        newMediaItems[MediaItems.Length] = mediaItem;
        MediaItems = newMediaItems;
    }

    public void RemoveBook(Book book){
        Book[] newBooks = new Book[Books.Length - 1];
        int j = 0;
        for(int i = 0; i < Books.Length; i++){
            if(Books[i] != book){
                newBooks[j] = Books[i];
                j++;
            }
        }
        
        if (j == Books.Length){
            throw new System.ArgumentException("Book not found");
        }

        Books = newBooks;
    }

    public void RemoveMediaItem(MediaItem mediaItem){
        MediaItem[] newMediaItems = new MediaItem[MediaItems.Length - 1];
        int j = 0;
        for(int i = 0; i < MediaItems.Length; i++){
            if(MediaItems[i] != mediaItem){
                newMediaItems[j] = MediaItems[i];
                j++;
            }
        }

        if (j == MediaItems.Length){
            throw new System.ArgumentException("Media item not found");
        }

        MediaItems = newMediaItems;
    }

    public string Cataloge(){
        string cataloge = "";
        foreach(Book book in Books){
            cataloge += $"Book: {book.Title} by {book.Author} ({book.PublicationYear})\n";
        }
        
        cataloge += "\n";
        foreach(MediaItem mediaItem in MediaItems){
            cataloge += $"Media Item: {mediaItem.Title} ({mediaItem.Format})\n";
        }
        return cataloge;
    }
}
}
