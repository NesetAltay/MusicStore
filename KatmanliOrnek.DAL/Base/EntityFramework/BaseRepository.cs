using KatmanliOrnek.Core.BaseEntities;
using KatmanliOrnek.Core.Enums;
using KatmanliOrnek.Core.IBaseRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KatmanliOrnek.DAL.Base.EntityFramework
{
    public abstract class BaseRepository<TEntity, TContex> : IBaseRepository<TEntity>
        where TEntity : BaseEntity
        where TContex : DbContext
    {
        protected readonly TContex _db;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(TContex contex)
        {
            _db = contex;
            _dbSet = _db.Set<TEntity>();
        }

        public bool Any(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Any(filter);
        }

        public TEntity? Create(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Added;

            return _db.SaveChanges() > 0 ? entity : null;
        }

        public bool Delete(TEntity entity)
        {
            bool hasProperty = HasOwnProperty(typeof(TEntity), "DeleteDate");

            if (!hasProperty)
            {
                entity.State = State.Deleted;
                TEntity statedEntity = Update(entity);
                return statedEntity != null ? true : false;
            }
            else
            {
                _db.Entry(entity).State = EntityState.Deleted;
                return _db.SaveChanges() > 0;
            }

        }

        private bool HasOwnProperty(Type entityType, string propertyName)
        {
            var properties = entityType.GetProperties();
            bool hasproperty = properties.Any(p => p.Name == propertyName);
            return hasproperty;
        }

        public ICollection<TEntity>? GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Where(filter).ToList();
        }

        public ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<TEntity, TResult>> select,
                                                              Expression<Func<TEntity, bool>> where,
                                                              Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                                              params Expression<Func<TEntity, object>>[] inculudes)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }
            if(inculudes != null)
            {
                query = query.MyIncludes(inculudes);
            }

            if (orderBy != null)
            {
                return orderBy(query).Select(select).ToList();
            }
            else
            {
                return query.Select(select).ToList();
            }

        }

        public TResult? GetFiltredFirstOrDefault<TResult>(Expression<Func<TEntity, TResult>> select,
                                                          Expression<Func<TEntity, bool>> where,
                                                          Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, params Expression<Func<TEntity, object>>[] inculudes)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            if (inculudes != null)
            {
                query = query.MyIncludes(inculudes);
            }

            if (orderBy != null)
            {
                return orderBy(query).Select(select).FirstOrDefault();
            }

            return query.Select(select).FirstOrDefault();
        }

        public TEntity? GetFirstOrDefault(Expression<Func<TEntity, bool>> filter)
        {
           return _dbSet.FirstOrDefault(filter);
        }

        public TEntity? Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            return _db.SaveChanges() > 0 ? entity : null;
        }
    }
}
