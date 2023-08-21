﻿using SocialMediaApp.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp.Application.DTOs.Comments
{
    public class UpdateCommentDto: BaseDto,ICommentDto
    {
        public int UserId { get; set; }
        public string? Text { get; set; }
        public int PostId { get; set; }
    }
}
