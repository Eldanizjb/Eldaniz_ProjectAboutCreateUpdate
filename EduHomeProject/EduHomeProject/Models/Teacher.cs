using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace EduHomeProject.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Position { get; set; }
        [MaxLength(50)]
        public string About { get; set; }
        [MaxLength(50)]
        public string Degree { get; set; }
        [MaxLength(50)]
        public string Experience { get; set; }
        [MaxLength(50)]
        public string Hobbies { get; set; }
        [MaxLength(50)]
        public string Faculty { get; set; }
        public DateTime CreateDate { get; set; }

        [ForeignKey("Skill")]
        public int Skillsİd { get; set; }
        public Skill Skill { get; set; }
      

        [ForeignKey("İnformation")]
        public int İnformationİd { get; set; }
        public İnformation Information { get; set; }


        [ForeignKey("Sosial")]
        public int Sosialİd { get; set; }
        public Sosial Sosial { get; set; }
    }
}
