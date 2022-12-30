using Microsoft.AspNetCore.Identity;

namespace Project_G06.Models
{
    public class ApplicationUser:IdentityUser
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public virtual UniProfileModel UniProfileModel { get; set; }

    }
}
