using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using clase5.Models;

namespace clase5.Data
{
    public class CarContext : DbContext
    {
        public CarContext (DbContextOptions<CarContext> options)
            : base(options)
        {
        }

        public DbSet<clase5.Models.Car> Car { get; set; } = default!;

        
    }
}
