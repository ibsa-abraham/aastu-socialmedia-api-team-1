﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp.Application.Features.Notifications.Request.Commands;

public class DeleteNotificationRequest : IRequest<Unit>
{
    public int UserId { get; set; }
    public int NotificationId { get; set; }
}