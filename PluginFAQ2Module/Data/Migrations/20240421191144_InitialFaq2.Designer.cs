﻿// <auto-generated />
using System;
using CarrotCake.CMS.Plugins.FAQ2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarrotCake.CMS.Plugins.FAQ2.Data.Migrations
{
    [DbContext(typeof(FaqContext))]
    [Migration("20240421191144_InitialFaq2")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarrotCake.CMS.Plugins.FAQ2.Data.CarrotFaqCategory", b =>
                {
                    b.Property<Guid>("FaqCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FaqCategoryID")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Faqtitle")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("FAQTitle");

                    b.Property<Guid?>("SiteId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("SiteID");

                    b.HasKey("FaqCategoryId")
                        .HasName("carrot_FaqCategory_PK");

                    b.ToTable("carrot_FaqCategory", (string)null);
                });

            modelBuilder.Entity("CarrotCake.CMS.Plugins.FAQ2.Data.CarrotFaqItem", b =>
                {
                    b.Property<Guid>("FaqItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FaqItemID")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Answer")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Caption")
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)");

                    b.Property<Guid>("FaqCategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FaqCategoryID");

                    b.Property<bool?>("IsActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("ItemOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Question")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("FaqItemId")
                        .HasName("carrot_FaqItem_PK");

                    b.HasIndex("FaqCategoryId");

                    b.ToTable("carrot_FaqItem", (string)null);
                });

            modelBuilder.Entity("CarrotCake.CMS.Plugins.FAQ2.Data.CarrotFaqItem", b =>
                {
                    b.HasOne("CarrotCake.CMS.Plugins.FAQ2.Data.CarrotFaqCategory", "FaqCategory")
                        .WithMany("CarrotFaqItems")
                        .HasForeignKey("FaqCategoryId")
                        .IsRequired()
                        .HasConstraintName("carrot_FaqCategory_carrot_FaqItem_FK");

                    b.Navigation("FaqCategory");
                });

            modelBuilder.Entity("CarrotCake.CMS.Plugins.FAQ2.Data.CarrotFaqCategory", b =>
                {
                    b.Navigation("CarrotFaqItems");
                });
#pragma warning restore 612, 618
        }
    }
}
