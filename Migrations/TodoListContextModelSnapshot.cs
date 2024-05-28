﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Todo_List_ASPNETCore.DAL;

#nullable disable

namespace Todo_List_ASPNETCore.Migrations
{
    [DbContext(typeof(TodoListContext))]
    partial class TodoListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Todo_List_ASPNETCore.DAL.CATEGORY", b =>
                {
                    b.Property<int>("Category_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_ID"), 1L, 1);

                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Category_ID");

                    b.ToTable("CATEGORY");
                });

            modelBuilder.Entity("Todo_List_ASPNETCore.DAL.TASK", b =>
                {
                    b.Property<int>("Task_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Task_ID"), 1L, 1);

                    b.Property<int>("Category_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Task_Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Task_Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Task_Priority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Task_Status")
                        .HasColumnType("bit");

                    b.Property<string>("Task_Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Task_ID");

                    b.HasIndex("Category_ID");

                    b.ToTable("TASK");
                });

            modelBuilder.Entity("Todo_List_ASPNETCore.DAL.USER", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("USER");
                });

            modelBuilder.Entity("Todo_List_ASPNETCore.DAL.TASK", b =>
                {
                    b.HasOne("Todo_List_ASPNETCore.DAL.CATEGORY", "Category")
                        .WithMany()
                        .HasForeignKey("Category_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
