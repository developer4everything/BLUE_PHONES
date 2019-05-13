using System;
using System.ComponentModel.DataAnnotations;
using Catalog.Domain.SeedWork;

namespace Catalog.Domain.Entities
{
    public class CatalogItem : Entity
    {
        [Key]
        public Int64 Code { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String ImageUrl { get; set; }
        public Decimal Price { get; set; }
        public String Brand { get; set; }
        public String Colour { get; set; }
        public Decimal? Width { get; set; }
        public Decimal? Height { get; set; }
        public Decimal? Thickness { get; set; }
        public Decimal? Weight { get; set; }
        public String Processor { get; set; }
        public Decimal? Screen { get; set; }
        public Byte? FrontCamera { get; set; }
        public Byte? RearCamera { get; set; }
        public Int16? Battery { get; set; }
        public Int16? InternalMemory { get; set; }
        public Int16? RamMemory { get; set; }
        public String OperatingSystem { get; set; }

        public CatalogItem()
        {
            GenerateNewIdentity();
        }
    }
}
