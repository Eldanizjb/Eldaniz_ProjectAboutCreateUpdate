using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHomeProject.Models
{
    public class TagToCousres
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CousresTag")]
        public int CousresTagId { get; set; }
        public CousresTag CousresTag { get; set; }
    
        [ForeignKey("Cousres")]
        public int CousresId { get; set; }
        public Cousres Cousres { get; set; }

    }
}
