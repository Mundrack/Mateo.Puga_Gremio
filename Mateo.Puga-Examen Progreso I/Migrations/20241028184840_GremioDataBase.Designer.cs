﻿// <auto-generated />
using System;
using Mateo.Puga_Examen_Progreso_I.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mateo.Puga_Examen_Progreso_I.Migrations
{
    [DbContext(typeof(MateoPuga_Examen_Progreso_IContext))]
    [Migration("20241028184840_GremioDataBase")]
    partial class GremioDataBase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mateo.Puga_Examen_Progreso_I.Models.MP", b =>
                {
                    b.Property<int>("MPID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MPID"));

                    b.Property<string>("MPDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MPFechaPublicacion")
                        .HasColumnType("int");

                    b.Property<DateTime>("MPFechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("MPNameLibro")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("MPID");

                    b.ToTable("MP");
                });
#pragma warning restore 612, 618
        }
    }
}
