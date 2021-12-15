using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EduHomeProject.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }
        [MaxLength(100)]
        public string Time { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
  
        [ForeignKey("EventCategory")]
        public int CategoryId { get; set; }
        public EventCategory EventCategory { get; set; }
       
        [ForeignKey("EventUser")]
        public int UserId { get; set; }
        public EventUser EventUser { get; set; }
        public DateTime? CreateDate { get; set; }

        public List<TagToEvent> TagToEvent { get; set; }
        public List<EventComment> EventComments { get; set; }
        [NotMapped]
        public List<int> TagToEventId { get; set; }

    }
}
