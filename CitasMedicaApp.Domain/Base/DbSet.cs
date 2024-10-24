using System.Linq.Expressions;

namespace CitasMedicaApp.Domain.Base
{
    internal class DbSet<TEntity> where TEntity : class
    {
        internal async Task AddAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        internal async Task<bool> AnyAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class
        {
            throw new NotImplementedException();
        }

        internal async Task<dynamic?> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        internal void Remove<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        internal async Task<dynamic?> ToListAsync()
        {
            throw new NotImplementedException();
        }

        internal void Update<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}