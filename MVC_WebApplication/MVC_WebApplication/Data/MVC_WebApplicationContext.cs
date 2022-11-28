using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_WebApplication;

namespace MVC_WebApplication.Data
{
    public class MVC_WebApplicationContext : DbContext
    {
        public MVC_WebApplicationContext (DbContextOptions<MVC_WebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_WebApplication.Player> Player { get; set; } = default!;
    }
}
