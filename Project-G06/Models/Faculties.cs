using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models
{
    public class Faculties
    {
        [Key]
        public Guid GuidId { get; set; }

        

        public string  F_Name { get; set; }

    }
}
