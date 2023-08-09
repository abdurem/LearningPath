using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresDb.Models;

public class BaseEntity{
    public int Id { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
}