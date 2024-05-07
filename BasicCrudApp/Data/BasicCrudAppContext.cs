using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BasicCrudApp.Model;

namespace BasicCrudApp.Data
{
    public class BasicCrudAppContext : DbContext
    {
        public BasicCrudAppContext (DbContextOptions<BasicCrudAppContext> options)
            : base(options)
        {
        }

        public DbSet<BasicCrudApp.Model.User> User { get; set; } = default!;
    }
}
