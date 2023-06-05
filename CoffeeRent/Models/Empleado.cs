using System;
using CoffeeRent.Models.@enum;

namespace CoffeeRent.Models
{
	public class Empleado
	{
		public int run { get; set; }
		public char dv { get; set; }
		public String nombres { get; set; }
		public String apellidos { get; set; }
		public String email { get; set; }
		public TipoEmpleado tipoEmpleado { get; set; }
		
		public Empleado()
		{
			this.run = new int();
			this.dv = new char();
			this.nombres = String.Empty;
			this.apellidos = String.Empty;
			this.email = String.Empty;
			this.tipoEmpleado = TipoEmpleado.vendedor;
		}

        public Empleado(int run, char dv, String nombres, String apellidos, String email, TipoEmpleado tipoEmpleado)
        {
            this.run = run;
            this.dv =  dv;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.email = email;
            this.tipoEmpleado = tipoEmpleado;
        }
    }
}

