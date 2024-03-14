﻿// <auto-generated />
using System;
using APITestBed.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APITestBed.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APITestBed.Models.AuthorModel", b =>
                {
                    b.Property<int>("Author_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Author_ID"));

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_ID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("APITestBed.Models.BookAuthorModel", b =>
                {
                    b.Property<int>("Book_ID")
                        .HasColumnType("int");

                    b.Property<int>("Author_ID")
                        .HasColumnType("int");

                    b.HasKey("Book_ID", "Author_ID");

                    b.HasIndex("Author_ID");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("APITestBed.Models.BookModel", b =>
                {
                    b.Property<int>("Book_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Book_ID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Edition")
                        .HasColumnType("int");

                    b.Property<string>("Format")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Pages")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Book_ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("APITestBed.Models.BookPublisherModel", b =>
                {
                    b.Property<int>("Book_ID")
                        .HasColumnType("int");

                    b.Property<int>("Publisher_Id")
                        .HasColumnType("int");

                    b.HasKey("Book_ID", "Publisher_Id");

                    b.HasIndex("Publisher_Id");

                    b.ToTable("BookPublishers");
                });

            modelBuilder.Entity("APITestBed.Models.PublisherModel", b =>
                {
                    b.Property<int>("Publisher_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Publisher_ID"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_ID");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("APITestBed.Models.BookAuthorModel", b =>
                {
                    b.HasOne("APITestBed.Models.AuthorModel", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("Author_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APITestBed.Models.BookModel", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("Book_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("APITestBed.Models.BookPublisherModel", b =>
                {
                    b.HasOne("APITestBed.Models.BookModel", "Book")
                        .WithMany("BookPublishers")
                        .HasForeignKey("Book_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APITestBed.Models.PublisherModel", "Publisher")
                        .WithMany("BookPublishers")
                        .HasForeignKey("Publisher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("APITestBed.Models.AuthorModel", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("APITestBed.Models.BookModel", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("BookPublishers");
                });

            modelBuilder.Entity("APITestBed.Models.PublisherModel", b =>
                {
                    b.Navigation("BookPublishers");
                });
#pragma warning restore 612, 618
        }
    }
}
