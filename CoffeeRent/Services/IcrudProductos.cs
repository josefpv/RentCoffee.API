using System;
using CoffeeRent.Controllers.@enum;
using CoffeeRent.Models;

namespace CoffeeRent.Services
{
	public interface IcrudProductos<T>
	{

		public IList<T> obtieneProductos();
        public IList<T> BuscaProductos(String nombre);
		public Productos IngresaProducto(String nombre, String descripcion, int precio, TipoProducto tipoId, int descuentoId, int stock = 1);
		public Productos ActualizaProducto(String id, Productos producto);

    }
}

