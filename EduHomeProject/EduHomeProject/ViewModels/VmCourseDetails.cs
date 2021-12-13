using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomeProject.Models;

namespace EduHomeProject.ViewModels
{
    public class VmCourseDetails : VmLayout
    {
        public Banner Banners { get; set; }
        public List<About> Abouts { get; set; }
        public List<Address> Addresses { get; set; }
     
        public List<Cousres> Cousres { get; set; }
        public List<CousresCategory> CousresCategories { get; set; }
        public List<CousresComment> CousresComments { get; set; }
        public List<CousresTag> CousresTags { get; set; }
        public List<CousresUser> CousresUsers { get; set; }
      
        public List<Feature> Features { get; set; }
        public List<İnformation> Information { get; set; }
        public List<Message> Messages { get; set; }
        public List<Skill> Skills { get; set; }
        public List<SliderBanner> SliderBanners { get; set; }
        public List<SliderTeacher> SliderTeachers { get; set; }
        public List<Sosial> Sosials { get; set; }
        public List<Subscribe> Subscribes { get; set; }
        public List<TagToCousres> TagToCousres { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
