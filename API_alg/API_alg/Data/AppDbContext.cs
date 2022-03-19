using API_alg.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace API_alg.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        public DbSet<Algorithm> Algorithms { get; set; }
    }
}
