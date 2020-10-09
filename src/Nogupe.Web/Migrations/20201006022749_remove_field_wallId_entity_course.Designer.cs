﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nogupe.Web.Data;

namespace Nogupe.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201006022749_remove_field_wallId_entity_course")]
    partial class remove_field_wallId_entity_course
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Nogupe.Web.Entities.Auth.RoleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("RoleTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "profesor"
                        },
                        new
                        {
                            Id = 3,
                            Name = "alumno"
                        });
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Auth.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(254) CHARACTER SET utf8mb4")
                        .HasMaxLength(254);

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasColumnType("char(40)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .HasColumnType("char(44)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(25) CHARACTER SET utf8mb4")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@admin.com",
                            FirstName = "admin",
                            LastName = "admin",
                            Password = "f25d07e690df882c5ac2ba43910e8c070120db55",
                            RoleId = 1,
                            Salt = "FMlOJJArrPB5GHatdjzrgSGHXb0JwB/KgebjMkZnhr0=",
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Careers.Career", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Careers");
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Assistance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("Assistances");
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Commentary")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<int>("WallId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FileId");

                    b.HasIndex("WallId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CareerId")
                        .HasColumnType("int");

                    b.Property<int>("MatterId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WeekdayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CareerId");

                    b.HasIndex("MatterId");

                    b.HasIndex("UserId");

                    b.HasIndex("WeekdayId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<int>("WallId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FileId");

                    b.HasIndex("WallId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Inscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("ENUM('Accepted','Pending','Rejected')")
                        .HasDefaultValue("Pending");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("Inscriptions");
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("FinalNote")
                        .HasColumnType("int");

                    b.Property<int>("OnePartial")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("ENUM('None','Regular','Postponed','Promotion')")
                        .HasDefaultValue("None");

                    b.Property<int>("TwoPartial")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Token", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Wall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.ToTable("Walls");
                });

            modelBuilder.Entity("Nogupe.Web.Entities.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DirName")
                        .IsRequired()
                        .HasColumnType("varchar(260) CHARACTER SET utf8mb4")
                        .HasMaxLength(260);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("UIdFileName")
                        .IsRequired()
                        .HasColumnType("varchar(260) CHARACTER SET utf8mb4")
                        .HasMaxLength(260);

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Matters.Matter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CareerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CareerId");

                    b.ToTable("Matters");
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Weekdays.Weekday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Weekdays");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Lunes 08hs-12hs"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lunes 18hs-22hs"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Martes 08hs-12hs"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Martes 18hs-22hs"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Miércoles 08hs-12hs"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Miércoles 18hs-22hs"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Jueves 08hs-12hs"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Jueves 18hs-22hs"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Viernes 08hs-12hs"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Viernes 18hs-22hs"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Sábado 08hs-12hs"
                        });
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Auth.User", b =>
                {
                    b.HasOne("Nogupe.Web.Entities.Auth.RoleType", "RoleType")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Assistance", b =>
                {
                    b.HasOne("Nogupe.Web.Entities.Courses.Course", "Course")
                        .WithMany("Assistances")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nogupe.Web.Entities.Auth.User", "User")
                        .WithMany("Assistances")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Comment", b =>
                {
                    b.HasOne("Nogupe.Web.Entities.File", "File")
                        .WithMany()
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nogupe.Web.Entities.Courses.Wall", "Wall")
                        .WithMany("Comments")
                        .HasForeignKey("WallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Course", b =>
                {
                    b.HasOne("Nogupe.Web.Entities.Careers.Career", "Career")
                        .WithMany()
                        .HasForeignKey("CareerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nogupe.Web.Entities.Matters.Matter", "Matter")
                        .WithMany("Courses")
                        .HasForeignKey("MatterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nogupe.Web.Entities.Auth.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nogupe.Web.Entities.Weekdays.Weekday", "Weekday")
                        .WithMany()
                        .HasForeignKey("WeekdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Document", b =>
                {
                    b.HasOne("Nogupe.Web.Entities.File", "File")
                        .WithMany()
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nogupe.Web.Entities.Courses.Wall", "Wall")
                        .WithMany("Documents")
                        .HasForeignKey("WallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Inscription", b =>
                {
                    b.HasOne("Nogupe.Web.Entities.Courses.Course", "Course")
                        .WithMany("Inscriptions")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nogupe.Web.Entities.Auth.User", "User")
                        .WithMany("Inscriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Rating", b =>
                {
                    b.HasOne("Nogupe.Web.Entities.Courses.Course", "Course")
                        .WithMany("Ratings")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nogupe.Web.Entities.Auth.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Token", b =>
                {
                    b.HasOne("Nogupe.Web.Entities.Courses.Course", "Course")
                        .WithMany("Tokens")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Wall", b =>
                {
                    b.HasOne("Nogupe.Web.Entities.Courses.Course", "Course")
                        .WithOne("Wall")
                        .HasForeignKey("Nogupe.Web.Entities.Courses.Wall", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Matters.Matter", b =>
                {
                    b.HasOne("Nogupe.Web.Entities.Careers.Career", "Career")
                        .WithMany("Matters")
                        .HasForeignKey("CareerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}