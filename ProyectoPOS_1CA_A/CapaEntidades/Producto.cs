using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOS_1CA_A.CapaEntidades
{
    public class Producto //Poner el nivel de accesso en publico
    {
        // Definir atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Estado { get; set; } 
    }
}
