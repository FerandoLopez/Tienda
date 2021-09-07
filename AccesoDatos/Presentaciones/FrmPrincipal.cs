using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;
using Entidad;

namespace Presentaciones
{
    public partial class FrmPrincipal : Form
    {
        Productos p;
        int i = 0;
        public static Producto pr;
        public FrmPrincipal()
        {
            InitializeComponent();
            p = new Productos();
            pr = new Producto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pr._IdProducto = 0;
            pr._Nombre = "";
            pr._Descripcion = "";
            pr._Precio = "";
            FrmAdd ad = new FrmAdd();
            ad.ShowDialog();
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            p.Mostrar(dtgDatos, txtBuscar.Text);
        }
    }
}
