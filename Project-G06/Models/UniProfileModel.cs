using Project_G06.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_G06.Models
{
    public class UniProfileModel
    {
        [Key, ForeignKey("WebApplication2User")]
        public string UserId { get; set; }
        public string? UniShortname { get; set; }
        public string? UniFullname { get; set; }
        public string? UniDetails { get; set; }
        public string? ProfilPic_URL { get; set; }
        [NotMapped]
        public IFormFile UploadedProfilePic { get; set; }
        //public string UserId { get; set; }
        public virtual WebApplication2User WebApplication2User { get; set; }
    }
}
