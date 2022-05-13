using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{

    [Table("Education")]
    public class Education
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string SchoolName { get; set; }
        [StringLength(50)]
        [Required]
        public string SectionName { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

    }
}
