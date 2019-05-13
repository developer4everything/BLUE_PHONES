using Catalog.Domain.Entities;
using Catalog.Domain.SeedWork;

namespace Catalog.Domain.Interfaces
{
    public interface ICatalogRepository : IRepository<CatalogItem>
    {
    }
}
