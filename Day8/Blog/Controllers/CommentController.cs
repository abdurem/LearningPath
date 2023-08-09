using Microsoft.AspNetCore.Mvc;
using PostgresDb.Models;

namespace Blog.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CommentController : ControllerBase{
    // create comment
    [HttpPost]
    public ActionResult<Comment> Post(Comment comment){
        using var db = new PgDbContext();
        db.Comments.Add(comment);
        db.SaveChanges();
        return comment;
    }

    // update comment
    [HttpPut("{id}")]
    public ActionResult<Comment> Put(int id, Comment comment){
        using var db = new PgDbContext();
        var commentUpdate = db.Comments.Where(c => c.Id == id).FirstOrDefault();
        commentUpdate.Content = comment.Content;
        db.SaveChanges();
        return commentUpdate;
    }

    // delete comment
    [HttpDelete("{id}")]
    public ActionResult<Comment> Delete(int id){
        using var db = new PgDbContext();
        var commentDelete = db.Comments.Where(c => c.Id == id).FirstOrDefault();
        db.Comments.Remove(commentDelete);
        db.SaveChanges();
        return commentDelete;
    }

    // get comments
    [HttpGet]
    public ActionResult<IEnumerable<Comment>> Get(){
        using var db = new PgDbContext();
        var comments = db.Comments.ToList();
        return comments;
    }

    // get comment by id
    [HttpGet("{id}")]
    public ActionResult<Comment> Get(int id){
        using var db = new PgDbContext();
        var comment = db.Comments.Where(c => c.Id == id).FirstOrDefault();
        return comment;
    }

    // get comment by blog id
    [HttpGet("blog/{id}")]
    public ActionResult<IEnumerable<Comment>> GetByBlogId(int id){
        using var db = new PgDbContext();
        var comments = db.Comments.Where(c => c.BlogId == id).ToList();
        return comments;
    }

    // get comment by user id
    [HttpGet("user/{id}")]
    public ActionResult<IEnumerable<Comment>> GetByUserId(int id){
        using var db = new PgDbContext();
        var comments = db.Comments.Where(c => c.UserId == id).ToList();
        return comments;
    }
}
