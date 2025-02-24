﻿// <auto-generated />
using LibraryBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryBook.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605115059_AllTableInDB")]
    partial class AllTableInDB
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
