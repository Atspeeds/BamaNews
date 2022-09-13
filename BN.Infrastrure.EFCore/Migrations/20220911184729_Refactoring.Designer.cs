﻿// <auto-generated />
using System;
using BN.Infrastrure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BN.Infrastrure.EFCore.Migrations
{
    [DbContext(typeof(BamaNewsContext))]
    [Migration("20220911184729_Refactoring")]
    partial class Refactoring
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BN.Domain.CommentAgg.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Creationdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("NewsId")
                        .HasColumnType("int");

                    b.Property<int>("StatusComment")
                        .HasColumnType("int");

                    b.Property<string>("TitleComment")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NewsId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("BN.Domain.NewsAgg.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Creationdate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("NewsCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("NewsContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsShortDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("NewsTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("NewsCategoryId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("BN.Domain.NewsCategoryAgg.NewsCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Creationdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("NewsCategories");
                });

            modelBuilder.Entity("BN.Domain.UserAgg.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Creationdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Passwoard")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UserAvatar")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BN.Domain.CommentAgg.Comment", b =>
                {
                    b.HasOne("BN.Domain.NewsAgg.News", "News")
                        .WithMany("Comments")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BN.Domain.UserAgg.User", "Users")
                        .WithMany("Comment")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("News");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BN.Domain.NewsAgg.News", b =>
                {
                    b.HasOne("BN.Domain.NewsCategoryAgg.NewsCategory", "NewsCategory")
                        .WithMany("News")
                        .HasForeignKey("NewsCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NewsCategory");
                });

            modelBuilder.Entity("BN.Domain.NewsAgg.News", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BN.Domain.NewsCategoryAgg.NewsCategory", b =>
                {
                    b.Navigation("News");
                });

            modelBuilder.Entity("BN.Domain.UserAgg.User", b =>
                {
                    b.Navigation("Comment");
                });
#pragma warning restore 612, 618
        }
    }
}
