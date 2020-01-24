﻿// <auto-generated />
using System;
using Medical.Ai.Mbdp.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Medical.Ai.Mbdp.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    [Migration("20200123092156_InitDb")]
    partial class InitDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Mbp.EntityFrameworkCore.PermissionModel.MbpMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CodePath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.Property<bool>("HasChildren")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("MenuType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SystemCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("MbpMenus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "root",
                            CodePath = "root",
                            HasChildren = true,
                            IsDeleted = false,
                            Level = 1,
                            MenuType = 0,
                            Name = "医学大数据平台",
                            Order = 1,
                            ParentId = 0,
                            Path = "/"
                        },
                        new
                        {
                            Id = 2,
                            Code = "m10001",
                            CodePath = "root/m10001",
                            HasChildren = true,
                            IsDeleted = false,
                            Level = 2,
                            MenuType = 0,
                            Name = "数据建模系统",
                            Order = 1,
                            ParentId = 1,
                            Path = "/",
                            SystemCode = "mdp"
                        },
                        new
                        {
                            Id = 3,
                            Code = "m20001",
                            CodePath = "root/m20001",
                            HasChildren = true,
                            IsDeleted = false,
                            Level = 2,
                            MenuType = 0,
                            Name = "大数据系统",
                            Order = 1,
                            ParentId = 1,
                            Path = "/",
                            SystemCode = "mbdp"
                        });
                });

            modelBuilder.Entity("Mbp.EntityFrameworkCore.PermissionModel.MbpMenuClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("MbpMenuClaims");
                });

            modelBuilder.Entity("Mbp.EntityFrameworkCore.PermissionModel.MbpOperationLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AppName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClientIP")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Desc")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ModuleName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("OpDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("OpName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("MbpOperationLogs");
                });

            modelBuilder.Entity("Mbp.EntityFrameworkCore.PermissionModel.MbpRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("SystemCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("MbpRoles");
                });

            modelBuilder.Entity("Mbp.EntityFrameworkCore.PermissionModel.MbpRoleMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("RoleId");

                    b.ToTable("MbpRoleMenus");
                });

            modelBuilder.Entity("Mbp.EntityFrameworkCore.PermissionModel.MbpUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LoginName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("SystemCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<int>("UserStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MbpUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsAdmin = true,
                            IsDeleted = false,
                            LoginName = "admin",
                            Password = "94c5fb886bd3cf5f821d239056181a5e",
                            UserName = "admin",
                            UserStatus = 1
                        });
                });

            modelBuilder.Entity("Mbp.EntityFrameworkCore.PermissionModel.MbpUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MenuClaimId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuClaimId");

                    b.HasIndex("UserId");

                    b.ToTable("MbpUserClaims");
                });

            modelBuilder.Entity("Mbp.EntityFrameworkCore.PermissionModel.MbpUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("MbpUserRoles");
                });

            modelBuilder.Entity("Medical.Ai.Mbdp.Domain.DomainEntities.Demo.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Url")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Medical.Ai.Mbdp.Domain.DomainEntities.Demo.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Mbp.EntityFrameworkCore.PermissionModel.MbpMenuClaim", b =>
                {
                    b.HasOne("Mbp.EntityFrameworkCore.PermissionModel.MbpMenu", "Menu")
                        .WithMany("MenuClaims")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mbp.EntityFrameworkCore.PermissionModel.MbpRoleMenu", b =>
                {
                    b.HasOne("Mbp.EntityFrameworkCore.PermissionModel.MbpMenu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mbp.EntityFrameworkCore.PermissionModel.MbpRole", "Role")
                        .WithMany("RoleMenus")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mbp.EntityFrameworkCore.PermissionModel.MbpUserClaim", b =>
                {
                    b.HasOne("Mbp.EntityFrameworkCore.PermissionModel.MbpMenuClaim", "MenuClaim")
                        .WithMany()
                        .HasForeignKey("MenuClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mbp.EntityFrameworkCore.PermissionModel.MbpUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mbp.EntityFrameworkCore.PermissionModel.MbpUserRole", b =>
                {
                    b.HasOne("Mbp.EntityFrameworkCore.PermissionModel.MbpRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mbp.EntityFrameworkCore.PermissionModel.MbpUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Medical.Ai.Mbdp.Domain.DomainEntities.Demo.Post", b =>
                {
                    b.HasOne("Medical.Ai.Mbdp.Domain.DomainEntities.Demo.Blog", null)
                        .WithMany("Posts")
                        .HasForeignKey("BlogId");
                });
#pragma warning restore 612, 618
        }
    }
}