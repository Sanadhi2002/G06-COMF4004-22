<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
=======
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
>>>>>>> 6940dc56baee2492cc030d4f72fa69340d3bcae2

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
