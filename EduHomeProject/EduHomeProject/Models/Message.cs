using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHomeProject.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(500)]
        public string Subject { get; set; }
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
    }
}
