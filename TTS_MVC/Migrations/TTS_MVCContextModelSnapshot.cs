﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TTS_MVC.Data;

namespace TTS_MVC.Migrations
{
    [DbContext(typeof(TTS_MVCContext))]
    partial class TTS_MVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TTS_MVC.Models.Employee", b =>
                {
                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EID")
                        .HasColumnType("int");

                    b.Property<string>("Employee_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Hire_Date")
                        .HasColumnType("datetime2");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("TTS_MVC.Models.Ticket", b =>
                {
                    b.Property<int>("Ticket_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoggedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RaisedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Resolution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResolvedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ResolvedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Severity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ticket_Desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ticket_Id");

                    b.ToTable("Ticket");
                });
#pragma warning restore 612, 618
        }
    }
}
