using System;
using System.Collections.Generic;

namespace LR3.Models;

public partial class Client
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public int CardId { get; set; }

    public int? PhoneNumber { get; set; }

    public virtual ICollection<Ordering> Orderings { get; } = new List<Ordering>();
}
