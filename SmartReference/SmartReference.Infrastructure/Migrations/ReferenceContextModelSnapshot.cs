﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SmartReference.Infrastructure;

namespace SmartReference.Infrastructure.Migrations
{
    [DbContext(typeof(ReferenceContext))]
    partial class ReferenceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("SmartReference.Domain.Models.Reference", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Citation")
                        .HasColumnType("text");

                    b.Property<string>("Link")
                        .HasColumnType("text");

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.ToTable("References");
                });

            modelBuilder.Entity("SmartReference.Domain.Models.ReferenceTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ReferenceName")
                        .HasColumnType("text");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ReferenceName");

                    b.HasIndex("TagId");

                    b.ToTable("ReferenceTags");
                });

            modelBuilder.Entity("SmartReference.Domain.Models.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("SmartReference.Domain.Models.ReferenceTag", b =>
                {
                    b.HasOne("SmartReference.Domain.Models.Reference", "Reference")
                        .WithMany("ReferenceTags")
                        .HasForeignKey("ReferenceName");

                    b.HasOne("SmartReference.Domain.Models.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reference");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("SmartReference.Domain.Models.Reference", b =>
                {
                    b.Navigation("ReferenceTags");
                });
#pragma warning restore 612, 618
        }
    }
}
