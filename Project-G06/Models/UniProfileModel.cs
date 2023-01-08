using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_G06.Models
{
    public class UniProfileModel
    {
        [Key, ForeignKey("WebApplication2User")]
        public string UserId { get; set; }
        [DisplayName("University short Name")]
        
        public string? UniShortname { get; set; }
        
        [DisplayName("University Full Name")]
        public string? UniFullname { get; set; }
        [DisplayName("University Details")]
        public string? UniDetails { get; set; }
        public string? ProfilPic_URL { get; set; }
        public string? ImgExtension { get; set; }
        
        [NotMapped]
        public IFormFile UploadedProfilePic { get; set; }
        //public string UserId { get; set; }
        public virtual WebApplication2User WebApplication2User { get; set; }
        public virtual Uni_FacultyModel UniFacultyModel { get; set; }
    }
}
