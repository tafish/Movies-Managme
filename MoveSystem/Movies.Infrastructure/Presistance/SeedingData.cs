
using Microsoft.EntityFrameworkCore;

using Movies.Domain.Entity;
using System.Reflection.Emit;


namespace Ecommerce.Infrastructure.Presistance
{
    public static class SeedingData
    {
        public static void CategorySeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Tsundere" },
                new Category() { Id = 2, Name = "Tsundere" },
                new Category() { Id = 3, Name = "Yandere" },
                new Category() { Id = 4, Name = "Kuudere" },
                new Category() { Id = 5, Name = "Dandere" }

                );
        }


        public static void MovieSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Name = "Tsundere Movie 1", CategoryId = 1 },
                new Movie() { Id = 2, Name = "Tsundere Movie 2", CategoryId = 1 },
                new Movie() { Id = 3, Name = "Yandere Movie", CategoryId = 2 },
                new Movie() { Id = 4, Name = "Kuudere Movie", CategoryId = 3 },
                new Movie() { Id = 5, Name = "Dandere Movie", CategoryId = 4 }
              );
        }


        public static void ReviewSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reviews>().HasData(
               new Reviews { Id = 1, Content = "Great movie!", Date = DateTime.Now, MovieId = 1, UserId = 1 },
               new Reviews { Id = 2, Content = "Not bad", Date = DateTime.Now, MovieId = 2, UserId = 2 }
           );
        }

        public static void LikeSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Like>().HasData(
             new Like { Id = 1, UserId = 1, ReviewId = 1, IsLiked = true },
             new Like { Id = 2, UserId = 2, ReviewId = 2, IsLiked = false }
         );

        }

        public static void RoleSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
           new Role { Id = 1, Name = "Admin" },
           new Role { Id = 2, Name = "User" }
            );

        }

        public static void UserSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
               new User { Id = 1, Name = "John Doe" },
               new User { Id = 2, Name = "Jane Smith" }
           );
        }


        public static void PermissionSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permissions>().HasData(
               new Permissions { Id = 1, Name = "Create" },
               new Permissions { Id = 2, Name = "Read" },
               new Permissions { Id = 3, Name = "Update" },
               new Permissions { Id = 4, Name = "Delete" }
           );
        }
        public static void RoleUserSeed(this ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<RoleUser>().HasData(
                new RoleUser { RoleId = 1, UserId = 1 },
                new RoleUser { RoleId = 2, UserId = 2 }
            );

        }

        public static void RolePermissionSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RolePermissions>().HasData(
               new RolePermissions { RoleId = 1, PermissionId = 1 },
               new RolePermissions { RoleId = 1, PermissionId = 2 },
               new RolePermissions { RoleId = 1, PermissionId = 3 },
               new RolePermissions { RoleId = 1, PermissionId = 4 },
               new RolePermissions { RoleId = 2, PermissionId = 2 }
           );
        }

        }
    }





