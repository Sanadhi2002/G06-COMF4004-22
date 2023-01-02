<<<<<<< HEAD
﻿using Project_G06.Models;

namespace Project_G06.Data
{
    public class WebApplication2User
    {
        public virtual Class Class { get; set; }
    }
}
=======
﻿using Microsoft.AspNetCore.Identity;
using Project_G06.Models;
using System.Security.Claims;


    public class WebApplication2User : IdentityUser
{
    public virtual UniProfileModel UniProfileModel { get; set; }
}


>>>>>>> b7d6ba65a5b00732853bcca8f995fb93438546b5
