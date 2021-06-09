﻿// <auto-generated />
using System;
using EF_Project_Demo.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_Project_Demo.Migrations
{
    [DbContext(typeof(WorkShopContext))]
    [Migration("20210609071443_WorkShop_V3")]
    partial class WorkShop_V3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF_Project_Demo.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<int?>("FK_Category")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("FK_Category");

                    b.ToTable("DANHMUC");
                });

            modelBuilder.Entity("EF_Project_Demo.Model.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("ntext")
                        .HasMaxLength(50);

                    b.HasKey("ProductID");

                    b.ToTable("SANPHAM");
                });

            modelBuilder.Entity("EF_Project_Demo.Model.Category", b =>
                {
                    b.HasOne("EF_Project_Demo.Model.Product", null)
                        .WithMany("Categories")
                        .HasForeignKey("FK_Category");
                });
#pragma warning restore 612, 618
        }
    }
}
