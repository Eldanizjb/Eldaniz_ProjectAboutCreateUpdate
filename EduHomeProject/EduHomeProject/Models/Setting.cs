using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHomeProject.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        [MaxLength(20)]
        public string Phone1 { get; set; }
        [MaxLength(20)]
        public string Phone2 { get; set; }
        [MaxLength(50)]
        public string Email1 { get; set; }
        [MaxLength(50)]
        public string Email2 { get; set; }
        [MaxLength(1000)]
        public string About { get; set; }
        [MaxLength(250)]
        public string Logo1 { get; set; }
        [NotMapped]
        public IFormFile LogoFile1 { get; set; }

    }
}
