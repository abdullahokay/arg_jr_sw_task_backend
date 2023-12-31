﻿using Microsoft.EntityFrameworkCore;
using Task.Entities;

namespace Task.Repository
{
    public class EF_DataContext : DbContext
    {
        public EF_DataContext(DbContextOptions<EF_DataContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<User> Users
        {
            get;
            set;
        }

    }
}