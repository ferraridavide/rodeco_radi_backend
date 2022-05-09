﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RodecoRADI.Core.Persistance;

#nullable disable

namespace RodecoRADI.Core.Migrations
{
    [DbContext(typeof(RodecoContext))]
    [Migration("20220508134514_DontMapCoordinates")]
    partial class DontMapCoordinates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RodecoRADI.Core.Persistance.Models.Gallery", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Chainage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GalleryIllumination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GalleryLenght")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MinMaxHeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PavementWidth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectDocumentation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Waterproofing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WidthLeftPedestrianWay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WidthRightPedestrianWay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("YearOfBuild")
                        .HasColumnType("int");

                    b.Property<int?>("nDrainageFacilities")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("RodecoRADI.Core.Persistance.Models.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GalleryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid?>("TunnelId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GalleryId");

                    b.HasIndex("TunnelId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("RodecoRADI.Core.Persistance.Models.Tunnel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TunnelLength")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tunnels");
                });

            modelBuilder.Entity("RodecoRADI.Core.Persistance.Models.Gallery", b =>
                {
                    b.OwnsOne("RodecoRADI.Core.Persistance.Models.EnumOrCustom<RodecoRADI.Core.Persistance.Models.AlignmentShape>", "AlignmentShape", b1 =>
                        {
                            b1.Property<Guid>("GalleryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Custom")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("GalleryId");

                            b1.ToTable("Galleries");

                            b1.WithOwner()
                                .HasForeignKey("GalleryId");
                        });

                    b.OwnsOne("RodecoRADI.Core.Persistance.Models.EnumOrCustom<RodecoRADI.Core.Persistance.Models.AxleShape>", "GalleryAxleShape", b1 =>
                        {
                            b1.Property<Guid>("GalleryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Custom")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("GalleryId");

                            b1.ToTable("Galleries");

                            b1.WithOwner()
                                .HasForeignKey("GalleryId");
                        });

                    b.OwnsOne("RodecoRADI.Core.Persistance.Models.EnumOrCustom<RodecoRADI.Core.Persistance.Models.DrainageSystem>", "DrainageSystem", b1 =>
                        {
                            b1.Property<Guid>("GalleryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Custom")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("GalleryId");

                            b1.ToTable("Galleries");

                            b1.WithOwner()
                                .HasForeignKey("GalleryId");
                        });

                    b.OwnsOne("RodecoRADI.Core.Persistance.Models.EnumOrCustom<RodecoRADI.Core.Persistance.Models.GalleryMaterial>", "Material", b1 =>
                        {
                            b1.Property<Guid>("GalleryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Custom")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("GalleryId");

                            b1.ToTable("Galleries");

                            b1.WithOwner()
                                .HasForeignKey("GalleryId");
                        });

                    b.OwnsOne("RodecoRADI.Core.Persistance.Models.EnumOrCustom<RodecoRADI.Core.Persistance.Models.Installations>", "Installations", b1 =>
                        {
                            b1.Property<Guid>("GalleryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Custom")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("GalleryId");

                            b1.ToTable("Galleries");

                            b1.WithOwner()
                                .HasForeignKey("GalleryId");
                        });

                    b.OwnsOne("RodecoRADI.Core.Persistance.Models.EnumOrCustom<RodecoRADI.Core.Persistance.Models.PavementMaterial>", "PavementMaterial", b1 =>
                        {
                            b1.Property<Guid>("GalleryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Custom")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("GalleryId");

                            b1.ToTable("Galleries");

                            b1.WithOwner()
                                .HasForeignKey("GalleryId");
                        });

                    b.OwnsOne("RodecoRADI.Core.Persistance.Models.EnumOrCustom<RodecoRADI.Core.Persistance.Models.PavementTransverseFall>", "PavementTransverseFall", b1 =>
                        {
                            b1.Property<Guid>("GalleryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Custom")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("GalleryId");

                            b1.ToTable("Galleries");

                            b1.WithOwner()
                                .HasForeignKey("GalleryId");
                        });

                    b.OwnsOne("RodecoRADI.Core.Persistance.Models.EnumOrCustom<RodecoRADI.Core.Persistance.Models.PedestrianWayMaterial>", "PedestrianWayMaterial", b1 =>
                        {
                            b1.Property<Guid>("GalleryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Custom")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("GalleryId");

                            b1.ToTable("Galleries");

                            b1.WithOwner()
                                .HasForeignKey("GalleryId");
                        });

                    b.OwnsOne("RodecoRADI.Core.Persistance.Models.Coordinates", "EndCoordinates", b1 =>
                        {
                            b1.Property<Guid>("GalleryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<double>("Latitude")
                                .HasColumnType("float");

                            b1.Property<double>("Longitude")
                                .HasColumnType("float");

                            b1.HasKey("GalleryId");

                            b1.ToTable("Galleries");

                            b1.WithOwner()
                                .HasForeignKey("GalleryId");
                        });

                    b.OwnsOne("RodecoRADI.Core.Persistance.Models.Coordinates", "StartCoordinates", b1 =>
                        {
                            b1.Property<Guid>("GalleryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<double>("Latitude")
                                .HasColumnType("float");

                            b1.Property<double>("Longitude")
                                .HasColumnType("float");

                            b1.HasKey("GalleryId");

                            b1.ToTable("Galleries");

                            b1.WithOwner()
                                .HasForeignKey("GalleryId");
                        });

                    b.Navigation("AlignmentShape");

                    b.Navigation("DrainageSystem");

                    b.Navigation("EndCoordinates");

                    b.Navigation("GalleryAxleShape");

                    b.Navigation("Installations");

                    b.Navigation("Material");

                    b.Navigation("PavementMaterial");

                    b.Navigation("PavementTransverseFall");

                    b.Navigation("PedestrianWayMaterial");

                    b.Navigation("StartCoordinates");
                });

            modelBuilder.Entity("RodecoRADI.Core.Persistance.Models.Photo", b =>
                {
                    b.HasOne("RodecoRADI.Core.Persistance.Models.Gallery", null)
                        .WithMany("Photos")
                        .HasForeignKey("GalleryId");

                    b.HasOne("RodecoRADI.Core.Persistance.Models.Tunnel", null)
                        .WithMany("Photos")
                        .HasForeignKey("TunnelId");
                });

            modelBuilder.Entity("RodecoRADI.Core.Persistance.Models.Tunnel", b =>
                {
                    b.OwnsOne("RodecoRADI.Core.Persistance.Models.Coordinates", "Coordinates", b1 =>
                        {
                            b1.Property<Guid>("TunnelId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<double>("Latitude")
                                .HasColumnType("float");

                            b1.Property<double>("Longitude")
                                .HasColumnType("float");

                            b1.HasKey("TunnelId");

                            b1.ToTable("Tunnels");

                            b1.WithOwner()
                                .HasForeignKey("TunnelId");
                        });

                    b.Navigation("Coordinates")
                        .IsRequired();
                });

            modelBuilder.Entity("RodecoRADI.Core.Persistance.Models.Gallery", b =>
                {
                    b.Navigation("Photos");
                });

            modelBuilder.Entity("RodecoRADI.Core.Persistance.Models.Tunnel", b =>
                {
                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
