using System;
using CoffeeRent.Models;
using CoffeeRent.Controllers.@enum;

namespace CoffeeRent.Services.Implements
{
	public class ProductosService : IcrudProductos<Productos>
	{

        static IList<Productos> ListaProductos = new List<Productos>();

		public ProductosService()
		{

            if (ListaProductos.Count == 0)
            {
                Productos nuevoProducto = new Productos();

                nuevoProducto.id = 1;
                nuevoProducto.nombre = "Cafe Margarita";
                nuevoProducto.descripcion = "Cafe granulado";
                nuevoProducto.precio = 22000;
                nuevoProducto.stock = 100;
                nuevoProducto.tipo_id = TipoProducto.cafe;
                nuevoProducto.descuento_id = 1;


                Productos producto2 = new Productos();
                producto2.id = 2;
                producto2.nombre = "Cafetera automatica";
                producto2.descripcion = "Cafetera automatica grande de 5000 litros";
                producto2.precio = 90000000;
                producto2.stock = 5;
                producto2.tipo_id = TipoProducto.cafetera;
                producto2.descuento_id = 1;

                ListaProductos.Add(nuevoProducto);
                ListaProductos.Add(producto2);
            }

		}

        public IList<Productos> obtieneProductos()
        {
            return ListaProductos;
        }


        public IList<Productos> BuscaProductos(String etiqueta)
        {

            IList<Productos> ProductosResultado = new List<Productos>();

            foreach (Productos producto in ListaProductos)
            {
                if (producto.nombre.ToLower().Contains(etiqueta) || producto.descripcion.ToLower().Contains(etiqueta))
                {
                    ProductosResultado.Add(producto);
                }
            }

            return ProductosResultado;
        }

       
    }
}

