using Proyecto_POSFerreteria.Presentacion;
using ProyectoPOS_1CA_A.CapaEntidades;
using ProyectoPOS_1CA_A.CapaPresentacioDn;
using ProyectoPOS_1CA_A.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOS_1CA_A
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear instancia en el forlulario
            FrmCliente2 frn = new FrmCliente2();
            frn.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            frm.ShowDialog();
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVentaRapida_Click(object sender, EventArgs e)
        {
            FrmVentaRapida frm = new FrmVentaRapida();
            frm.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            //Creo una instacia del forulario
            FrmProducto frm = new FrmProducto();
            //Muestra el formulario
            frm.ShowDialog(); 

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

            lblUsuario.Text = $"Usuario: {SesionActual.NombreUsuario} - Rol: {SesionActual.Rol}";

            /// Control básico por rol
            //Con este codigo deshabilitamos un botón de prueba para el usuario cajero, por ejemplo que no pueda Registrar Cliente(ojo esto es solo prueba)
            switch (SesionActual.Rol)
            {
                case "Admin":
                    // todo habilitado
                    break;
                case "Cajero":
                    btnClientes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;
                default:
                    btnClientes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;

            }
        }

            

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            FrmPruebas frm = new FrmPruebas();
            frm.ShowDialog();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuario: {SesionActual.NombreUsuario} - Rol: {SesionActual.Rol}";

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();

        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambiarClave frm = new FrmCambiarClave();
            frm.ShowDialog();

        }
    }
}
