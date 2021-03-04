﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Day_In_New_City_
{
    public partial class DayInANewCityContext : DbContext
    {
        public DayInANewCityContext()
        {
        }

        public DayInANewCityContext(DbContextOptions<DayInANewCityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoriesOfEvent> CategoriesOfEvents { get; set; }
        public virtual DbSet<CategoriesOfInstitution> CategoriesOfInstitutions { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventComment> EventComments { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<InstitutionComment> InstitutionComments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(" Server = LAPTOP-4HDPJGS2; Database = DayInANewCity;Trusted_Connection=True; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<CategoriesOfEvent>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CategoriesOfInstitution>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.Contacts)
                    .HasColumnType("text")
                    .HasColumnName("contacts");

                entity.Property(e => e.DescriptionInfo)
                    .HasColumnType("text")
                    .HasColumnName("descriptionInfo");

                entity.Property(e => e.EventDay)
                    .HasColumnType("date")
                    .HasColumnName("Event_day");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.HasOne(d => d.CategoryOfEvents)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CategoryOfEventsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Events_CategoriesOfEvents");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Events_Cities");
            });

            modelBuilder.Entity<EventComment>(entity =>
            {
                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.DateOfСreation)
                    .HasColumnType("date")
                    .HasColumnName("date_of_сreation");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventComments)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventComments_Events");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.Contacts)
                    .HasColumnType("text")
                    .HasColumnName("contacts");

                entity.Property(e => e.DescriptionInfo)
                    .HasColumnType("text")
                    .HasColumnName("descriptionInfo");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.HasOne(d => d.CategoryOfInstitutions)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.CategoryOfInstitutionsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Institutions_CategoriesOfInstitutions");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Institutions_Cities");
            });

            modelBuilder.Entity<InstitutionComment>(entity =>
            {
                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.DateOfСreation)
                    .HasColumnType("date")
                    .HasColumnName("date_of_сreation");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.InstitutionComments)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitutionComments_Institutions");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
