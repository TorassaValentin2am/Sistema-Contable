﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelo;

#nullable disable

namespace Modelo.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entidades.AsientoContable", b =>
                {
                    b.Property<int>("AsientoContableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AsientoContableId"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ConceptoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("LibroContableId")
                        .HasColumnType("int");

                    b.Property<long>("Monto")
                        .HasColumnType("bigint");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("AsientoContableId");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.HasIndex("ConceptoId");

                    b.HasIndex("LibroContableId");

                    b.ToTable("AsientoContable");
                });

            modelBuilder.Entity("Entidades.Concepto", b =>
                {
                    b.Property<int>("ConceptoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConceptoId"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConceptoId");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.ToTable("Concepto");
                });

            modelBuilder.Entity("Entidades.LibroContable", b =>
                {
                    b.Property<int>("LibroContableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibroContableId"));

                    b.Property<int>("Año")
                        .HasColumnType("int");

                    b.Property<long>("CapitalActual")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValue(0L);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Mes")
                        .HasColumnType("int");

                    b.HasKey("LibroContableId");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.ToTable("LibroContable");
                });

            modelBuilder.Entity("Entidades.AsientoContable", b =>
                {
                    b.HasOne("Entidades.Concepto", "Concepto")
                        .WithMany()
                        .HasForeignKey("ConceptoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.LibroContable", "LibroContable")
                        .WithMany("AsientosContables")
                        .HasForeignKey("LibroContableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Concepto");

                    b.Navigation("LibroContable");
                });

            modelBuilder.Entity("Entidades.LibroContable", b =>
                {
                    b.Navigation("AsientosContables");
                });
#pragma warning restore 612, 618
        }
    }
}
