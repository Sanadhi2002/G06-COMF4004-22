using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace Project_G06.Models
{
    public class DegreeModel
    {


        [Key]
        public int Degree_ID { get; set; }
        [Required]
        public string Degre_Name { get; set; }
        [Required]
        public string Degree_Type { get; set; }
        [Required]
        public string Affiliated_uni { get; set; }
        [Required]
        public string Degree_duration { get; set; }
        [Required]
        public string Degree_description { get; set; }
        [Required]
        public string CourseFee { get; set; }
        [Required]
        public string Career_Opurtunity { get; set; }
        [Required]
        public string Academic_proggression { get; set; }
        [Required]
        public string Admission_Requirments { get; set; }
        [Required]
        public string DegreeContents { get; set; }
        public string? UniShortname { get; set; }

        [ForeignKey("UniProfileModel")]
        public string UserId { get; set; }
        public UniProfileModel UniProfileModel { get; set; }

       
       
        
    }
}
