using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TNRD.Zeepkist.WorkshopApi.Database.Models;

namespace TNRD.Zeepkist.WorkshopApi.Database;

public partial class ZworpshopContext : DbContext
{
    public ZworpshopContext()
    {
    }

    public ZworpshopContext(DbContextOptions<ZworpshopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Level> Levels { get; set; }

    public virtual DbSet<Metadata> Metadata { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Level>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("levels_pkey");

            entity.ToTable("levels");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.FileAuthor).HasColumnName("file_author");
            entity.Property(e => e.FileHash).HasColumnName("file_hash");
            entity.Property(e => e.FileUid).HasColumnName("file_uid");
            entity.Property(e => e.FileUrl).HasColumnName("file_url");
            entity.Property(e => e.ImageUrl).HasColumnName("image_url");
            entity.Property(e => e.MetadataId).HasColumnName("metadata_id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.ReplacedBy).HasColumnName("replaced_by");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.WorkshopId).HasColumnName("workshop_id");

            entity.HasOne(d => d.Metadata).WithMany(p => p.Levels)
                .HasForeignKey(d => d.MetadataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("levels_metadata_id_fkey");
        });

        modelBuilder.Entity<Metadata>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("metadata_pkey");

            entity.ToTable("metadata");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Blocks).HasColumnName("blocks");
            entity.Property(e => e.Bronze).HasColumnName("bronze");
            entity.Property(e => e.Checkpoints).HasColumnName("checkpoints");
            entity.Property(e => e.Gold).HasColumnName("gold");
            entity.Property(e => e.Ground).HasColumnName("ground");
            entity.Property(e => e.Hash).HasColumnName("hash");
            entity.Property(e => e.Silver).HasColumnName("silver");
            entity.Property(e => e.Skybox).HasColumnName("skybox");
            entity.Property(e => e.Valid).HasColumnName("valid");
            entity.Property(e => e.Validation).HasColumnName("validation");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("requests_pkey");

            entity.ToTable("requests");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("now()")
                .HasColumnName("date_created");
            entity.Property(e => e.Hash).HasColumnName("hash");
            entity.Property(e => e.Uid).HasColumnName("uid");
            entity.Property(e => e.WorkshopId).HasColumnName("workshop_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
