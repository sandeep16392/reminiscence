using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Reminiscence.Model.EntityModels;

namespace Reminiscence.DAL.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
