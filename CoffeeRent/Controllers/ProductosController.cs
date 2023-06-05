using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeeRent.Services;
using CoffeeRent.Services.Implements;
using CoffeeRent.Models;

namespace CoffeeRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {

        IcrudProductos<Productos> productosServicio = new ProductosService();

        // GET: api/Productos
        [HttpGet]
        public IList<Productos> Get()
        {
            return productosServicio.obtieneProductos();
        }

        // GET: api/Productos/5
        [HttpGet("{etiqueta}", Name = "Get")]
        public IList<Productos> Get(string etiqueta)
        {
            return productosServicio.BuscaProductos(etiqueta);
        }

        // POST: api/Productos
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Productos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Productos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
