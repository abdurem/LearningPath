using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresDb.Models;

public class Blog_ : BaseEntity{
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public List<Comment> Comments { get; set; } = new List<Comment>();
}