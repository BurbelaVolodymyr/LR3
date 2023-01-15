﻿using System;
using System.Collections.Generic;

namespace LR3.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Resort> Resorts { get; } = new List<Resort>();
}
