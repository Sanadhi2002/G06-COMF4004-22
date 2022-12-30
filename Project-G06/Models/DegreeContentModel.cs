using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_G06.Models
{
    public class DegreeContentModel
    {
        [Key]
        public int DegreeContent_Id { get; set; }
        public string DegreeContents { get; set; }

        [ForeignKey("DegreeModel")]
        public int Degree_ID { get; set; }
        public DegreeModel DegreeModel { get; set; }
    }
}
