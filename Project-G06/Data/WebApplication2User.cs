using Microsoft.AspNetCore.Identity;
using Project_G06.Models;
using System.Security.Claims;


    public class WebApplication2User : IdentityUser
{
        public virtual Class Class { get; set; }
    }


