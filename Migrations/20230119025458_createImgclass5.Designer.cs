﻿// <auto-generated />
using System;
using CW_ordermedicine.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CWordermedicine.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230119025458_createImgclass5")]
    partial class createImgclass5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CW_ordermedicine.Data.DataModel.TableProduct", b =>
                {
                    b.Property<int>("IDProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDProduct"));

                    b.Property<string>("NameProduct")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("PriceProduct")
                        .HasColumnType("float");

                    b.Property<int?>("RemainderProduct")
                        .HasColumnType("int");

                    b.Property<string>("StorageProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitProduct")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDProduct");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("CW_ordermedicine.Data.DataModel.TableUser", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CW_ordermedicine.Data.ModelData.ImgClass", b =>
                {
                    b.Property<int>("Imgid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Imgid"));

                    b.Property<byte[]>("Img")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Imgname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Imgid");

                    b.ToTable("Saveimg");
                });

            modelBuilder.Entity("CW_ordermedicine.Data.ModelData.TableGroupMember", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupID"));

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("GroupID");

                    b.ToTable("GroupMember");
                });

            modelBuilder.Entity("CW_ordermedicine.Data.ModelData.TableOrder", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<DateTime>("OrderDateCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderGroupID")
                        .HasColumnType("int");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OrderSumPrice")
                        .HasColumnType("float");

                    b.Property<int>("OrderUserID")
                        .HasColumnType("int");

                    b.Property<string>("OrderUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("CW_ordermedicine.Data.ModelData.TableOrderItem", b =>
                {
                    b.Property<int>("OrderItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemID"));

                    b.Property<int?>("OrderItemOrderID")
                        .HasColumnType("int");

                    b.Property<int?>("OrderItemProductAmount")
                        .HasColumnType("int");

                    b.Property<int?>("OrderItemProductID")
                        .HasColumnType("int");

                    b.Property<string>("OrderItemProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("OrderItemProductPrice")
                        .HasColumnType("float");

                    b.Property<double?>("OrderItemProductSumPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderItemID");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("CW_ordermedicine.Data.ModelData.TableReport", b =>
                {
                    b.Property<int>("ReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportID"));

                    b.Property<DateTime>("ReportDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReportDepartment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReportGroupID")
                        .HasColumnType("int");

                    b.Property<int?>("ReportOrderID")
                        .HasColumnType("int");

                    b.Property<int?>("ReportOrderItemID")
                        .HasColumnType("int");

                    b.Property<double?>("ReportPriceSum")
                        .HasColumnType("float");

                    b.Property<string>("ReportStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReportUserID")
                        .HasColumnType("int");

                    b.Property<string>("ReportUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReportID");

                    b.ToTable("Report");
                });
#pragma warning restore 612, 618
        }
    }
}
