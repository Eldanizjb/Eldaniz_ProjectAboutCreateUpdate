using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHomeProject.Models
{
    public class TagToBlog
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("BlogTag")]
        public int TagId { get; set; }
        public BlogTag BlogTag { get; set; }
  
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
