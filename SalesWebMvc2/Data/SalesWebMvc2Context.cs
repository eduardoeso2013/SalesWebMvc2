using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc2.Models
{
    public class SalesWebMvc2Context : DbContext
    {
        public SalesWebMvc2Context (DbContextOptions<SalesWebMvc2Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc2.Models.Department> Department { get; set; }
    }
}
