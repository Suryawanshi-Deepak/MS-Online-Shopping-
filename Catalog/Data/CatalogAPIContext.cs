using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CatalogAPI.Models;

namespace CatalogAPI.Data
{
    public class CatalogAPIContext : DbContext
    {
        public CatalogAPIContext (DbContextOptions<CatalogAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CatalogAPI.Models.Catalog> Catalog { get; set; } = default!;
    }
}
