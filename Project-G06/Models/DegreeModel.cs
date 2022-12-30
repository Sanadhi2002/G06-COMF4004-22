using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace Project_G06.Models
{
    public class DegreeModel
    {


        [Key]
        public int Degree_ID { get; set; }
        public string Degre_Name { get; set; }
        public string Degree_Type { get; set; }
        public string Affiliated_uni { get; set; }
        public string Degree_duration { get; set; }
        public string Degree_description { get; set; }
        public string CourseFee { get; set; }
        public string Career_Opurtunity { get; set; }
        public string Academic_proggression { get; set; }
        public string Admission_Requirments { get; set; }


        [ForeignKey("UniProfileModel")]
        public string UserId { get; set; }
        public UniProfileModel UniProfileModel { get; set; }
    }
}
