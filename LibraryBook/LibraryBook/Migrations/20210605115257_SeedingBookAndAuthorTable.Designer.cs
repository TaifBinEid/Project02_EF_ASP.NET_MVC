﻿// <auto-generated />
using LibraryBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryBook.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605115257_SeedingBookAndAuthorTable")]
    partial class SeedingBookAndAuthorTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LibraryBook.Models.AuthorModel", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuthorEmail")
                        .HasColumnType("text");

                    b.Property<string>("AuthorFirstName")
                        .HasColumnType("text");

                    b.Property<string>("AuthorLastName")
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorID = 1,
                            AuthorEmail = "Andrea@mail.com",
                            AuthorFirstName = "Andrea",
                            AuthorLastName = "Arbasi",
                            Notes = "This author has written great"
                        },
                        new
                        {
                            AuthorID = 2,
                            AuthorEmail = "Jan@mail.com",
                            AuthorFirstName = "Jan",
                            AuthorLastName = "Wengro",
                            Notes = "This author has written great"
                        },
                        new
                        {
                            AuthorID = 3,
                            AuthorEmail = "Pon@mail.com",
                            AuthorFirstName = "Pon",
                            AuthorLastName = "Pattren",
                            Notes = "This author has written great"
                        },
                        new
                        {
                            AuthorID = 4,
                            AuthorEmail = "Alexander@mail.com",
                            AuthorFirstName = " Alexander",
                            AuthorLastName = "Jony",
                            Notes = "This author has written great"
                        },
                        new
                        {
                            AuthorID = 5,
                            AuthorEmail = "Mikel@mail.com",
                            AuthorFirstName = "Mikel",
                            AuthorLastName = "Jon",
                            Notes = "This author has written great"
                        },
                        new
                        {
                            AuthorID = 6,
                            AuthorEmail = "Murray@mail.com",
                            AuthorFirstName = " Murray",
                            AuthorLastName = "Silverstein",
                            Notes = "This author has written great"
                        });
                });

            modelBuilder.Entity("LibraryBook.Models.BookAuthor", b =>
                {
                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<int>("BAId")
                        .HasColumnType("int");

                    b.HasKey("BookID", "AuthorID");

                    b.HasIndex("AuthorID");

                    b.ToTable("BookAuthor");
                });

            modelBuilder.Entity("LibraryBook.Models.BookModel", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdBookStore")
                        .HasColumnType("int");

                    b.Property<int>("NoPage")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("BookID");

                    b.HasIndex("IdBookStore");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookID = 1,
                            IdBookStore = 1,
                            NoPage = 530,
                            Notes = "Good Book !",
                            Price = 103.5f,
                            Title = "Opertaing System"
                        },
                        new
                        {
                            BookID = 2,
                            IdBookStore = 1,
                            NoPage = 400,
                            Notes = "boring book",
                            Price = 99.5f,
                            Title = "Data Structure"
                        },
                        new
                        {
                            BookID = 3,
                            IdBookStore = 1,
                            NoPage = 500,
                            Notes = "Interesting book",
                            Price = 300.5f,
                            Title = "Software Testing"
                        },
                        new
                        {
                            BookID = 4,
                            IdBookStore = 2,
                            NoPage = 300,
                            Notes = "boring book",
                            Price = 200.9f,
                            Title = "Design Pattren"
                        },
                        new
                        {
                            BookID = 5,
                            IdBookStore = 2,
                            NoPage = 250,
                            Notes = "A very useful book",
                            Price = 90.5f,
                            Title = "Learn How To Learn"
                        },
                        new
                        {
                            BookID = 6,
                            IdBookStore = 2,
                            NoPage = 100,
                            Notes = "Interesting book",
                            Price = 88.5f,
                            Title = "Act Like A Success"
                        });
                });

            modelBuilder.Entity("LibraryBook.Models.BookStoreModel", b =>
                {
                    b.Property<int>("IdBookStore")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EmailOfBookStore")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("NameOfBookStore")
                        .HasColumnType("text");

                    b.Property<string>("Telephone")
                        .HasColumnType("text");

                    b.HasKey("IdBookStore");

                    b.ToTable("BookStore");
                });

            modelBuilder.Entity("LibraryBook.Models.BookAuthor", b =>
                {
                    b.HasOne("LibraryBook.Models.AuthorModel", "AuthorModel")
                        .WithMany("BookAuthor")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryBook.Models.BookModel", "BookModel")
                        .WithMany("BookAuthor")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LibraryBook.Models.BookModel", b =>
                {
                    b.HasOne("LibraryBook.Models.BookStoreModel", "BookStoreModel")
                        .WithMany("BookModel")
                        .HasForeignKey("IdBookStore")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
