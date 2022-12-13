﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_G06.Data;

#nullable disable

namespace ProjectG06.Migrations
{
    [DbContext(typeof(StudentEmailDbContext))]
    [Migration("20221213190116_studentEmails")]
    partial class studentEmails
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project_G06.Models.StudentEmail", b =>
                {
                    b.Property<int>("S_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("S_Id"));

                    b.Property<string>("S_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("S_Id");

                    b.ToTable("StudentEmails");
                });
#pragma warning restore 612, 618
        }
    }
}
