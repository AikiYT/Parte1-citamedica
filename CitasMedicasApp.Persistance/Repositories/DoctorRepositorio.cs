using CitasMedicaApp.Domain.Entities;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;
using CitasMedicasApp.Persistance.Base;
using CitasMedicasApp.Persistance.Context;
using CitasMedicasApp.Persistance.Interface.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicasApp.Persistance.Repositories
{
    public sealed class DoctorRepositorio : BaseRepository<Doctor>, IDoctorRepositorio
    {


        public DoctorRepositorio(CitaContext citaContext) : base(citaContext)
        {
        }

        public Task<OperationRessult> Exists(Expression<Func<Cita, bool>> filter)
        {
            throw new NotImplementedException();
        }
         
        public Task<OperationRessult> Remove(Cita entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Save(Cita entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationRessult> Update(Cita entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IBaseRepository<Cita>.Exists(Expression<Func<Cita, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
