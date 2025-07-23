using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Context
{
    public class WebProjeContextFactory : IDesignTimeDbContextFactory<WebProjeContext>
    {
        public WebProjeContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebProjeContext>();
            optionsBuilder.UseSqlServer("Server=YASINEFEDEMIR\\SQLEXPRESS;Database=webProje;Trusted_Connection=True;TrustServerCertificate=True;");

            return new WebProjeContext(optionsBuilder.Options);
        }
    }
}
