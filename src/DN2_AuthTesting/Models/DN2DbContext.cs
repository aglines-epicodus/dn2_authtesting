using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace DN2_AuthTesting.Models
{
    public class DN2DbContext : DbContext
    {
        public DN2DbContext()
        {
        }

        public DbSet<PartOfSpeech> PartOfSpeeches { get; set; }
        public DbSet<Word> Words { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DN2_AuthTesting;integrated security=True");
        }

        public DN2DbContext(DbContextOptions<DN2DbContext> options)
                : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
