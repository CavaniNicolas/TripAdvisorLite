using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL;

namespace DAL.Models
{
    public partial class TripAdvisorContext : DbContext
    {
        public TripAdvisorContext()
        {

        }

        public TripAdvisorContext(DbContextOptions<TripAdvisorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Service> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:tripadvisordb.database.windows.net,1433;Initial Catalog=tripadvisorDB;Persist Security Info=False;User ID=sheep;Password=ISIMAisima2021!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        //    modelBuilder.Entity<User>(entity =>
        //    {
        //        entity.ToTable("users", "production");

        //        entity.Property(e => e.UserId).HasColumnName("user_id");

        //        entity.Property(e => e.Username)
        //            .IsRequired()
        //            .HasMaxLength(255)
        //            .IsUnicode(false)
        //            .HasColumnName("user_name");

        //        //entity.Property(e => e.ReviewList)
        //        //    .IsRequired()
        //        //    .HasMaxLength(255)
        //        //    .IsUnicode(false)
        //        //    .HasColumnName("user_reviewlist");
        //    });

        //    modelBuilder.Entity<Review>(entity =>
        //    {
        //        entity.ToTable("reviews", "production");

        //        entity.Property(e => e.ReviewId).HasColumnName("review_id");

        //        entity.Property(e => e.Note)
        //            .IsRequired()
        //            .HasMaxLength(255)
        //            .IsUnicode(false)
        //            .HasColumnName("review_note");

        //        entity.Property(e => e.Date)
        //            .IsRequired()
        //            .HasMaxLength(255)
        //            .IsUnicode(false)
        //            .HasColumnName("review_date");

        //        entity.Property(e => e.Text)
        //            .IsRequired()
        //            .HasMaxLength(255)
        //            .IsUnicode(false)
        //            .HasColumnName("review_text");

        //        //entity.Property(e => e.Poster)
        //        //    .IsRequired()
        //        //    .HasMaxLength(255)
        //        //    .IsUnicode(false)
        //        //    .HasColumnName("review_poster");

        //        //entity.Property(e => e.Service)
        //        //    .IsRequired()
        //        //    .HasMaxLength(255)
        //        //    .IsUnicode(false)
        //        //    .HasColumnName("review_service");
        //    });

        //    modelBuilder.Entity<Service>(entity =>
        //    {
        //        entity.ToTable("services", "production");

        //        entity.Property(e => e.ServiceId).HasColumnName("service_id");

        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasMaxLength(255)
        //            .IsUnicode(false)
        //            .HasColumnName("service_name");

        //        entity.Property(e => e.Adress)
        //            .IsRequired()
        //            .HasMaxLength(255)
        //            .IsUnicode(false)
        //            .HasColumnName("service_adress");

        //        //entity.Property(e => e.ReviewList)
        //        //    .IsRequired()
        //        //    .HasMaxLength(255)
        //        //    .IsUnicode(false)
        //        //    .HasColumnName("service_reviewlist");
        //    }); 

        //    OnModelCreatingPartial(modelBuilder);
        //}
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
