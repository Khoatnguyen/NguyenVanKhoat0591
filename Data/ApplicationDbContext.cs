using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenVanKhoat0591.Models;

namespace NguyenVanKhoat0591.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NguyenVanKhoat0591.Models.CompanyNVK591> CompanyNVK591 { get; set; } = default!;
    
    }
}


