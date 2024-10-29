﻿// <auto-generated />
using System;
using Leihbuecherrei_GFS;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Leihbuecherrei_GFS.Migrations
{
    [DbContext(typeof(PostgresDBContext))]
    [Migration("20241028160955_UpdateWaitingListToICollection")]
    partial class UpdateWaitingListToICollection
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Leihbuecherrei_GFS.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<bool>("Available")
                        .HasColumnType("boolean");

                    b.Property<string>("Publisher")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Leihbuecherrei_GFS.BorrowEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("BorrowedOn")
                        .HasColumnType("date");

                    b.Property<bool>("Closed")
                        .HasColumnType("boolean");

                    b.Property<DateOnly>("DueTo")
                        .HasColumnType("date");

                    b.Property<int>("ReaderId")
                        .HasColumnType("integer");

                    b.Property<bool>("Returned")
                        .HasColumnType("boolean");

                    b.Property<DateOnly?>("ReturnedOn")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("ReaderId");

                    b.ToTable("BorrowEntries");
                });

            modelBuilder.Entity("Leihbuecherrei_GFS.Reader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly?>("Birthday")
                        .HasColumnType("date");

                    b.Property<int?>("BookId")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("readers");
                });

            modelBuilder.Entity("Leihbuecherrei_GFS.BorrowEntry", b =>
                {
                    b.HasOne("Leihbuecherrei_GFS.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Leihbuecherrei_GFS.Reader", "Reader")
                        .WithMany()
                        .HasForeignKey("ReaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Reader");
                });

            modelBuilder.Entity("Leihbuecherrei_GFS.Reader", b =>
                {
                    b.HasOne("Leihbuecherrei_GFS.Book", null)
                        .WithMany("WaitingList")
                        .HasForeignKey("BookId");
                });

            modelBuilder.Entity("Leihbuecherrei_GFS.Book", b =>
                {
                    b.Navigation("WaitingList");
                });
#pragma warning restore 612, 618
        }
    }
}