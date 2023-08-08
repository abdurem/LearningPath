using PostgresDb.Models;

namespace Controller;

class BlogController_{
    public static string CreateBlog(string title, string content, int userId){
        var blog = new Blog_{
            Title = title,
            Content = content,
            UserId = userId
        };

        using var db = new PgDbContext();
        db.Blogs.Add(blog);
        db.SaveChanges();

        return "blog created";
    }

    public static Blog_ GetBlog(int id){
        using var db = new PgDbContext();
        var blog = db.Blogs.Find(id) ?? throw new Exception("blog not found");
        return blog;
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

    public static List<Blog_> GetBlogsByUserId(int userId){
        using var db = new PgDbContext();
        var blogs = db.Blogs.Where(b => b.UserId == userId).ToList();
        return blogs;
    }

    public static List<Blog_> GetBlogsByTitle(string title){
        using var db = new PgDbContext();
        var blogs = db.Blogs.Where(b => b.Title == title).ToList();
        return blogs;
    }
}

