using Catalog.Domain.Entities;
using Catalog.Domain.Interfaces;
using Catalog.Infrastructure.Context;

namespace Catalog.Infrastructure.Repositories
{
    public class CatalogRepository : Repository<CatalogItem>, ICatalogRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public CatalogRepository(CatalogContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
