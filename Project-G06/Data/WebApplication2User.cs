using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Project_G06.Data
{
}
    public class WebApplication2User : IdentityUser
{
        public virtual Class Class { get; set; }
    }
}
}
