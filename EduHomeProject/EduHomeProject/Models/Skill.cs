using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EduHomeProject.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public decimal Percent { get; set; }
        public List<Teacher> Teachers { get; set; }

    }
}
