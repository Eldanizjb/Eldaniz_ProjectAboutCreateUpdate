﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EduHomeProject.Models
{
    public class BlogTag
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }


    }
}
