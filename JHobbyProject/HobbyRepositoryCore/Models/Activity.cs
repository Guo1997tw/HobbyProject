﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HobbyRepositoryCore.Models;

public partial class Activity
{
    public string Id { get; set; }

    public string MemberId { get; set; }

    public int CategoryId { get; set; }

    public int ActivityImageId { get; set; }

    public string Name { get; set; }

    public DateTime Created { get; set; }

    public DateTime? ActivityDeadline { get; set; }

    public string ActivityLocation { get; set; }

    public string CategoryCity { get; set; }

    public string CategoryArea { get; set; }

    public string ActivityNotes { get; set; }

    public int? MaxPeople { get; set; }

    public int? CurrentPeople { get; set; }

    public decimal JoinFee { get; set; }

    public string Payment { get; set; }

    public virtual ActivityImage ActivityImage { get; set; }

    public virtual ICollection<ActivityUser> ActivityUsers { get; set; } = new List<ActivityUser>();

    public virtual Category Category { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Wish> Wishes { get; set; } = new List<Wish>();
}