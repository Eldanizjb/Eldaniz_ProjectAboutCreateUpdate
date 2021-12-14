using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EduHomeProject.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }
        public DateTime? CreatedDate { get; set; }

        [MaxLength(250)]
        public string Title { get; set; }
        [Column(TypeName ="ntext")]
        public string Text { get; set; }
        
        [ForeignKey("BlogCategory")]
        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }
     
        [ForeignKey("BlogUser")]
        public int BlogUserId { get; set; }
        public BlogUser BlogUser { get; set; }

        public List<TagToBlog> TagToBlogs { get; set; }
        public List<BlogComment> BlogComments { get; set; }
        [NotMapped]
        public List<int> TagToBlogsId { get; set; }



    }
}
