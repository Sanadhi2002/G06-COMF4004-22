using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models
{
    public class UniProfileModel
    {
        [Key]
        public int Uni_ID { get; set; }
        public string Uni_FullName { get; set; }
        public string Uni_ShortName { get; set;}
        public string Uni_Details { get; set; }
        public int Uni_FacultyID { get; set; }
        public byte? U_Picture { get; set; }
        
    }
}
