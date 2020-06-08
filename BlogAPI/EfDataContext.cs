using System;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI
{
    public class EfDataContext : DbContext
    {
        public EfDataContext()
        {
        }

        public EfDataContext(DbContextOptions<EfDataContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite("Data Source=BlogKata.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

        }
    }
}