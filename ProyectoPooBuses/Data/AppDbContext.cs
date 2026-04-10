using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buses.Entities;
using Microsoft.EntityFrameworkCore;

namespace Buses.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet <BusEntity> Buses { get; set; }
        public DbSet <RouteEntity> Routes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) 
        {}

    }
}