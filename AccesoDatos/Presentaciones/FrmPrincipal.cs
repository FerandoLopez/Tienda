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

        private void btnModificar_Click(object sender, EventArgs e)
        {

            FrmAdd ad = new FrmAdd();
            ad.ShowDialog();
            Actualizar();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            pr._IdProducto = int.Parse(dtgDatos.Rows[i].Cells[0].Value.ToString());
            pr._Nombre = dtgDatos.Rows[i].Cells[1].Value.ToString();
            pr._Descripcion = dtgDatos.Rows[i].Cells[2].Value.ToString();
            pr._Precio = dtgDatos.Rows[i].Cells[3].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgDatos.RowCount > 0)
            {
                string r = p.Borrar(pr);
                if (string.IsNullOrEmpty(r))
                {
                    MessageBox.Show(r);
                    Actualizar();
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un registro");
            }
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
