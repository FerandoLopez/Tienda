using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidad;

namespace Manejador
{
    public class Productos
    {
        AccesoBase ab = new AccesoBase("localhost", "root", "berWUHDc", "tienda", 3306);
        public string Guardar(Producto producto)
        {
            return ab.Comando(string.Format("insert into producto values(null,'{0}','{1}','{2}')",
                 producto._Nombre, producto._Descripcion, producto._Precio));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = ab.Mostrar(string.Format("select * from producto where nombre like '%{0}%'", dato), "producto").Tables["producto"];
            tabla.AutoResizeColumns();
        }

        public string Editar(Producto producto)
        {
            return ab.Comando(string.Format("update producto set nombre='{0}', descripcion='{1}', precio='{2}' where IdProducto='{3}'", producto._Nombre,
                producto._Descripcion, producto._Precio, producto._IdProducto));
        }

        public string Borrar(Producto producto)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + producto._Nombre, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = ab.Comando(string.Format("delete from producto where IdProducto = {0}", producto._IdProducto));
            }
            return r;
        }
    }
}
