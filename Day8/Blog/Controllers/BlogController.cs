using Microsoft.AspNetCore.Mvc;
using PostgresDb.Models;

namespace Blog.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BlogController : ControllerBase{
    // get blogs from db
    [HttpGet]
    public ActionResult<IEnumerable<Blog_>> Get(){
        using var db = new PgDbContext();
        var blogs = db.Blogs.ToList();
        return blogs;
    }

    // get blog by id
    [HttpGet("{id}")]
    public ActionResult<Blog_> Get(int id){
        using var db = new PgDbContext();
        var blog = db.Blogs.Where(b => b.Id == id).FirstOrDefault();
        return blog;
    }

    // create blog
    [HttpPost]
    public ActionResult<Blog_> Post(Blog_ blog){
        using var db = new PgDbContext();
        db.Blogs.Add(blog);
        db.SaveChanges();
        return blog;
    }

    // update blog
    [HttpPut("{id}")]
    public ActionResult<Blog_> Put(int id, Blog_ blog){
        using var db = new PgDbContext();
        var blogUpdate = db.Blogs.Where(b => b.Id == id).FirstOrDefault();
        blogUpdate.Title = blog.Title;
        blogUpdate.Content = blog.Content;
        db.SaveChanges();
        return blogUpdate;
    }

    // delete blog
    [HttpDelete("{id}")]
    public ActionResult<Blog_> Delete(int id){
        using var db = new PgDbContext();
        var blogDelete = db.Blogs.Where(b => b.Id == id).FirstOrDefault();
        db.Blogs.Remove(blogDelete);
        db.SaveChanges();
        return blogDelete;
    }
}