using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    [Table("Experiences")]
    public class Experiences
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Position { get; set; }
        
        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        [StringLength(50)]
        [Required]
        public string CompanyName { get; set; }
        [StringLength(500)]
        
        public string Description { get; set; }
        public bool IsPresent { get; set; }

    }
}
