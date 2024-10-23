
using Microsoft.EntityFrameworkCore;
using Movies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Presistance
{
    public class DBContextApplication : DbContext
    {
        public DBContextApplication(DbContextOptions<DBContextApplication> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermissions> RolePermissions { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }
        public DbSet<Reviews> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding data
            modelBuilder.CategorySeed();
            modelBuilder.MovieSeed();
            modelBuilder.ReviewSeed();
            modelBuilder.LikeSeed();
            modelBuilder.RoleSeed();
            modelBuilder.UserSeed();
            modelBuilder.PermissionSeed();
            modelBuilder.RoleUserSeed();
            modelBuilder.RolePermissionSeed();

            // Configuring RolePermissions
            modelBuilder.Entity<RolePermissions>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionId });

            modelBuilder.Entity<RolePermissions>()
                .HasOne(rp => rp.Permissions)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(rp => rp.PermissionId)
                .OnDelete(DeleteBehavior.NoAction);

            // Configuring RoleUser
            modelBuilder.Entity<RoleUser>()
                .HasKey(ru => new { ru.RoleId, ru.UserId });

            modelBuilder.Entity<RoleUser>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.RoleUser)
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.NoAction);

            // Configuring Reviews and their relationships
            modelBuilder.Entity<Reviews>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Reviews>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.Reviews)
                .HasForeignKey(r => r.MovieId)
                .OnDelete(DeleteBehavior.NoAction);

            // Configuring Movie and Category relationship
            modelBuilder.Entity<Movie>()
                .HasOne(m => m.category)
                .WithMany(c => c.Movies)
                .HasForeignKey(m => m.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Like>()
               .HasOne(l => l.Reviews)
               .WithMany(r => r.Likes)
               .HasForeignKey(l => l.ReviewId)
               .OnDelete(DeleteBehavior.NoAction);


            // Call base method once at the end
            base.OnModelCreating(modelBuilder);
        }
    }
}