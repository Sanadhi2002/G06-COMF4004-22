using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models
{
    public class degree
    {
        [Key]
        public int Degree_ID { get; set; }
        public string Degre_Name { get; set; }

        [ForeignKey("Class")]
        public string UserId { get; set; }
        public Class Class { get; set; }
    }
}
