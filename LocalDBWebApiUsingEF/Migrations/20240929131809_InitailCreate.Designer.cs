﻿// <auto-generated />
using DataTierWebServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataTierWebServer.Migrations
{
    [DbContext(typeof(DBManager))]
    [Migration("20240929131809_InitailCreate")]
    partial class InitailCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("DataTierWebServer.Models.Account", b =>
                {
                    b.Property<uint>("AcctNo")
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
                            AcctNo = 7791u,
                            Address = "972 Samuel Phillips St.",
                            Age = 21u,
                            Balance = 59523,
                            Email = "Christine.Robinson746@gmail.com",
                            FirstName = "Christine",
                            LastName = "Robinson"
                        },
                        new
                        {
                            AcctNo = 5441u,
                            Address = "205 Jeffrey Martin St.",
                            Age = 39u,
                            Balance = 11708,
                            Email = "Paul.Watson481@gmail.com",
                            FirstName = "Paul",
                            LastName = "Watson"
                        },
                        new
                        {
                            AcctNo = 6390u,
                            Address = "83 Steven Lewis St.",
                            Age = 31u,
                            Balance = 21411,
                            Email = "Brian.Edwards381@gmail.com",
                            FirstName = "Brian",
                            LastName = "Edwards"
                        },
                        new
                        {
                            AcctNo = 8839u,
                            Address = "703 Stephen Walker St.",
                            Age = 106u,
                            Balance = 28671,
                            Email = "Raymond.Ward918@gmail.com",
                            FirstName = "Raymond",
                            LastName = "Ward"
                        },
                        new
                        {
                            AcctNo = 3937u,
                            Address = "7 William Lewis St.",
                            Age = 74u,
                            Balance = 90378,
                            Email = "Rebecca.Thompson413@gmail.com",
                            FirstName = "Rebecca",
                            LastName = "Thompson"
                        },
                        new
                        {
                            AcctNo = 7524u,
                            Address = "220 Emma Campbell St.",
                            Age = 93u,
                            Balance = 50349,
                            Email = "Matthew.Ward780@gmail.com",
                            FirstName = "Matthew",
                            LastName = "Ward"
                        },
                        new
                        {
                            AcctNo = 5181u,
                            Address = "57 Paul Lee St.",
                            Age = 61u,
                            Balance = 93063,
                            Email = "Gary.Ruiz653@gmail.com",
                            FirstName = "Gary",
                            LastName = "Ruiz"
                        },
                        new
                        {
                            AcctNo = 5291u,
                            Address = "511 Kimberly Price St.",
                            Age = 91u,
                            Balance = 24207,
                            Email = "Sharon.Nelson345@gmail.com",
                            FirstName = "Sharon",
                            LastName = "Nelson"
                        },
                        new
                        {
                            AcctNo = 2135u,
                            Address = "388 Amanda Wright St.",
                            Age = 58u,
                            Balance = 34686,
                            Email = "Sandra.Evans781@gmail.com",
                            FirstName = "Sandra",
                            LastName = "Evans"
                        },
                        new
                        {
                            AcctNo = 6680u,
                            Address = "240 Mark Ramos St.",
                            Age = 69u,
                            Balance = 61961,
                            Email = "Donald.Thompson989@gmail.com",
                            FirstName = "Donald",
                            LastName = "Thompson"
                        });
                });

            modelBuilder.Entity("DataTierWebServer.Models.UserHistory", b =>
                {
                    b.Property<int>("Transaction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HistoryString")
                        .HasColumnType("TEXT");

                    b.HasKey("Transaction");

                    b.HasIndex("AccountId");

                    b.ToTable("UserHistories");

                    b.HasData(
                        new
                        {
                            Transaction = 1,
                            AccountId = 2135u,
                            HistoryString = "Balance updated by -202 on 29/09/2024 9:18:09 PM.  | Old Balance: 35054 ----- New Balance: 34852"
                        },
                        new
                        {
                            Transaction = 2,
                            AccountId = 6680u,
                            HistoryString = "Balance updated by -362 on 29/09/2024 9:18:09 PM.  | Old Balance: 62645 ----- New Balance: 62283"
                        },
                        new
                        {
                            Transaction = 3,
                            AccountId = 6680u,
                            HistoryString = "Balance updated by -322 on 29/09/2024 9:18:09 PM.  | Old Balance: 62283 ----- New Balance: 61961"
                        },
                        new
                        {
                            Transaction = 4,
                            AccountId = 7524u,
                            HistoryString = "Balance updated by 615 on 29/09/2024 9:18:09 PM.  | Old Balance: 49734 ----- New Balance: 50349"
                        },
                        new
                        {
                            Transaction = 5,
                            AccountId = 8839u,
                            HistoryString = "Balance updated by 287 on 29/09/2024 9:18:09 PM.  | Old Balance: 28384 ----- New Balance: 28671"
                        },
                        new
                        {
                            Transaction = 6,
                            AccountId = 2135u,
                            HistoryString = "Balance updated by -166 on 29/09/2024 9:18:09 PM.  | Old Balance: 34852 ----- New Balance: 34686"
                        },
                        new
                        {
                            Transaction = 7,
                            AccountId = 3937u,
                            HistoryString = "Balance updated by 894 on 29/09/2024 9:18:09 PM.  | Old Balance: 89484 ----- New Balance: 90378"
                        },
                        new
                        {
                            Transaction = 8,
                            AccountId = 5181u,
                            HistoryString = "Balance updated by 494 on 29/09/2024 9:18:09 PM.  | Old Balance: 92569 ----- New Balance: 93063"
                        },
                        new
                        {
                            Transaction = 9,
                            AccountId = 7791u,
                            HistoryString = "Balance updated by 170 on 29/09/2024 9:18:09 PM.  | Old Balance: 59353 ----- New Balance: 59523"
                        },
                        new
                        {
                            Transaction = 10,
                            AccountId = 5441u,
                            HistoryString = "Balance updated by -836 on 29/09/2024 9:18:09 PM.  | Old Balance: 12544 ----- New Balance: 11708"
                        });
                });

            modelBuilder.Entity("DataTierWebServer.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<uint>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "972 Samuel Phillips St.",
                            Age = 21u,
                            Email = "Christine.Robinson746@gmail.com",
                            FName = "Christine",
                            LName = "Robinson",
                            Password = "xSaxuJoHbv2i",
                            PhoneNumber = "+9616801591",
                            Username = "Christine.Robinson129"
                        },
                        new
                        {
                            Id = 2,
                            Address = "205 Jeffrey Martin St.",
                            Age = 39u,
                            Email = "Paul.Watson481@gmail.com",
                            FName = "Paul",
                            LName = "Watson",
                            Password = "VhA0jBMtEj30",
                            PhoneNumber = "+9612108257",
                            Username = "Paul.Watson677"
                        },
                        new
                        {
                            Id = 3,
                            Address = "83 Steven Lewis St.",
                            Age = 31u,
                            Email = "Brian.Edwards381@gmail.com",
                            FName = "Brian",
                            LName = "Edwards",
                            Password = "5dm706TEem6l",
                            PhoneNumber = "+9619954485",
                            Username = "Brian.Edwards208"
                        },
                        new
                        {
                            Id = 4,
                            Address = "703 Stephen Walker St.",
                            Age = 106u,
                            Email = "Raymond.Ward918@gmail.com",
                            FName = "Raymond",
                            LName = "Ward",
                            Password = "oXLWhyRQze0D",
                            PhoneNumber = "+9619016293",
                            Username = "Raymond.Ward613"
                        },
                        new
                        {
                            Id = 5,
                            Address = "7 William Lewis St.",
                            Age = 74u,
                            Email = "Rebecca.Thompson413@gmail.com",
                            FName = "Rebecca",
                            LName = "Thompson",
                            Password = "4idqNemvKokn",
                            PhoneNumber = "+9616432720",
                            Username = "Rebecca.Thompson266"
                        },
                        new
                        {
                            Id = 6,
                            Address = "220 Emma Campbell St.",
                            Age = 93u,
                            Email = "Matthew.Ward780@gmail.com",
                            FName = "Matthew",
                            LName = "Ward",
                            Password = "u3QPp8aoRqNX",
                            PhoneNumber = "+9615284552",
                            Username = "Matthew.Ward511"
                        },
                        new
                        {
                            Id = 7,
                            Address = "57 Paul Lee St.",
                            Age = 61u,
                            Email = "Gary.Ruiz653@gmail.com",
                            FName = "Gary",
                            LName = "Ruiz",
                            Password = "c8s9ys23O1eb",
                            PhoneNumber = "+9618706389",
                            Username = "Gary.Ruiz793"
                        },
                        new
                        {
                            Id = 8,
                            Address = "511 Kimberly Price St.",
                            Age = 91u,
                            Email = "Sharon.Nelson345@gmail.com",
                            FName = "Sharon",
                            LName = "Nelson",
                            Password = "ZbvJkh49jtIh",
                            PhoneNumber = "+9619698518",
                            Username = "Sharon.Nelson636"
                        },
                        new
                        {
                            Id = 9,
                            Address = "388 Amanda Wright St.",
                            Age = 58u,
                            Email = "Sandra.Evans781@gmail.com",
                            FName = "Sandra",
                            LName = "Evans",
                            Password = "2CzTbn7Bsy0i",
                            PhoneNumber = "+9617062497",
                            Username = "Sandra.Evans707"
                        },
                        new
                        {
                            Id = 10,
                            Address = "240 Mark Ramos St.",
                            Age = 69u,
                            Email = "Donald.Thompson989@gmail.com",
                            FName = "Donald",
                            LName = "Thompson",
                            Password = "TPIIbKdnt8cE",
                            PhoneNumber = "+9616922122",
                            Username = "Donald.Thompson333"
                        });
                });

            modelBuilder.Entity("DataTierWebServer.Models.UserHistory", b =>
                {
                    b.HasOne("DataTierWebServer.Models.Account", null)
                        .WithMany("History")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataTierWebServer.Models.Account", b =>
                {
                    b.Navigation("History");
                });
#pragma warning restore 612, 618
        }
    }
}
