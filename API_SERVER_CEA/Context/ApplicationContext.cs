﻿using API_SERVER_CEA.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace API_SERVER_CEA.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
       
<<<<<<< HEAD
        public DbSet<User> Usuario { get;set; }
=======
        public DbSet<User> usuario { get;set; }
>>>>>>> 212794b20c6ab599e92a8a52ef6bc04bfa21b669
        public DbSet<Person> Persona { get; set; }
        public DbSet<Role> Rol { get; set; }

        public DbSet<Visit> Visita { get; }
        public DbSet<Institution> Institucion { get; set; }
        public DbSet<InstitutionPerson> Institucion_Persona { get; set; }
        public DbSet<UserRole> UsuarioRol { get; set; }


        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<UserRole>().HasKey(x => new { x.UserId, x.RoleId });
        //    builder.Entity<InstitutionPerson>().HasKey(y => new { y.InstitutionId, y.PersonId });

        //    //Roles
        //    builder.Entity<UserRole>()
        //        .HasOne<Role>(x => x.Role)
        //        .WithMany(a => a.UsuariosRoles)
        //        .HasForeignKey(x => x.RoleId);
        //    //Usuarios
        //    builder.Entity<UserRole>()
        //     .HasOne<User>(x => x.User)
        //     .WithMany(a => a.UsuariosRoles)
        //     .HasForeignKey(x => x.UserId);

        //    //Instituciones
        //    builder.Entity<InstitutionPerson>()
        //       .HasOne<Institution>(x => x.Institucion)
        //       .WithMany(a => a.InstitucionPersona)
        //       .HasForeignKey(x => x.InstitutionId);
        //    //personas
        //    builder.Entity<InstitutionPerson>()
        //     .HasOne<Person>(x => x.Persona)
        //     .WithMany(a => a.InstitucionPersona)
        //     .HasForeignKey(x => x.PersonId);

        //}



    }
    }
