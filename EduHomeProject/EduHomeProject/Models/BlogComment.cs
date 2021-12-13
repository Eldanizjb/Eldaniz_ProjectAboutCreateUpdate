using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EduHomeProject.Models
{
    public class BlogComment
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Subject { get; set; }
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
      
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        
        [ForeignKey("ParentBlogComment")]
        public int? ParentBlogCommentId { get; set; }
        public BlogComment ParentBlogComment { get; set; }
    }
}
