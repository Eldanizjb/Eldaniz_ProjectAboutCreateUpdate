using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EduHomeProject.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string LogcationAddress { get; set; }
        [MaxLength(200)]
        public string PhoneAddress { get; set; }
        [MaxLength(200)]
        public string WebAddress { get; set; }
        [MaxLength(20)]
        public string Icon { get; set; }
    }
}
