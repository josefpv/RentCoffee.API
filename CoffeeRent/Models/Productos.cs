using System;
using CoffeeRent.Controllers.@enum;

namespace CoffeeRent.Models
{
	public class Productos
	{

		public string id { get; set; }
		public String nombre { get; set; }
		public String descripcion { get; set; }
		public int precio { get; set; }
		public int stock { get; set; }
		public TipoProducto tipo_id { get; set; }
		public int descuento_id { get; set; }


		public Productos()
		{
            //se genera la id de manera aleatoria
            String id = Guid.NewGuid().ToString();
			this.id = id;
            this.nombre = String.Empty;
			this.descripcion = String.Empty;
			this.precio = new int();
			this.stock = new int();
			this.tipo_id = TipoProducto.sin_definir;
			this.descuento_id = new int();

		}

		public Productos(String nombre, String descripcion, int precio, int stock, TipoProducto tipo_id, int descuento_id)
		{
			//se genera la id de manera aleatoria
			String id = Guid.NewGuid().ToString();

			this.id = id;
			this.nombre = nombre;
			this.descripcion = descripcion;
			this.precio = precio;
			this.stock = stock;
			this.tipo_id = tipo_id;
			this.descuento_id = descuento_id;
		}
	}



}

