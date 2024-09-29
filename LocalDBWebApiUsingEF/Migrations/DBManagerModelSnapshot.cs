﻿// <auto-generated />
using System;
using DataTierWebServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataTierWebServer.Migrations
{
    [DbContext(typeof(DBManager))]
    partial class DBManagerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("DataTierWebServer.Models.Account", b =>
                {
                    b.Property<int>("AcctNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Balance")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AcctNo");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AcctNo = 1,
                            Address = "1 Street Suburb",
                            Age = 25u,
                            Balance = 1000,
                            Email = "john.doe@email.com",
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            AcctNo = 2,
                            Address = "2 Street Suburb",
                            Age = 30u,
                            Balance = 2000,
                            Email = "jane.doe@email.com",
                            FirstName = "Jane",
                            LastName = "Doe"
                        },
                        new
                        {
                            AcctNo = 3,
                            Address = "3 Street Suburb",
                            Age = 35u,
                            Balance = 3000,
                            Email = "mike.smith@email.com",
                            FirstName = "Mike",
                            LastName = "Smith"
                        });
                });

            modelBuilder.Entity("DataTierWebServer.Models.UserHistory", b =>
                {
                    b.Property<int>("transaction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AccountAcctNo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HistoryString")
                        .HasColumnType("TEXT");

                    b.HasKey("transaction");

                    b.HasIndex("AccountAcctNo");

                    b.ToTable("UserHistories");
                });

            modelBuilder.Entity("DataTierWebServer.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "1 Street Suburb",
                            Email = "Sajib@email.com",
                            Name = "Sajib",
                            Password = "Sajib123",
                            PhoneNumber = 1234567,
                            ProfilePictureUrl = "SomeImage"
                        },
                        new
                        {
                            Id = 2,
                            Address = "2 Street Suburb",
                            Email = "Mistry@email.com",
                            Name = "Mistry",
                            Password = "Mistry123",
                            PhoneNumber = 2345678,
                            ProfilePictureUrl = "SomeImage"
                        },
                        new
                        {
                            Id = 3,
                            Address = "3 Street Suburb",
                            Email = "Mike@email.com",
                            Name = "Mike",
                            Password = "Mike123",
                            PhoneNumber = 3456789,
                            ProfilePictureUrl = "SomeImage"
                        });
                });

            modelBuilder.Entity("DataTierWebServer.Models.UserHistory", b =>
                {
                    b.HasOne("DataTierWebServer.Models.Account", null)
                        .WithMany("History")
                        .HasForeignKey("AccountAcctNo");
                });

            modelBuilder.Entity("DataTierWebServer.Models.Account", b =>
                {
                    b.Navigation("History");
                });
#pragma warning restore 612, 618
        }
    }
}
