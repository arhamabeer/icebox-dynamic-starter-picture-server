﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using icebox_dynamic_starter_picture_server;

#nullable disable

namespace icebox_dynamic_starter_picture_server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230626075718_isdeleted")]
    partial class isdeleted
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("icebox_dynamic_starter_picture_server.Models.Images", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"));

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("ImageId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ImageId = 1,
                            Path = "images1/jpg",
                            Type = "Eid",
                            isDeleted = false
                        },
                        new
                        {
                            ImageId = 2,
                            Path = "images2/jpg",
                            Type = "Ramadan",
                            isDeleted = false
                        },
                        new
                        {
                            ImageId = 3,
                            Path = "images3/jpg",
                            Type = "Hajj",
                            isDeleted = false
                        },
                        new
                        {
                            ImageId = 4,
                            Path = "images4/jpg",
                            Type = "New Year",
                            isDeleted = false
                        },
                        new
                        {
                            ImageId = 5,
                            Path = "images5/jpg",
                            Type = "Default",
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("icebox_dynamic_starter_picture_server.Models.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Machines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ip = "192.168.0.1",
                            Location = "Miami",
                            Name = "Icebox"
                        },
                        new
                        {
                            Id = 2,
                            Ip = "192.168.0.2",
                            Location = "California",
                            Name = "Icebox"
                        },
                        new
                        {
                            Id = 3,
                            Ip = "192.168.0.3",
                            Location = "Washington",
                            Name = "Icebox"
                        },
                        new
                        {
                            Id = 4,
                            Ip = "192.168.0.4",
                            Location = "Boston",
                            Name = "Icebox"
                        },
                        new
                        {
                            Id = 5,
                            Ip = "192.168.0.5",
                            Location = "St. Jons",
                            Name = "Icebox"
                        },
                        new
                        {
                            Id = 6,
                            Ip = "192.168.0.6",
                            Location = "Florida",
                            Name = "Icebox"
                        },
                        new
                        {
                            Id = 7,
                            Ip = "192.168.0.7",
                            Location = "Audi",
                            Name = "Icebox"
                        },
                        new
                        {
                            Id = 8,
                            Ip = "192.168.0.8",
                            Location = "New Jersey",
                            Name = "Icebox"
                        },
                        new
                        {
                            Id = 9,
                            Ip = "192.168.0.9",
                            Location = "Karachi",
                            Name = "Icebox"
                        });
                });

            modelBuilder.Entity("icebox_dynamic_starter_picture_server.Models.Machine", b =>
                {
                    b.HasOne("icebox_dynamic_starter_picture_server.Models.Images", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.Navigation("Image");
                });
#pragma warning restore 612, 618
        }
    }
}
