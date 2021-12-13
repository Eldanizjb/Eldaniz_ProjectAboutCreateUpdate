using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EduHomeProject.Models
{
    public class CousresComment
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(500)]
        public string Subject { get; set; }
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
       
        [ForeignKey("Cousres")]
        public int CousresId { get; set; }
        public Cousres Cousres { get; set; }
       
        [ForeignKey("ParentCousresComment")]
        public int? ParentCousresCommentId { get; set; }
        public CousresComment ParentCousresComment { get; set; }


    }
}
