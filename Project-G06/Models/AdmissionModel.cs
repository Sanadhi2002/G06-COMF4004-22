using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_G06.Models
{
    public class AdmissionModel
    {
        [Key]
        public int Admission_Id { get; set; }
        public string Admissions { get; set; }
        [ForeignKey("DegreeModel")]
        public int Degree_ID { get; set; }
        public DegreeModel DegreeModel { get; set; }
    }
}
