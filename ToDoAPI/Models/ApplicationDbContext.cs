using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Authentication;

namespace ToDoAPI.Models
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ToDoItemModel> ToDoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<User>(entity =>
            {
                entity.HasMany(e => e.Items);

            });
            builder.Entity<ToDoItemModel>(entity =>
            {
                entity.HasKey(e => e.ItemId);
                
                entity.Property(e => e.ItemName)
                .IsRequired()
                .HasMaxLength(100);

                entity.Property(e => e.ItemDescription)
                .HasMaxLength(100);

                entity.Property(e => e.ItemStatus)
                .IsRequired();

                entity.Property(e => e.ItemCreated)     
                 .IsRequired()
                 .HasMaxLength(10);

                entity.Property(e => e.ItemUpdated)
             
                 .IsRequired()
                 .HasMaxLength(10);

                entity.HasOne(e => e.User);
            });

            base.OnModelCreating(builder);
        }
    }
}
