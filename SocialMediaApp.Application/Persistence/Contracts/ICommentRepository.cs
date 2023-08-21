﻿using SocialMediaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp.Application.Persistence.Contracts;

public interface ICommentRepository : IGenericRepository<Comment>
{
    Task<List<Comment>> GetCommentsByPostId(int postId);
    Task<Comment> GetCommentById(int postId);

}
