using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace EduHomeProject.Models
{
    public class SliderTeacher
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        public string Content { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(100)]
        public string Position { get; set; }

    }
}
