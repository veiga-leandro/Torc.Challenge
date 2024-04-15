﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Torc.Challenge.Infrastructure.DBConfiguration;

#nullable disable

namespace Torc.Challenge.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240415185800_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Torc.Challenge.Domain.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Category")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category");

                    b.Property<int>("CopiesInUse")
                        .HasColumnType("int")
                        .HasColumnName("copies_in_use");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("first_name");

                    b.Property<string>("Isbn")
                        .HasColumnType("varchar(80)")
                        .HasColumnName("isbn");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("last_name");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("title");

                    b.Property<int>("TotalCopies")
                        .HasColumnType("int")
                        .HasColumnName("total_copies");

                    b.Property<string>("Type")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("type");

                    b.HasKey("BookId");

                    b.ToTable("books");
                });
#pragma warning restore 612, 618
        }
    }
}
