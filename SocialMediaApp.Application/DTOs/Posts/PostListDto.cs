﻿using SocialMediaApp.Application.DTOs.Common;
using SocialMediaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp.Application.DTOs.Posts
{
    public class PostListDto : BaseDto
    {
        public int UserId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public List<Like>? Like { get; set; }
        public List<String>? HashTag { get; set; }


    }
}