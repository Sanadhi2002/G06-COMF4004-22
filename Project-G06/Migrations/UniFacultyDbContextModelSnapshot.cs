﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_G06.Data;

#nullable disable

namespace ProjectG06.Migrations
{
    [DbContext(typeof(UniFacultyDbContext))]
    partial class UniFacultyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project_G06.Models.Uni_FacultyModel", b =>
                {
                    b.Property<int>("Uni_Faculty_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Uni_Faculty_ID"));

                    b.Property<string>("Faculty_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Uni_Faculty_ID");

                    b.ToTable("UnifacultyModels");
                });
#pragma warning restore 612, 618
        }
    }
}
