﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SocialMediaApp.Persistence;

#nullable disable

namespace SocialMediaApp.Persistence.Migrations
{
    [DbContext(typeof(SocialMediaAppDbContext))]
    [Migration("20230824101157_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SocialMediaApp.Domain.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uuid");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("SocialMediaApp.Domain.Follow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("FollowerId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("FollowingId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Follows");
                });

            modelBuilder.Entity("SocialMediaApp.Domain.Like", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("SocialMediaApp.Domain.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsRead")
                        .HasColumnType("boolean");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("SocialMediaApp.Domain.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<List<string>>("HashTag")
                        .HasColumnType("text[]");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("SocialMediaApp.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SocialMediaApp.Domain.Comment", b =>
                {
                    b.HasOne("SocialMediaApp.Domain.Post", null)
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SocialMediaApp.Domain.Follow", b =>
                {
                    b.HasOne("SocialMediaApp.Domain.User", null)
                        .WithMany("Followers")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SocialMediaApp.Domain.Like", b =>
                {
                    b.HasOne("SocialMediaApp.Domain.Post", null)
                        .WithMany("Like")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SocialMediaApp.Domain.Notification", b =>
                {
                    b.HasOne("SocialMediaApp.Domain.User", null)
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SocialMediaApp.Domain.Post", b =>
                {
                    b.HasOne("SocialMediaApp.Domain.User", null)
                        .WithMany("Post")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SocialMediaApp.Domain.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Like");
                });

            modelBuilder.Entity("SocialMediaApp.Domain.User", b =>
                {
                    b.Navigation("Followers");

                    b.Navigation("Notifications");

                    b.Navigation("Post");
                });
#pragma warning restore 612, 618
        }
    }
}
