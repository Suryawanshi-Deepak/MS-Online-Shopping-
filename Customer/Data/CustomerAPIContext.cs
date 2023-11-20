using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerAPI.Models;

namespace CustomerAPI.Data
{
    public class CustomerAPIContext : DbContext
    {
        public CustomerAPIContext (DbContextOptions<CustomerAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerAPI.Models.Customer> Customer { get; set; } = default!;
    }
}
