using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EduHomeProject.Models
{
    public class Subscribe
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Emale { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
