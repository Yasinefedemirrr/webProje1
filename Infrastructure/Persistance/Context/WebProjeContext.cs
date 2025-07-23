using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Context
{
    public class WebProjeContext : DbContext
    {
        public WebProjeContext(DbContextOptions<WebProjeContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=YASINEFEDEMIR\\SQLEXPRESS;Database=webProje;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

         public DbSet<About> Abouts { get; set; }
         public DbSet<Author> Authors { get; set; }
         public DbSet<Statistic> Statistics { get; set; }
         public DbSet<Book> Books { get; set; }
         public DbSet<Contact> Contacts { get; set; }
         public DbSet<FooterAddress> FooterAddresses { get; set; }
         public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
