using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Users_API.Data
{
  public class UserContext : DbContext
  {
    public DbSet<User> Users { get; private set; }
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
      Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<User>().HasKey(u => u.Id);

      modelBuilder.Entity<User>()
          .Property(u => u.Id)
          .IsRequired().HasMaxLength(36);

      modelBuilder.Entity<User>()
          .Property(u => u.FirstName)
          .IsRequired().HasMaxLength(20);


      modelBuilder.Entity<User>()
          .Property(u => u.LastName)
          .IsRequired().HasMaxLength(20);

      modelBuilder.Entity<User>()
          .Property(u => u.UserName)
          .IsRequired()
          .HasMaxLength(20);

      modelBuilder.Entity<User>()
          .HasAlternateKey(u => u.UserName)
          .HasName("AlternateKey_UserName");

      modelBuilder.Entity<User>()
          .Property(u => u.Email)
          .IsRequired()
          .HasMaxLength(40);

      modelBuilder.Entity<User>()
          .HasAlternateKey(u => u.Email)
          .HasName("AlternateKey_Email");

      modelBuilder.Entity<User>()
          .Property(u => u.Password)
          .IsRequired().HasMaxLength(64);

      modelBuilder.Entity<User>()
          .Property(u => u.ImagePath)
          .HasMaxLength(200);

      Seed(modelBuilder);
    }

    private void Seed(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<User>().HasData(
        User.Create("user1", "user1", "user1", "user1@mail.com", "user", ""),
        User.Create("user2", "user2", "user2", "user2@mail.com", "user", ""),
        User.Create("user3", "user3", "user3", "user3@mail.com", "user", ""),
        User.Create("user4", "user4", "user4", "user4@mail.com", "user", "")
        );
    }
  }
}
