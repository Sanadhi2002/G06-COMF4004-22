using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Project_G06.Models;

namespace Project_G06.Areas.Identity.Data;

// Add profile data for application users by adding properties to the WebApplication2User class
public class WebApplication2User : IdentityUser
{
    public virtual Class Class { get; set; }
}

