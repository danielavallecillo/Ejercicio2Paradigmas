using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Paradigmas.Modelo
{
    internal class M_Producto
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public double stock { get; set; }

        public M_Producto(string codigo, string nombre, double precio, double stock)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }
    }
}