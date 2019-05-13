using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Catalog.Domain.SeedWork
{
    /// <summary>
    /// Base interface for implement the repository pattern.
    /// </summary>
    /// <typeparam name="TEntity">Type of entity for this repository.</typeparam>
    public interface IRepository<TEntity> : IDisposable
        where TEntity : Entity
    {
        /// <summary>
        /// Get an element of type TEntity by entity key.
        /// </summary>
        /// <param name="id">Entity key value.</param>
        /// <returns>Element by identity.</returns>
        TEntity Get(Int64 id);

        /// <summary>
        /// Get an element of type TEntity based on a filter.
        /// </summary>
        /// <param name="filter">Filter that element do match.</param>
        /// <returns>Element by filter.</returns>
        TEntity GetBy(Expression<Func<TEntity, Boolean>> filter);

        /// <summary>
        /// Get all elements of type TEntity.
        /// </summary>
        /// <returns>List of selected elements.</returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Get the elements of type TEntity based on a filter.
        /// </summary>
        /// <param name="filter">Filter that each element do match.</param>
        /// <returns>List of selected elements.</returns>
        IEnumerable<TEntity> GetFiltered(Expression<Func<TEntity, Boolean>> filter);
    }
}
