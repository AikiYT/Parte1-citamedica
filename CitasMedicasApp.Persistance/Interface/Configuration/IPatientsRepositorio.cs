using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Entities;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;
using CitasMedicaApp.Domain.Users;

namespace CitasMedicasApp.Persistance.Interface.Configuration
{
    public interface IPatientsRepositorio : IBaseRepository<Patients>
    {
        Task<OperationRessult> Add(Patients entity);
        Task<OperationRessult> Update(Patients entity);
        Task<OperationRessult> Delete(int id);
        Task<Patients> GetById(int id);
        Task<IEnumerable<Patients>> GetAll();

    }
}
