namespace CoffeeRenteConsoleTest;

class Program
{
    public class Productos
    {

        public int id { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public int precio { get; set; }
        public int stock { get; set; }
        public int tipo_id { get; set; }
        public int descuento_id { get; set; }


        public Productos()
        {
            this.id = new int();
            this.nombre = String.Empty;
            this.descripcion = String.Empty;
            this.precio = new int();
            this.stock = new int();
            this.tipo_id = 1;
            this.descuento_id = new int();

        }

        public Productos(int id, String nombre, String descripcion, int precio, int stock, int tipo_id, int descuento_id)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
            this.tipo_id = tipo_id;
            this.descuento_id = descuento_id;
        }
    }

    static void Main(string[] args)
    {

        Productos producto = new Productos();
        producto.id = 1;
        producto.nombre = "Cafe Margarita";
        producto.descripcion = "Cafe granulado";
        producto.precio = 22000;
        producto.stock = 100;
        producto.tipo_id = 2;
        producto.descuento_id = 1;

        Productos producto2 = new Productos();
        producto2.id = 2;
        producto2.nombre = "Cafe Grano";
        producto2.descripcion = "Cafe puro";
        producto2.precio = 33000;
        producto2.stock = 80;
        producto2.tipo_id = 2;
        producto2.descuento_id = 1;

        IList<Productos> listaProductos = new List<Productos>();

        listaProductos.Add(producto);
        listaProductos.Add(producto2);


        foreach(Productos p in listaProductos)
        {
            if (p.nombre.ToLower().Contains("margarita"))
            {
                Console.WriteLine(p.nombre.ToString());
                return;
            }

            
        }


       
    }
}

