using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SquadUpMVC.Models;

namespace SquadUpMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<DirectMessage> DirectMessage { get; set; }
        public DbSet<Friend> Friend { get; set; }
        public DbSet<FriendChat> FriendChat { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Squad> Squad { get; set; }
        public DbSet<SquadUser> SquadUser { get; set; }
        public DbSet<SquadChat> SquadChat { get; set; }
        public DbSet<NotificationType> NotificationType { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            Status Stat = new Status
            {
                Id = 1,
                Name = "Pending",
            };


            builder.Entity<Status>().HasData(
                new Status()
                {
                    Id = 2,
                    Name = "Joined Squad",
                },
                new Status()
                {
                    Id = 3,
                    Name = "Purchased a Ticket",
                },
                  new Status()
                  {
                      Id = 4,
                      Name = "Need $ Assistance",
                  }
                
        );

            NotificationType NotificationType = new NotificationType
            {
                Id = 1,
                Type = "Pending",
            };


            builder.Entity<NotificationType>().HasData(
                new NotificationType()
                {
                    Id = 2,
                    Type = "Joined Squad",
                },
                new NotificationType()
                {
                    Id = 3,
                    Type = "Purchased a Ticket",
                },
                new NotificationType()
                {
                    Id = 4,
                    Type = "Need $ Assistance",
                }

        );


        }
    }
}
