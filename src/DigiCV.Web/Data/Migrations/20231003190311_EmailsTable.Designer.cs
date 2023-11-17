﻿// <auto-generated />
using System;
using DigiCV.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DigiCV.Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231003190311_EmailsTable")]
    partial class EmailsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DigiCV.Domain.Entities.Cv", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedIn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Skype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trainings")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Cv");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("CvId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PassingYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CvId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSent")
                        .HasColumnType("bit");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Companay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CvId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ResignationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CvId");

                    b.ToTable("Experience");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CvId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CvId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Reference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Compnay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CvId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CvId");

                    b.ToTable("Reference");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.SkillCv", b =>
                {
                    b.Property<Guid>("CvId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("CvId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillCv");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GithubUsername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LinkedInUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserProfile");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9749e4e1-f89c-42bd-8a04-5a79993a58f9"),
                            Address = "Room No. 419, BSMRH Hall, MBSTU",
                            Designation = ".NET Developer",
                            Education = "Mawlana Bhashani Science and Technology University, Tangail",
                            Experience = "C#, ASP.NET, EF Core",
                            GithubUsername = "absa1am",
                            IsActive = true,
                            LinkedInUsername = "absa1am"
                        },
                        new
                        {
                            Id = new Guid("a618e70b-3cdb-420a-a1b3-702d0b06e9c2"),
                            Address = "Room No. 419, BSMRH Hall, MBSTU",
                            Designation = ".NET Developer",
                            Education = "Mawlana Bhashani Science and Technology University, Tangail",
                            Experience = "C#, ASP.NET, EF Core",
                            GithubUsername = "absa1am",
                            IsActive = true,
                            LinkedInUsername = "absa1am"
                        });
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("UserProfileId");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e26967f0-ce4c-4c14-8a0b-45beb8c9eb48"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7dc50426-639f-492d-b579-38b3a8786fe6",
                            Email = "admin@digicv.com",
                            EmailConfirmed = true,
                            FullName = "Admin",
                            JoiningDate = new DateTime(2023, 10, 4, 1, 3, 10, 561, DateTimeKind.Local).AddTicks(7847),
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@DIGICV.COM",
                            NormalizedUserName = "ADMIN@DIGICV.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEB20grptU/I4oN3D+m3vl1pAeSoxoiAuxF7j01KpGqXcCn4EBUs7FgrF3/hdtFkc3w==",
                            PhoneNumber = "+8801856817465",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "BFCC7B453A8B4B6C8A4C93EE28A3B4A8",
                            TwoFactorEnabled = false,
                            UserName = "admin@digicv.com",
                            UserProfileId = new Guid("9749e4e1-f89c-42bd-8a04-5a79993a58f9")
                        },
                        new
                        {
                            Id = new Guid("5f4c76d3-79b0-4923-86a7-511ac60c2ab9"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "20e5fb16-6ee5-4625-813f-c8a783fda185",
                            Email = "manager@digicv.com",
                            EmailConfirmed = true,
                            FullName = "Manager",
                            JoiningDate = new DateTime(2023, 10, 4, 1, 3, 10, 633, DateTimeKind.Local).AddTicks(5301),
                            LockoutEnabled = true,
                            NormalizedEmail = "MANAGER@DIGICV.COM",
                            NormalizedUserName = "MANAGER@DIGICV.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDiZgn6y/nHsudX0cvbxDZrsDOjgZm3lA2J098OVNhYmtTY8+S5eyi7vsPDpV0N5tQ==",
                            PhoneNumber = "+8801856817465",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "FC37C84E276C4D978DF9054129D0CB23",
                            TwoFactorEnabled = false,
                            UserName = "manager@digicv.com",
                            UserProfileId = new Guid("a618e70b-3cdb-420a-a1b3-702d0b06e9c2")
                        });
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "Administrator",
                            ClaimValue = "Administrator",
                            UserId = new Guid("e26967f0-ce4c-4c14-8a0b-45beb8c9eb48")
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "Manager",
                            ClaimValue = "Manager",
                            UserId = new Guid("5f4c76d3-79b0-4923-86a7-511ac60c2ab9")
                        });
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Cv", b =>
                {
                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationUser", null)
                        .WithMany("Cvs")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Education", b =>
                {
                    b.HasOne("DigiCV.Domain.Entities.Cv", "Cv")
                        .WithMany("Educations")
                        .HasForeignKey("CvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cv");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Experience", b =>
                {
                    b.HasOne("DigiCV.Domain.Entities.Cv", "Cv")
                        .WithMany("Experiences")
                        .HasForeignKey("CvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cv");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Project", b =>
                {
                    b.HasOne("DigiCV.Domain.Entities.Cv", "Cv")
                        .WithMany("Projects")
                        .HasForeignKey("CvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cv");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Reference", b =>
                {
                    b.HasOne("DigiCV.Domain.Entities.Cv", "Cv")
                        .WithMany("References")
                        .HasForeignKey("CvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cv");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.SkillCv", b =>
                {
                    b.HasOne("DigiCV.Domain.Entities.Cv", "Cv")
                        .WithMany("Skills")
                        .HasForeignKey("CvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigiCV.Domain.Entities.Skill", "Skill")
                        .WithMany("Cvs")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cv");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationRoleClaim", b =>
                {
                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUser", b =>
                {
                    b.HasOne("DigiCV.Domain.Entities.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserClaim", b =>
                {
                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserLogin", b =>
                {
                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserRole", b =>
                {
                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUserToken", b =>
                {
                    b.HasOne("DigiCV.Persistence.Features.Membership.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Cv", b =>
                {
                    b.Navigation("Educations");

                    b.Navigation("Experiences");

                    b.Navigation("Projects");

                    b.Navigation("References");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("DigiCV.Domain.Entities.Skill", b =>
                {
                    b.Navigation("Cvs");
                });

            modelBuilder.Entity("DigiCV.Persistence.Features.Membership.ApplicationUser", b =>
                {
                    b.Navigation("Cvs");
                });
#pragma warning restore 612, 618
        }
    }
}
