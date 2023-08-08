using PostgresDb.Models;

namespace Controller;

class UserController{
    public static string CreateUser(string name, string password){
        var user = new User{
            Username = name,
            Password = password
        };

        using var db = new PgDbContext();
        db.User.Add(user);
        db.SaveChanges();

        return "user created";
    }

    public static string Login(string name, string password){
        using var db = new PgDbContext();
        var user = db.User.FirstOrDefault(u => u.Username == name && u.Password == password) ?? throw new Exception("user not found");
        return "login success as " + user.Id;
    }

    public static User GetUser(int id){
        using var db = new PgDbContext();
        var user = db.User.Find(id) ?? throw new Exception("user not found");
        return user;
    }

    public static Blog_ PostBlog(int userId, string title, string content){
        var blog = new Blog_{
            Title = title,
            Content = content,
            UserId = userId
        };

        using var db = new PgDbContext();
        db.Blogs.Add(blog);
        db.SaveChanges();

        return blog;
    }

    public static List<Blog_> GetBlogsByUserId(int userId){
        using var db = new PgDbContext();
        var blogs = db.Blogs.Where(b => b.UserId == userId).ToList();
        return blogs;
    }

    public static string UpdateBlog(int id, string title, string content){
        using var db = new PgDbContext();
        var blog = db.Blogs.Find(id) ?? throw new Exception("blog not found");
        blog.Title = title;
        blog.Content = content;
        db.SaveChanges();
        return "blog updated";
    }

    public static string DeleteBlog(int id){
        using var db = new PgDbContext();
        var blog = db.Blogs.Find(id) ?? throw new Exception("blog not found");
        db.Blogs.Remove(blog);
        db.SaveChanges();
        return "blog deleted";
    }

    public static List<Blog_> GetBlogs(){
        using var db = new PgDbContext();
        var blogs = db.Blogs.ToList();
        return blogs;
    }
}