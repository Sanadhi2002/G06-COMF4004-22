using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_G06.Models
{
    public class UniProfileModel
    {
        [Key]
        public int Uni_ID { get; set; }
        public string Uni_FullName { get; set; }
        public string Uni_ShortName { get; set;}
        public string Uni_Details { get; set; }
        
        public byte? U_Picture { get; set; }
        [Required]
        [ForeignKey("UnifacultyModels")]
        public int Uni_Faculty_ID { get; set; }

        public Uni_FacultyModel UnifacultyModels { get; set; }
    }
}
