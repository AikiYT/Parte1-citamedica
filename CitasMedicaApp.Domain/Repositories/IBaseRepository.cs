
using CitasMedicaApp.Domain.Result;
using System.Linq.Expressions;

namespace CitasMedicaApp.Domain.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {


        Task<OperationRessult> Save(TEntity entity);

        Task<OperationRessult> Update(TEntity entity);

        Task<OperationRessult> Remove(TEntity entity);

        List<OperationRessult> GettAll();
        // tambien puedo crear otro getAll pero en el paremetro debo especificarle que quiero obtener

        Task<OperationRessult> GetEntityBy(int Id);

        Task<bool> Exists(Expression<Func<TEntity, bool>> filter);
        Task<OperationRessult> GetAll();
        
    }
}
