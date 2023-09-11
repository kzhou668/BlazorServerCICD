using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Resmed.MSP.LSR.WebApi.Models
{
    public partial class DowntimeFormContext : DbContext
    {
        public DowntimeFormContext()
        {
        }

        public DowntimeFormContext(DbContextOptions<DowntimeFormContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DowntimeForm> DowntimeForms { get; set; }
        public virtual DbSet<Lookup> Lookups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=AWS-MSPSQL-D01.corp.resmed.org; database=MSPWIP;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");


            modelBuilder.Entity<DowntimeForm>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Lookup>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("PK_DowntimeLookups");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
