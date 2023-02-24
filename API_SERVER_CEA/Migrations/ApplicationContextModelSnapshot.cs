﻿// <auto-generated />
using System;
using API_SERVER_CEA.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_SERVER_CEA.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API_SERVER_CEA.Models.Institution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Institucion");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.InstitutionPerson", b =>
                {
                    b.Property<int>("InstitutionId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("InstitutionId", "PersonId");

                    b.HasIndex("PersonId");

                    b.ToTable("Institucion_Persona");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Celular")
                        .HasColumnType("int");

                    b.Property<int>("Ci")
                        .HasColumnType("int");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisitId");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Contrasenia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("Usuario_Roles");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.Visit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lugar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Visita");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.InstitutionPerson", b =>
                {
                    b.HasOne("API_SERVER_CEA.Models.Institution", "Institucion")
                        .WithMany("InstitucionPersona")
                        .HasForeignKey("InstitutionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_SERVER_CEA.Models.Person", "Persona")
                        .WithMany("InstitucionPersona")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Institucion");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.Person", b =>
                {
                    b.HasOne("API_SERVER_CEA.Models.Visit", "Visit")
                        .WithMany("Personas")
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Visit");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.UserRole", b =>
                {
                    b.HasOne("API_SERVER_CEA.Models.Role", "Role")
                        .WithMany("UsuariosRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_SERVER_CEA.Models.User", "User")
                        .WithMany("UsuariosRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.Institution", b =>
                {
                    b.Navigation("InstitucionPersona");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.Person", b =>
                {
                    b.Navigation("InstitucionPersona");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.Role", b =>
                {
                    b.Navigation("UsuariosRoles");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.User", b =>
                {
                    b.Navigation("UsuariosRoles");
                });

            modelBuilder.Entity("API_SERVER_CEA.Models.Visit", b =>
                {
                    b.Navigation("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
