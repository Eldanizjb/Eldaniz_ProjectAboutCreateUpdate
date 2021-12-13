using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHomeProject.Models
{
    public class TagToEvent
    {
        [Key]
        public int Id { get; set; }
      
        [ForeignKey("EventTag")]
        public int EventTagId { get; set; }
        public EventTag EventTag { get; set; }


        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Event Events { get; set; }

    }
}
