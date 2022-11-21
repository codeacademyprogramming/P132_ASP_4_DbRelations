using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using YumyApp.Models;

namespace YumyApp.DAL
{
    public class YummyDbContext:DbContext
    {
        public YummyDbContext(DbContextOptions<YummyDbContext> opt):base(opt)
        {
            
        }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
