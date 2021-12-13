using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EduHomeProject.Models
{
    public class SliderBanner
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string SupTitle { get; set; }
        [MaxLength(20)]
        public string Page { get; set; }
    }
}
