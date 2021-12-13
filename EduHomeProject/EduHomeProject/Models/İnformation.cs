using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class İnformation
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Skype { get; set; }
        [MaxLength(50)]
        public string Degree { get; set; }
        public List<Teacher> Teachers { get; set; }

    }
}
