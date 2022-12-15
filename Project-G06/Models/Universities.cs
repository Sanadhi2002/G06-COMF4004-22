using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models
{
    public class Universities
    {

        [Key]
        public string Name { get; set; }
        public string Email { get; set; }


        public string Password { get; set; }

        public DateTime Date { get; set; }

    }
}


