﻿// <auto-generated />
using System;
using DoItYourSelf_SellItYourSelf.MODEL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoItYourSelf_SellItYourSelf.MODEL.Migrations
{
    [DbContext(typeof(DIYSIYContext))]
    [Migration("20210212220650_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Address", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressTitle")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("CreatedIP")
                        .HasMaxLength(15);

                    b.Property<string>("Disctrict")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FullAddress")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("PostCode")
                        .HasMaxLength(20);

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UpdatedIP")
                        .HasMaxLength(15);

                    b.Property<Guid>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Category", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryImageURL")
                        .HasMaxLength(255);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("CreatedIP")
                        .HasMaxLength(15);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UpdatedIP")
                        .HasMaxLength(15);

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Comment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CommentTitle")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("CreatedIP")
                        .HasMaxLength(15);

                    b.Property<Guid>("PostID");

                    b.Property<Guid?>("ProductID");

                    b.Property<int>("Score");

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UpdatedIP")
                        .HasMaxLength(15);

                    b.Property<Guid>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("PostID");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Image", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("CreatedIP")
                        .HasMaxLength(15);

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<Guid>("PostID");

                    b.Property<Guid>("ProductID");

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("UpdatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UpdatedIP")
                        .HasMaxLength(15);

                    b.HasKey("ID");

                    b.HasIndex("PostID");

                    b.HasIndex("ProductID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Order", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("CreatedIP")
                        .HasMaxLength(15);

                    b.Property<int?>("Discount");

                    b.Property<Guid?>("OrderAddressID");

                    b.Property<DateTime?>("OrderDate");

                    b.Property<Guid?>("PaymentID");

                    b.Property<Guid?>("ShipperID");

                    b.Property<int>("Status");

                    b.Property<decimal>("TotalAmounth");

                    b.Property<int>("TotalPiece");

                    b.Property<string>("UpdatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UpdatedIP")
                        .HasMaxLength(15);

                    b.Property<Guid>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("OrderAddressID");

                    b.HasIndex("PaymentID");

                    b.HasIndex("ShipperID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Payment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("CreatedIP")
                        .HasMaxLength(15);

                    b.Property<int>("Cvc")
                        .HasMaxLength(3);

                    b.Property<DateTime?>("ExpirationDate")
                        .IsRequired()
                        .HasColumnType("Date");

                    b.Property<string>("NameSurname")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UpdatedIP")
                        .HasMaxLength(15);

                    b.HasKey("ID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Post", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryID");

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("CreatedIP")
                        .HasMaxLength(15);

                    b.Property<bool>("ForSale");

                    b.Property<string>("PostDetail")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("PostTitle")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("Rate");

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UpdatedIP")
                        .HasMaxLength(15);

                    b.Property<Guid>("UserID");

                    b.Property<int?>("ViewCount");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("UserID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.PostTag", b =>
                {
                    b.Property<Guid>("PostID");

                    b.Property<Guid>("TagID");

                    b.HasKey("PostID", "TagID");

                    b.HasIndex("TagID");

                    b.ToTable("PostTags");
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Product", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryID");

                    b.Property<string>("Color")
                        .HasMaxLength(20);

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("CreatedIP")
                        .HasMaxLength(15);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<int?>("Discount");

                    b.Property<Guid?>("OrderID");

                    b.Property<Guid>("PostID");

                    b.Property<decimal>("Price");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<int>("Status");

                    b.Property<int>("UnitInStock");

                    b.Property<string>("UpdatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UpdatedIP")
                        .HasMaxLength(15);

                    b.Property<Guid>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("OrderID");

                    b.HasIndex("PostID");

                    b.HasIndex("UserID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Shipper", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("CreatedIP")
                        .HasMaxLength(15);

                    b.Property<string>("Phone")
                        .HasMaxLength(16);

                    b.Property<string>("ShipperName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Status");

                    b.Property<string>("UpdatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UpdatedIP")
                        .HasMaxLength(15);

                    b.HasKey("ID");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Tag", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("CreatedIP")
                        .HasMaxLength(15);

                    b.Property<int>("Status");

                    b.Property<string>("TagDescription")
                        .HasMaxLength(255);

                    b.Property<string>("TagImageUrl")
                        .HasMaxLength(255);

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpdatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UpdatedIP")
                        .HasMaxLength(15);

                    b.HasKey("ID");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountInfo")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("Birthdate");

                    b.Property<string>("CreatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("CreatedIP")
                        .HasMaxLength(15);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Gender")
                        .HasMaxLength(20);

                    b.Property<string>("ImageURL")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.Property<int>("Status");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("UpdatedComputerName")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UpdatedIP")
                        .HasMaxLength(15);

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Address", b =>
                {
                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Comment", b =>
                {
                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductID");

                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Image", b =>
                {
                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.Post", "Post")
                        .WithMany("Images")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Order", b =>
                {
                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.Address", "OrderAddress")
                        .WithMany()
                        .HasForeignKey("OrderAddressID");

                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentID");

                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.Shipper", "Shipper")
                        .WithMany()
                        .HasForeignKey("ShipperID");

                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Post", b =>
                {
                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.PostTag", b =>
                {
                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DoItYourSelf_SellItYourSelf.MODEL.Entities.Product", b =>
                {
                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderID");

                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.Post", "Post")
                        .WithMany("Products")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoItYourSelf_SellItYourSelf.MODEL.Entities.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
