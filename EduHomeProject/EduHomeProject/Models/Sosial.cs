using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EduHomeProject.Models
{
    public class Sosial
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Icone { get; set; }
        [MaxLength(100)]
        public string Link { get; set; }

        public List<Teacher> Teachers { get; set; }

    }
}
