using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresDb.Models;

public class Comment : BaseEntity{
    public string Content { get; set; } = "";
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int BlogId { get; set; }
    public Blog_ Blog { get; set; } = null!;
}