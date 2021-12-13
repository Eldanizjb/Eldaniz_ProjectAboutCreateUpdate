using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHomeProject.Models
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime CreateDate { get; set; }
        [MaxLength(50)]
        public string Duration { get; set; }
        [MaxLength(50)]
        public string Class { get; set; }
        [MaxLength(50)]
        public string SkillLevel { get; set; }
        [MaxLength(50)]
        public string Language { get; set; }
        [Column(TypeName="smallint")]
        public short Students { get; set; }
        [MaxLength(20)]
        public string Assesmentsself { get; set; }
        public decimal Pay { get; set; }
        public List<Cousres> Cousres { get; set; }

    }
}
