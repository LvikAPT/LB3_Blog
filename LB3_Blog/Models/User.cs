﻿using System;
using System.Collections.Generic;
using LB3_Blog.Models;

namespace LB3_Blog;

public partial class User
{
    public int Id { get; set; }

    public string Nickname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public DateOnly? Birthday { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}