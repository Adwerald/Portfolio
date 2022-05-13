using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{

    [Table("Skills")]
    public class Skills
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
    }
}
