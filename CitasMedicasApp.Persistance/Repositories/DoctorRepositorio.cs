using CitasMedicaApp.Domain.Entities;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;
using CitasMedicaApp.Domain.Users;
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
    public sealed class DoctorRepositorio : BaseRepository<Doctors>, IDoctorRepositorio
    {


        public DoctorRepositorio(CitaContext citaContext) : base(citaContext)
        {
        }

        public async Task<OperationRessult> Add(Doctors entity)
        {
            return await Save(entity);
        }

        public async Task<OperationRessult> Delete(int id)
        {
            var doctor = await GetEntityBy(id);
            if (doctor.Success && doctor.Data is Doctors entity)
            {
                return await Remove(entity);
            }
            return new OperationRessult(false, "Doctor no encontrado.");
        }

        public async Task<OperationRessult> Exists(Expression<Func<Doctors, bool>> filter)
        {
            bool exists = await base.Exists(filter);
            return new OperationRessult(exists, exists ? "Doctor existe." : "Doctor no existe.");
        }

        public async Task<Doctors> GetById(int id)
        {
            var result = await GetEntityBy(id);
            return result.Data as Doctors;
        }

        public async Task<OperationRessult> Remove(Doctors entity)
        {
            return await base.Remove(entity);
        }

        public async Task<OperationRessult> Save(Doctors entity)
        {
            return await base.Save(entity);
        }

        public async Task<OperationRessult> Update(Doctors entity)
        {
            return await base.Update(entity);
        }

        Task<bool> IBaseRepository<Doctors>.Exists(Expression<Func<Doctors, bool>> filter)
        {
            throw new NotImplementedException();
        }

         async Task<IEnumerable<Doctors>> IDoctorRepositorio.GetAll()
        {
            var result = await base.GetAll();
            return result.Data as List<Doctors>;
        }
    }
}
