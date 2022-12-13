using Microsoft.EntityFrameworkCore.Migrations;
using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models
{
    public class WebsiteAdmin
    {
        [Key]

        public int W_Id { get; set; }
     
        
        public string W_UserName{ get; set; }

    public string W_Email { get; set; }

        public string W_Password { get; set; }
    }
}
