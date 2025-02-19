﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Entities;
using CitasMedicaApp.Domain.Entities.Reservation;
using CitasMedicaApp.Domain.Entities.Security;
using CitasMedicaApp.Domain.Entities.System;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace CitasMedicasApp.Persistance.Context
{
    public partial class CitaContext : DbContext  // este es un objeto principal para conectar la base de datos con el entity framework
    {
        public CitaContext(DbContextOptions<CitaContext> options) : base(options) { }  // este contexto que puse aqui lo esta heredando de la clase base el padre esto nos permite usar cualquier gestor de base de datos
        
        // aqui va un metodo con la conexion al sql pero aun no la tenemos



        #region "Configuration Entities"
        
          public DbSet<Cita>  citas { get; set; }

        public DbSet<Doctors> doctores { get; set; }

         

        public DbSet<Patients> pacientes { get; set; }

        #endregion

        #region "Reserva Entities"
        public DbSet<CancelacionReserva> cancelacionreserva {  get; set; }

        public DbSet<ConfirmacionReserva> confirmacionreserva { get; set; }

        public DbSet<DisponibilidadReserva> disponibilidadReservas { get; set; }        

        public DbSet<NotificacionReserva> notificacionReservas { get; set; }

        public DbSet<RecordatorioReserva> recordatorioReservas { get; set; }

        public DbSet<SolicitudReserva> solicitudReservas { get; set; }

        #endregion

        #region "System Entities"

        public DbSet<Rols> rols {  get; set; }
        public DbSet<Usuario> usuarios { get; set; }

        public DbSet<Notifications> notifications { get; set; }

        public DbSet<Status> statuses { get; set; }

        #endregion

    }

}



