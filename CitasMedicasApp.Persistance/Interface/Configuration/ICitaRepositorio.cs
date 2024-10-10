using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Entities;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;

namespace CitasMedicasApp.Persistance.Interface.Configuration
{
    public interface  ICitaRepositorio : IBaseRepository<Cita>
    {
        Task<OperationRessult> Add(Cita entity);
        Task<OperationRessult> Update(Cita entity);
        Task<OperationRessult> Delete(int id);
        Task<Cita> GetById(int id);
        Task<IEnumerable<Cita>> GetAll();
    }
}
