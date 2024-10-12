﻿// <auto-generated />
using DotNet8.EFCoreQueryFilterExample.AppDbContextModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotNet8.EFCoreQueryFilterExample.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241012034614_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DotNet8.EFCoreQueryFilterExample.AppDbContextModels.Tbl_Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogId"));

                    b.Property<string>("BlogAuthor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("BlogId");

                    b.ToTable("Tbl_Blog");
                });
#pragma warning restore 612, 618
        }
    }
}
