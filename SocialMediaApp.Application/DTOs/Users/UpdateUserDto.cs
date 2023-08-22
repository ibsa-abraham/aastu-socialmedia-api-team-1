using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Application.DTOs.Users
{
    public class UpdateUserDto: UserDto, IUserDto
    {
    public int Id {get; set;}
    public string Name { get; set; }
    public string Bio { get; set; }
    }
}