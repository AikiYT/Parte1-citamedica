using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CitasMedicaApp.Domain.Repositories;
using CitasMedicaApp.Domain.Result;
using CitasMedicasApp.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace CitasMedicasApp.Persistance.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly CitaContext _citaContext;
        private readonly DbSet<TEntity> entities;

        public BaseRepository(CitaContext citaContext)
        {
            _citaContext = citaContext ?? throw new ArgumentNullException(nameof(citaContext));
            entities = _citaContext.Set<TEntity>(); 
        }

        public virtual async Task<OperationRessult> Exists(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                bool exists = await entities.AnyAsync(filter);
                return new OperationRessult { Success = true, Message = "Exists: " + exists };
            }
            catch (Exception ex)
            {
                return new OperationRessult { Success = false, Message = ex.Message };
            }
        }

        public virtual async Task<OperationRessult> GetEntityBy(int id)
        {
            OperationRessult result = new OperationRessult();
            try
            {
                var entity = await entities.FindAsync(id); 
                if (entity != null)
                {
                    result.Success = true;
                    result.Data = entity; 
                }
                else
                {
                    result.Success = false;
                    result.Message = "Entity not found.";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result; 
        }

        public virtual async Task<OperationRessult> GetAll()
        {
            OperationRessult result = new OperationRessult();
            try
            {
                var datos = await entities.ToListAsync(); 
                result.Success = true;
                result.Data = datos; 
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ocurrió un error: {ex.Message} al obtener los registros.";
            }
            return result; 
        }

        public virtual async Task<OperationRessult> Remove(TEntity entity)
        {
            OperationRessult result = new OperationRessult();
            try
            {
                entities.Remove(entity);
                await _citaContext.SaveChangesAsync(); 
                result.Success = true;
                result.Message = "Entity removida correctamente.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error removiendo la entidad: {ex.Message}";
            }
            return result; 
        }

        public virtual async Task<OperationRessult> Save(TEntity entity)
        {
            OperationRessult result = new OperationRessult();
            try
            {
                await entities.AddAsync(entity); 
                await _citaContext.SaveChangesAsync(); 
                result.Success = true;
                result.Message = "Entity guardada correctamente.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error guardando la entidad: {ex.Message}";
            }
            return result; 
        }

        public virtual async Task<OperationRessult> Update(TEntity entity)
        {
            OperationRessult result = new OperationRessult();
            try
            {
                entities.Update(entity); 
                await _citaContext.SaveChangesAsync(); // Guarda los cambios
                result.Success = true;
                result.Message = "Entity actualizada.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error actualizando la entity: {ex.Message}";
            }
            return result;
        }

        public List<OperationRessult> GettAll()
        {
            throw new NotImplementedException();
        }

        internal void Update(object entity)
        {
            throw new NotImplementedException();
        }
    }
}

       

