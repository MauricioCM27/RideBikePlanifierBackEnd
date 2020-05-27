﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RideBikePlanifierBackEnd.Models;

namespace RideBikePlanifierBackEnd.Migrations
{
    [DbContext(typeof(RideBikePlanifierContext))]
    [Migration("20200527014647_M3")]
    partial class M3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RideBikePlanifierBackEnd.Models.Amigo", b =>
                {
                    b.Property<string>("usuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("amigo")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("usuario", "amigo");

                    b.HasIndex("amigo");

                    b.ToTable("amigos");
                });

            modelBuilder.Entity("RideBikePlanifierBackEnd.Models.Coordenada", b =>
                {
                    b.Property<int>("ruta")
                        .HasColumnType("int");

                    b.Property<float>("latitud")
                        .HasColumnType("real");

                    b.Property<float>("longitud")
                        .HasColumnType("real");

                    b.HasKey("ruta", "latitud", "longitud");

                    b.ToTable("coordenadas");
                });

            modelBuilder.Entity("RideBikePlanifierBackEnd.Models.Ruta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("comentarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("creador")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("fechaSalida")
                        .HasColumnType("date");

                    b.Property<bool>("isPublica")
                        .HasColumnType("bit");

                    b.Property<float>("kilometrosRecorrer")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("creador");

                    b.ToTable("rutas");
                });

            modelBuilder.Entity("RideBikePlanifierBackEnd.Models.Usuario", b =>
                {
                    b.Property<string>("correoElectronico")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("apellido1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("date");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroEmergencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("padecimientos")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("correoElectronico");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("RideBikePlanifierBackEnd.Models.UsuarioRuta", b =>
                {
                    b.Property<int>("ruta")
                        .HasColumnType("int");

                    b.Property<string>("usuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ambiente")
                        .HasColumnType("int");

                    b.Property<string>("comentariosEvaluacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("dificultad")
                        .HasColumnType("int");

                    b.Property<int?>("evaluacionFinal")
                        .HasColumnType("int");

                    b.Property<bool>("isCalificada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("ruta", "usuario");

                    b.HasIndex("usuario");

                    b.ToTable("usuarioRutas");
                });

            modelBuilder.Entity("RideBikePlanifierBackEnd.Models.Amigo", b =>
                {
                    b.HasOne("RideBikePlanifierBackEnd.Models.Usuario", "amigoNavigation")
                        .WithMany()
                        .HasForeignKey("amigo")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RideBikePlanifierBackEnd.Models.Usuario", "usuarioNavigation")
                        .WithMany()
                        .HasForeignKey("usuario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RideBikePlanifierBackEnd.Models.Coordenada", b =>
                {
                    b.HasOne("RideBikePlanifierBackEnd.Models.Ruta", "rutaNavigation")
                        .WithMany()
                        .HasForeignKey("ruta")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RideBikePlanifierBackEnd.Models.Ruta", b =>
                {
                    b.HasOne("RideBikePlanifierBackEnd.Models.Usuario", "usuarioNavigation")
                        .WithMany()
                        .HasForeignKey("creador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RideBikePlanifierBackEnd.Models.UsuarioRuta", b =>
                {
                    b.HasOne("RideBikePlanifierBackEnd.Models.Ruta", "rutaNavigation")
                        .WithMany()
                        .HasForeignKey("ruta")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RideBikePlanifierBackEnd.Models.Usuario", "usuarioNavigation")
                        .WithMany()
                        .HasForeignKey("usuario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
