﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure
{
    public class PraksaDbContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieTheatre> MovieTheatres { get; set; }
        public DbSet<Projection> Projections { get; set; }
        public DbSet<ProjectionType> ProjectionTypes { get; set; }
        public PraksaDbContext(DbContextOptions options):base(options) { }
    }
}
