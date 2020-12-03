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
    [Migration("20201129003647_Changes_Entitys_Update_Course_Delete_Wall")]
    partial class Changes_Entitys_Update_Course_Delete_Wall
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
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Profesor"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Alumno"
                        });
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Auth.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<int>("AdressNumber")
                        .HasColumnType("int")
                        .HasMaxLength(10);

                    b.Property<int?>("CellPhone")
                        .HasColumnType("int")
                        .HasMaxLength(50);

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

                    b.Property<int?>("Phone")
                        .HasColumnType("int")
                        .HasMaxLength(10);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .HasColumnType("char(44)");

                    b.Property<string>("TokenRecovery")
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

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
                            AdressNumber = 0,
                            Email = "admin@admin.com",
                            FirstName = "admin",
                            LastName = "admin",
                            Password = "1f929befd4fb5f4c131174552f578eeed0d49521",
                            RoleId = 1,
                            Salt = "MsY/PxAzzyyfGCYAvuxkuYoOHkbcoHLJTTJYeWcBPVM=",
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tecnicatura Universitaria en Desarrollo de Software"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Licenciatura en Higiene y Seguridad"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Licenciatura en Logística"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Licenciatura en Gestión Aeroportuaria"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Licenciatura en Comercio Internacional"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Licenciatura en Turismo"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Tecnicatura Universitaria en Higiene y Seguridad"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Tecnicatura Universitaria en Logística"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Tecnicatura Universitaria en Guía de Turismo"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Tecnicatura Universitaria en Hotelería y Turismo"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Tecnicatura Universitaria en Comercio Internacional y Despacho Aduana"
                        });
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

                    b.Property<DateTime>("Today")
                        .HasColumnType("datetime(6)");

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
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Nogupe.Web.Entities.Courses.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CareerId")
                        .HasColumnType("int");

                    b.Property<int>("CommissionNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MatterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

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

            modelBuilder.Entity("Nogupe.Web.Entities.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
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
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UIdFileName")
                        .IsUnique();

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

                    b.Property<int>("YearId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CareerId");

                    b.HasIndex("YearId");

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

            modelBuilder.Entity("Nogupe.Web.Entities.Years.Year", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Years");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Primer Año"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Segundo Año"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tercer Año"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cuarto Año"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Quinto Año"
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
                    b.HasOne("Nogupe.Web.Entities.Courses.Course", "Course")
                        .WithMany("Comments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nogupe.Web.Entities.Auth.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
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

            modelBuilder.Entity("Nogupe.Web.Entities.File", b =>
                {
                    b.HasOne("Nogupe.Web.Entities.Courses.Course", "Course")
                        .WithMany("Files")
                        .HasForeignKey("CourseId")
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

                    b.HasOne("Nogupe.Web.Entities.Years.Year", "Year")
                        .WithMany("Matters")
                        .HasForeignKey("YearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
