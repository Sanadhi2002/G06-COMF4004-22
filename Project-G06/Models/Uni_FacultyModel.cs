using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_G06.Models
{
    public class Uni_FacultyModel
    {
        [Key]
        public int Uni_Faculty_ID { get; set; }
        public string? Faculty_Name { get; set; }

        [ForeignKey("UniProfileModel")]
        public string UserId { get; set; }
        public UniProfileModel UniProfileModel { get; set; }


    }
}
