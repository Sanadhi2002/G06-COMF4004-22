using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models
{
    public class StudentEmail
        
    {
        
        [Key]
        public int S_Id { get; set; }

        public string S_Name { get; set; }

        public string S_Email { get; set; }
    }
}
