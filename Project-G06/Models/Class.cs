<<<<<<< HEAD
﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Project_G06.Areas.Identity.Data;
=======
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


>>>>>>> 6940dc56baee2492cc030d4f72fa69340d3bcae2

namespace Project_G06.Models
{
    public class Class
    {
<<<<<<< HEAD
        [Key,ForeignKey("WebApplication2User")]
        public string UserId { get; set; }
        public string? Uniname { get; set; } 
        public string? UniFullname{ get; set; }
=======
        [Key, ForeignKey("WebApplication2User")]
        public string UserId { get; set; }
        public string? Uniname { get; set; }
        public string? UniFullname { get; set; }
>>>>>>> 6940dc56baee2492cc030d4f72fa69340d3bcae2
        public string? ProfilPic_URL { get; set; }
        [NotMapped]
        public IFormFile UploadedProfilePic { get; set; }
        //public string UserId { get; set; }
        public virtual WebApplication2User WebApplication2User { get; set; }
    }
}
