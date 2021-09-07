using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Manejador;

namespace Presentaciones
{
    public partial class FrmAdd : Form
    {
        Productos p;
        public FrmAdd()
        {
            InitializeComponent();
            p = new Productos();
            if (!FrmPrincipal.pr._IdProducto.Equals(""))
            {
                txtNombre.Text = FrmPrincipal.pr._Nombre;
                txtDescripcion.Text = FrmPrincipal.pr._Descripcion;
                txtPrecio.Text = FrmPrincipal.pr._Precio;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmPrincipal.pr._IdProducto==0)
            {
                MessageBox.Show(p.Guardar(new Producto(FrmPrincipal.pr._IdProducto, txtNombre.Text, txtDescripcion.Text,
                    txtPrecio.Text)));
                Close();
            }
            else
            {
                MessageBox.Show(p.Editar(new Producto(FrmPrincipal.pr._IdProducto, txtNombre.Text, txtDescripcion.Text,
                    txtPrecio.Text)));
            }
            Close();
        }
    }
}

