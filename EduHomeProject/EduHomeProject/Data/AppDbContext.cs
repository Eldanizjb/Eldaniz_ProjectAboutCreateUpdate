using EduHomeProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option) 
        { 
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses{ get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<BlogUser> BlogUsers { get; set; }
        public DbSet<Cousres> Cousres { get; set; }
        public DbSet<CousresCategory> CousresCategories { get; set; }
        public DbSet<CousresComment> CousresComments { get; set; }
        public DbSet<CousresTag> CousresTags { get; set; }
        public DbSet<CousresUser> CousresUsers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<EventComment> EventComments { get; set; }
        public DbSet<EventTag> EventTags { get; set; }
        public DbSet<EventUser> EventUsers{ get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<İnformation> Information { get; set; }
        public DbSet<Message> Messages{ get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SliderBanner> SliderBanners { get; set; }
        public DbSet<SliderTeacher> SliderTeachers { get; set; }
        public DbSet<Sosial> Sosials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<TagToBlog> TagToBlogs { get; set; }
        public DbSet<TagToCousres> TagToCousres { get; set; }
        public DbSet<TagToEvent> TagToEvents { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
     
    }
}
