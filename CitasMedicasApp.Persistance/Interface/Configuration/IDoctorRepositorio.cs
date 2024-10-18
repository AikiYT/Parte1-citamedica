

using CitasMedicaApp.Domain.Entities;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;
using CitasMedicaApp.Domain.Users;
using CitasMedicasApp.Persistance.Base;

namespace CitasMedicasApp.Persistance.Interface.Configuration
{
    public interface IDoctorRepositorio : IBaseRepository<Doctors>
    {
        Task<OperationRessult> Add(Doctors entity);
        Task<OperationRessult> Update(Doctors entity);
        Task<OperationRessult> Delete(int id);
        Task<Doctors> GetById(int id);
        Task<IEnumerable<Doctors>> GetAll();

        // CREE ESTA CAPA

    }
}
