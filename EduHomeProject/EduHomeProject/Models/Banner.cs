using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace EduHomeProject.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Title { get; set; }
        [MaxLength(20, ErrorMessage = "Qaqa 20-den o terefe kecme")]
        public string Page { get; set; }

    }
}
