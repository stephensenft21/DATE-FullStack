using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Capstone.Models.Data;

namespace Capstone.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ApplicationUser> Favorites { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
              
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<Favorite>().HasData(
          new Favorite()
          {
              FavoriteId = 1,
              ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",

          },
          new Favorite()
          {
              FavoriteId = 2,
              ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",

          }
      );


            modelBuilder.Entity<Comment>().HasData( 
                new Comment()
                {
                    CommentId = 1,
                    Text = "Hell Yeah",
                    FavoriteId = 1,
                  

                },
                new Comment()
                {
                    CommentId = 2,
                    Text = "Dope place",
                    FavoriteId = 1,
                

                },
                   new Comment()
                   {
                       CommentId = 1,
                       Text = "Cool Shop",
                       FavoriteId = 1,
                      

                   },
                      new Comment()
                      {
                          CommentId = 2,
                          Text = "This place rocks",
                          FavoriteId = 2,
                         



                      }
            );
        }

        public DbSet<Capstone.Models.Data.Favorite> Favorite { get; set; }
    }
}

    
