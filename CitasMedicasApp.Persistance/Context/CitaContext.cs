using System;
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
        {

        }
    }

}



