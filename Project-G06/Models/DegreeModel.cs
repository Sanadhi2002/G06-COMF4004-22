using System.ComponentModel;
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
        [DisplayName("Degree Name")]
        public string Degre_Name { get; set; }
        [Required]
        [DisplayName("Degree Type")]
        public string Degree_Type { get; set; }
        [Required]
        [DisplayName("Affiliated Universities")]
        public string Affiliated_uni { get; set; }
        [Required]
        [DisplayName("Degree Duration")]
        public string Degree_duration { get; set; }
        [Required]
        [DisplayName("Degree Description")]
        public string Degree_description { get; set; }
        [Required]
        [DisplayName("Course Fee")]
        public string CourseFee { get; set; }
        [Required]
        [DisplayName("Career Opurtunity")]
        public string Career_Opurtunity { get; set; }
        [Required]
        [DisplayName("Academic Proggression")]
        public string Academic_proggression { get; set; }
        [Required]
        [DisplayName("Admission Requirments")]
        public string Admission_Requirments { get; set; }
        [Required]
        [DisplayName("Degree Contents")]
        public string DegreeContents { get; set; }
        public string? UniShortname { get; set; }



        [ForeignKey("UniProfileModel")]
        public string UserId { get; set; }
        public UniProfileModel UniProfileModel { get; set; }

       
       
        
    }
}
