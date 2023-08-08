
namespace Program;

class Program_{
    static void Main(){
        bool LogedIn = false;
        Console.WriteLine("Hello Blogger");
        if(!LogedIn){
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");

            Console.WriteLine("Choose:");
            string? choose = Console.ReadLine();
            while(string.IsNullOrEmpty(choose) || choose == ""){
                Console.WriteLine("Choose:");
                choose = Console.ReadLine();
            }

            switch(choose){
                case "1":
                    Console.WriteLine("Username:");
                    string? username = Console.ReadLine();
                    while(string.IsNullOrEmpty(username) || username == ""){
                        Console.WriteLine("Username:");
                        username = Console.ReadLine();
                    }

                    Console.WriteLine("Password:");
                    string? password = Console.ReadLine();
                    while(string.IsNullOrEmpty(password) || password == ""){
                        Console.WriteLine("Password:");
                        password = Console.ReadLine();
                    }

                    try{
                        var user = Controller.UserController.CreateUser(username, password);
                        Console.WriteLine(user);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "2":
                    Console.WriteLine("Username:");
                    string? username2 = Console.ReadLine();
                    while(string.IsNullOrEmpty(username2) || username2 == ""){
                        Console.WriteLine("Username:");
                        username2 = Console.ReadLine();
                    }

                    Console.WriteLine("Password:");
                    string? password2 = Console.ReadLine();
                    while(string.IsNullOrEmpty(password2) || password2 == ""){
                        Console.WriteLine("Password:");
                        password2 = Console.ReadLine();
                    }

                    try{
                        var user = Controller.UserController.Login(username2, password2);
                        LogedIn = true;
                        Console.WriteLine(user);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Choose:");
                    choose = Console.ReadLine();
                    break;
            }
        }

        while(LogedIn){
            Console.WriteLine("1. Create Blog");
            Console.WriteLine("2. Get Blog");
            Console.WriteLine("3. Update Blog");
            Console.WriteLine("4. Delete Blog");
            Console.WriteLine("5. Get Blogs");
            Console.WriteLine("6. Get Blogs By User Id");
            Console.WriteLine("7. Get Blogs By Title");
            Console.WriteLine("8. Post Blog");
            Console.WriteLine("9. Exit");
            Console.WriteLine("Choose:");
            string? choose = Console.ReadLine();
            while(string.IsNullOrEmpty(choose) || choose == ""){
                Console.WriteLine("Choose:");
                choose = Console.ReadLine();
            }

            switch(choose){
                case "1":
                    Console.WriteLine("Title:");
                    string? title = Console.ReadLine();
                    while(string.IsNullOrEmpty(title) || title == ""){
                        Console.WriteLine("Title:");
                        title = Console.ReadLine();
                    }

                    Console.WriteLine("Content:");
                    string? content = Console.ReadLine();
                    while(string.IsNullOrEmpty(content) || content == ""){
                        Console.WriteLine("Content:");
                        content = Console.ReadLine();
                    }

                    try{
                        var blog = Controller.BlogController_.CreateBlog(title, content, 1);
                        Console.WriteLine(blog);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }

                    break;
                case "2":
                    Console.WriteLine("Id:");
                    string? id = Console.ReadLine();
                    while(string.IsNullOrEmpty(id) || id == ""){
                        Console.WriteLine("Id:");
                        id = Console.ReadLine();
                    }

                    try{
                        var blog = Controller.BlogController_.GetBlog(int.Parse(id));
                        Console.WriteLine(blog);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }

                    break;
                case "3":
                    Console.WriteLine("Id:");
                    string? id3 = Console.ReadLine();
                    while(string.IsNullOrEmpty(id3) || id3 == ""){
                        Console.WriteLine("Id:");
                        id3 = Console.ReadLine();
                    }

                    Console.WriteLine("Title:");
                    string? title3 = Console.ReadLine();
                    while(string.IsNullOrEmpty(title3) || title3 == ""){
                        Console.WriteLine("Title:");
                        title3 = Console.ReadLine();
                    }

                    Console.WriteLine("Content:");
                    string? content3 = Console.ReadLine();
                    while(string.IsNullOrEmpty(content3) || content3 == ""){
                        Console.WriteLine("Content:");
                        content3 = Console.ReadLine();
                    }

                    try{
                        var blog = Controller.BlogController_.UpdateBlog(int.Parse(id3), title3, content3);
                        Console.WriteLine(blog);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "4":
                    Console.WriteLine("Id:");
                    string? id4 = Console.ReadLine();
                    while(string.IsNullOrEmpty(id4) || id4 == ""){
                        Console.WriteLine("Id:");
                        id4 = Console.ReadLine();
                    }

                    try{
                        var blog = Controller.BlogController_.DeleteBlog(int.Parse(id4));
                        Console.WriteLine(blog);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "5":
                    try{
                        var blogs = Controller.BlogController_.GetBlogs();
                        foreach(var blog in blogs){
                            Console.WriteLine(blog.Title);
                            Console.WriteLine(blog.Content);
                        }
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "6":
                    Console.WriteLine("User Id:");
                    string? userId6 = Console.ReadLine();
                    while(string.IsNullOrEmpty(userId6) || userId6 == ""){
                        Console.WriteLine("User Id:");
                        userId6 = Console.ReadLine();
                    }

                    try{
                        var blogs = Controller.BlogController_.GetBlogsByUserId(int.Parse(userId6));
                        foreach(var blog in blogs){
                            Console.WriteLine(blog);
                        }
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "7":
                    Console.WriteLine("Title:");
                    string? title7 = Console.ReadLine();
                    while(string.IsNullOrEmpty(title7) || title7 == ""){
                        Console.WriteLine("Title:");
                        title7 = Console.ReadLine();
                    }

                    try{
                        var blogs = Controller.BlogController_.GetBlogsByTitle(title7);
                        foreach(var blog in blogs){
                            Console.WriteLine(blog);
                        }
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "8":
                    Console.WriteLine("Title:");
                    string? title8 = Console.ReadLine();
                    while(string.IsNullOrEmpty(title8) || title8 == ""){
                        Console.WriteLine("Title:");
                        title8 = Console.ReadLine();
                    }

                    Console.WriteLine("Content:");
                    string? content8 = Console.ReadLine();
                    while(string.IsNullOrEmpty(content8) || content8 == ""){
                        Console.WriteLine("Content:");
                        content8 = Console.ReadLine();
                    }

                    try{
                        var blog = Controller.UserController.PostBlog(1, title8, content8);
                        Console.WriteLine(blog);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;

                case "9":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Choose:");
                    choose = Console.ReadLine();
                    break;
            }
        }
    }
}