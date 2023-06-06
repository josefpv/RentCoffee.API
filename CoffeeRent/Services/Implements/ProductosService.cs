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

                nuevoProducto.id = "DFlg-456ld6-6eerf";
                nuevoProducto.nombre = "Cafe Margarita";
                nuevoProducto.descripcion = "Cafe granulado";
                nuevoProducto.precio = 22000;
                nuevoProducto.stock = 100;
                nuevoProducto.tipo_id = TipoProducto.cafe;
                nuevoProducto.descuento_id = 1;


                Productos producto2 = new Productos();
                producto2.id = "sdfs45-35xgG";
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

        public Productos IngresaProducto(string nombre, string descripcion, int precio, TipoProducto tipoId, int descuentoId, int stock = 1)
        {
            Productos nuevoProducto = new Productos(nombre, descripcion, precio, stock, tipoId, descuentoId);
            ListaProductos.Add(nuevoProducto);
            return nuevoProducto;

        }

        public Productos ActualizaProducto(String id, Productos datosProducto)
        {
            

            int index = 0;

            foreach(Productos producto in ListaProductos)
            {
                if (producto.id == id)
                {
                    index = ListaProductos.IndexOf(producto);
                }
            }

            if (index == 0)
            {
                //rutina a ejecutar si no se consigue producto
                return new Productos();
            }
            else
            {
                ListaProductos[index].nombre = datosProducto.nombre;
                ListaProductos[index].descripcion = datosProducto.descripcion;
                ListaProductos[index].precio = datosProducto.precio;
                ListaProductos[index].tipo_id = datosProducto.tipo_id;
                ListaProductos[index].descuento_id = datosProducto.descuento_id;
                ListaProductos[index].stock = datosProducto.stock;

                return ListaProductos[index];
            }

        
        }
    }
}

