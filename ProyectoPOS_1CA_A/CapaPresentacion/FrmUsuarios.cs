using ProyectoPOS_1CA_A.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POSFerreteria.Presentacion
{
    public partial class FrmUsuarios : Form
    {
        int x, y;
        bool move = false;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            cmbRol.Items.AddRange(new string[] { "Admin", "Cajero", "Mesero" });

        }
        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = UsuarioBLL.Listar().Select(u => new {
                u.IdUsuario,
                u.NombreUsuario,
                u.Rol,
                Estado = u.Estado ? "Activo" : "Inactivo"
            }).ToList();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVolver_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x = e.X;
            y = e.Y;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                var r = MessageBox.Show("¿Eliminar usuario?", "Confirmar", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    bool ok = UsuarioBLL.Eliminar(id);
                    MessageBox.Show(ok ? "Eliminado" : "No eliminado");
                    CargarUsuarios();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA SALIR?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = UsuarioBLL.Insertar(txtNombreUsuario.Text.Trim(), txtClave.Text.Trim(), cmbRol.Text);
                MessageBox.Show("Usuario creado ID: " + id);
                Limpiar();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                bool estado = chkEstado.Checked;
                bool ok = UsuarioBLL.Actualizar(id, txtNombreUsuario.Text.Trim(), cmbRol.Text, estado);
                MessageBox.Show(ok ? "Actualizado" : "No se actualizó");
                CargarUsuarios();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value.ToString();
                txtNombreUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["NombreUsuario"].Value.ToString();
                cmbRol.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString();
                chkEstado.Checked = dgvUsuarios.Rows[e.RowIndex].Cells["Estado"].Value.ToString() == "Activo";
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();

        }
        private void Limpiar()
        {
            txtId.Text = "";
            txtNombreUsuario.Text = "";
            txtClave.Text = "";
            cmbRol.SelectedIndex = -1;
            chkEstado.Checked = false;
        }


        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
