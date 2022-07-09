using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication8_Products_APi.Model;

namespace WebApplication8_Products_APi.Data
{
    public class WebApplication8_Products_APiContext : DbContext
    {
        public WebApplication8_Products_APiContext (DbContextOptions<WebApplication8_Products_APiContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication8_Products_APi.Model.Product>? Product { get; set; }
    }
}
