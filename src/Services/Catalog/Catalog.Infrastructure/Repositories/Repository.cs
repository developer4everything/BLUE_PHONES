using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Domain.SeedWork;
using Catalog.Infrastructure.Context;

namespace Catalog.Infrastructure.Repositories
{
    /// <summary>
    /// Repository base class.
    /// </summary>
    /// <typeparam name="TEntity">The type of underlying entity in this repository.</typeparam>
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        #region Members

        protected readonly CatalogContext DbContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Create a new instance of repository.
        /// </summary>
        /// <param name="dbContext">Associated DB context.</param>
        public Repository(CatalogContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        #endregion

        #region IRepository Members

        /// <summary>
        /// <see cref="IRepository{TEntity}"/>
        /// </summary>
        /// <param name="id"><see cref="IRepository{TEntity}"/></param>
        /// <returns><see cref="IRepository{TEntity}"/></returns>
        public virtual TEntity Get(Int64 id)
        {
            return id != 0 ? DbContext.Set<TEntity>().Find(id) : null;
        }

        /// <summary>
        /// <see cref="IRepository{TEntity}"/>
        /// </summary>
        /// <param name="filter"><see cref="IRepository{TEntity}"/></param>
        /// <returns><see cref="IRepository{TEntity}"/></returns>
        public virtual TEntity GetBy(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            return DbContext.Set<TEntity>().FirstOrDefault(filter);
        }

        /// <summary>
        /// <see cref="IRepository{TEntity}"/>
        /// </summary>
        /// <returns><see cref="IRepository{TEntity}"/></returns>
        public virtual IQueryable<TEntity> GetAll()
        {
            return DbContext.Set<TEntity>();
        }

        /// <summary>
        /// <see cref="IRepository{TEntity}"/>
        /// </summary>
        /// <param name="filter"><see cref="IRepository{TEntity}"/></param>
        /// <returns><see cref="IRepository{TEntity}"/></returns>
        public virtual IEnumerable<TEntity> GetFiltered(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            return DbContext.Set<TEntity>().Where(filter);
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// <see cref="M:System.IDisposable.Dispose"/>
        /// </summary>
        public void Dispose()
        {
            DbContext?.Dispose();
        }

        #endregion
    }
}
