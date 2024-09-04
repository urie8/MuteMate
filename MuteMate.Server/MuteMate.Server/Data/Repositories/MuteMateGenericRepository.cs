using Microsoft.EntityFrameworkCore;

namespace MuteMate.Server.Data.Repositories
{
    public class MuteMateGenericRepository<T> : IMuteMateRepository<T> where T : class
    {
        private readonly MuteMateDbContext _context;
        private readonly DbSet<T> _dbSet;

        public MuteMateGenericRepository(MuteMateDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public MuteMateDbContext Context => _context;

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Attach(entity); //Fäster entiteten i kontexten
            _context.Entry(entity).State = EntityState.Modified; //modifierad
            await _context.SaveChangesAsync(); // Uppdaterad i databas
        }

        public async Task DeleteAsync(int id)
        {
            T? entityToDelete = await GetByIdAsync(id);

            if (entityToDelete != null)
            {
                _dbSet.Remove(entityToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
