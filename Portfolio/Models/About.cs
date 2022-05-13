using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{

    [Table("About")]
    public class About
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [StringLength(50)]
        [Required]
        public string Surname { get; set; }
        [StringLength(50)]
        [Required]
        public string Email { get; set; }
        [StringLength(50)]
        [Required]
        public string PhoneNumber { get; set; }
        [StringLength(100)]
        [Required]
        public string Address { get; set; }
        [StringLength(500)]
        [Required]
        public string Description { get; set; }
    }
}
