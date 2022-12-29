using Microsoft.AspNetCore.Identity;
using ProjectG06.Migrations;
using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models
{
    public class WebAdmin
    {
        [Key]
        public int W_ID { get; set; }
        public string W_Email { get; set; } 

        public string W_Password { get; set;}

       
    }
}
