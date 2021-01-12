using BDGA3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDGA3
{
    public class Context : DbContext
    {
        public DbSet<Channel> channel { get; set; }
        public DbSet<ChannelFollow> channel_follow { get; set; }
        public DbSet<Comment> comment { get; set; }
        public DbSet<Email> email { get; set; }
        public DbSet<Video> video { get; set; }

        public Context()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=p;Database=bdga3");
        }
    }
}
