using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PostgresDb.Models;

namespace Blog.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UserController : ControllerBase{
    [HttpGet]
    // get users from db
    public ActionResult<IEnumerable<User>> Get(){
        using (var db = new PgDbContext()){
            var users = db.User.ToList();
            return users;
        }
    }

    // login user
    [HttpPost("login")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
    public ActionResult<User> Login(User user){
        using (var db = new PgDbContext()){
            var userLogin = db.User.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
            return Ok(userLogin);
        }
    }

    // create user
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(User))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ModelStateDictionary))]
    public ActionResult<User> Post(User user){
        using (var db = new PgDbContext()){
            db.User.Add(user);
            db.SaveChanges();
            return user;
        }
    }


}