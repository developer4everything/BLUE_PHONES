using System;
using System.Collections.Generic;
using System.Net;
using Catalog.Domain.Entities;
using Catalog.Domain.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        #region Members

        private readonly ICatalogRepository _catalogRepository;

        #endregion

        #region Constructor

        public CatalogController(ICatalogRepository catalogRepository)
        {
            _catalogRepository = catalogRepository;
        }

        #endregion

        #region Public Methos

        // GET api/catalog
        [HttpGet]
        [EnableCors("_allowAllOrigins")]
        [ProducesResponseType(typeof(IEnumerable<CatalogItem>), (int)HttpStatusCode.OK)]
        public ActionResult<IEnumerable<CatalogItem>> GetAll()
        {
            var catalogItems = _catalogRepository.GetAll();

            return Ok(catalogItems);
        }

        // GET api/catalog/5
        [HttpGet("{id}")]
        [EnableCors("_allowAllOrigins")]
        [ProducesResponseType(typeof(CatalogItem), (int)HttpStatusCode.OK)]
        public ActionResult<CatalogItem> Get(Int64 id)
        {
            var catalogItem = _catalogRepository.Get(id);

            return Ok(catalogItem);
        }

        #endregion
    }
}
