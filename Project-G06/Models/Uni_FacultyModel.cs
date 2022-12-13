using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models
{
    public class Uni_FacultyModel
    {
        [Key]
        public int Uni_Faculty_ID { get; set; }
        public string Faculty_Name { get; set; }

    }
}
