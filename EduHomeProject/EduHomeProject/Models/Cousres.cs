using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EduHomeProject.Models
{
    public class Cousres
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [ForeignKey("CousresCategory")]
        public int CategoryId { get; set; }
        public CousresCategory CousresCategory { get; set; }
        
        [ForeignKey("CousresUser")]
        public int UserId { get; set; }
        public CousresUser CousresUser { get; set; }

        [ForeignKey("Feature")]
        public int Featureİd { get; set; }
        public Feature Feature { get; set; }

        public List<TagToCousres> TagToCousres { get; set; }
        public List<CousresComment> CousresComments { get; set; }

    }
}
