﻿using SocialMediaApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp.Domain;

public class Comment : BaseEntity
{
    public int UserId { get; set; }
    public int PostId { get; set; }
    public string? Text { get; set; }
}
