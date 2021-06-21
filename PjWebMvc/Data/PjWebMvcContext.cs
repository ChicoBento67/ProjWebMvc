using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PjWebMvc.Models
{
    public class PjWebMvcContext : DbContext
    {
        public PjWebMvcContext (DbContextOptions<PjWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<PjWebMvc.Models.Department> Department { get; set; }
    }
}
