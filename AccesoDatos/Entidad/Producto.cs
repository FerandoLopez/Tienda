using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {
        public int _IdProducto { get; set; }
        public string _Nombre { get; set; }
        public string _Descripcion { get; set; }
        public double _Precio { get; set; }

        public Producto(int idproducto, string nombre, string descripcion, double precio)
        {
            _IdProducto = idproducto;
            _Nombre = nombre;
            _Descripcion = descripcion;
            _Precio = precio;
        }

        public Producto()
        {

        }
    }
}
