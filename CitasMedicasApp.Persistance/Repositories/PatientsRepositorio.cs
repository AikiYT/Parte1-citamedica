using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Entities;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;
using CitasMedicaApp.Domain.Users;
using CitasMedicasApp.Persistance.Base;
using CitasMedicasApp.Persistance.Context;
using CitasMedicasApp.Persistance.Interface.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CitasMedicasApp.Persistance.Repositories
{
    public sealed class PatientsRepositorio : BaseRepository<Patients>, IPatientsRepositorio
    {
        public PatientsRepositorio(CitaContext citaContext) : base(citaContext)
        {
        }

        public async Task<OperationRessult> Add(Patients entity)
        {
            return await Save(entity);
        }

        public async Task<OperationRessult> Delete(int id)
        {
            var patient = await GetEntityBy(id);
            if (patient.Success && patient.Data is Patients entity)
            {
                return await Remove(entity);
            }
            return new OperationRessult(false, "Paciente no encontrado.");
        }

        public async Task<OperationRessult> Exists(Expression<Func<Patients, bool>> filter)
        {
            bool exists = await base.Exists(filter);
            return new OperationRessult(exists, exists ? "Paciente existe." : "Paciente no existe.");
        }

        public async Task<Patients> GetById(int id)
        {
            var result = await GetEntityBy(id);
            return result.Data as Patients;
        }

        public async Task<OperationRessult> Remove(Patients entity)
        {
            return await base.Remove(entity);
        }

        public async Task<OperationRessult> Save(Patients entity)
        {
            return await base.Save(entity);
        }

        public async Task<OperationRessult> Update(Patients entity)
        {
            return await base.Update(entity);
        }

        

          async Task<IEnumerable<Patients>> IPatientsRepositorio.GetAll()
        {
            var result = await base.GetAll();
            return result.Data as List<Patients>;
        }
    }
}
