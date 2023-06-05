using System;
namespace CoffeeRent.Services
{
	public interface IcrudProductos<T>
	{

		public IList<T> obtieneProductos();
        public IList<T> BuscaProductos(String nombre);
		
	}
}

