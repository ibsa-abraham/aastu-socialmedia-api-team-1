﻿using AutoMapper;
using SocialMediaApp.Application.DTOs.Comments;
using SocialMediaApp.Application.DTOs.Follows;
using SocialMediaApp.Application.DTOs.Likes;
using SocialMediaApp.Application.DTOs.Notifications;
using SocialMediaApp.Application.DTOs.Posts;
using SocialMediaApp.Application.DTOs.Users;
using SocialMediaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        #region User
        CreateMap<User, UserDto>().ReverseMap();
        #endregion User

        #region Post
        CreateMap<Post, PostDto>().ReverseMap();
        #endregion Post

        #region Comment
        CreateMap<Comment, CommentDto>().ReverseMap();
        #endregion Comment

        #region Like
        CreateMap<Like, LikeDto>().ReverseMap();
        #endregion Like

        #region Follow
        CreateMap<Follow, FollowDto>().ReverseMap();
        #endregion Follow

        #region Notification
        CreateMap<Notification, NotificationDto>().ReverseMap();
        CreateMap<Notification, CreateNotificationDto>().ReverseMap();
        #endregion Notification
    }
}
