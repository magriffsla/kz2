using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity;

namespace kz2.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Subject> Subjects {get;set;}
        public DbSet<Post> Posts {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder
            .Entity<Post>()
            .HasOne(p => p.Subject)
            .WithMany(s => s.Posts);
            
            modelBuilder
            .Entity<Subject>()
            .HasMany(s => s.Posts)
            .WithOne(p => p.Subject);
        }
    }
}