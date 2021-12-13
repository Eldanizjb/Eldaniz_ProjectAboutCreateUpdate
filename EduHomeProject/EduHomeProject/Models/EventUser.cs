using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHomeProject.Models
{
    public class EventUser
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

        public DateTime CreateDate { get; set; }
        [MaxLength(50)]
        public string Position { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<Event> Events { get; set; }

    }
}
